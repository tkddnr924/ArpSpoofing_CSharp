using PacketDotNet;
using SharpPcap;
using SharpPcap.LibPcap;
using System;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace ARPSCanning
{
    public partial class Form1 : Form
    {
        bool flag = false;
        int index;
        Thread thread;
        public Form1()
        {
            InitializeComponent();
            var devices = LibPcapLiveDeviceList.Instance;
            if (devices.Count < 1)
            {
                MessageBox.Show("장치 검색 실패");
            }
            foreach (var device in devices)
            {
                cbox_device.Items.Add(device.Description);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cbox_device.Text.Equals(""))
            {
                MessageBox.Show("디바이스 선택 안됨...");
                cbox_device.Focus();
                return;
            }
            if (cbox_ipaddr.Text.Equals(""))
            {
                MessageBox.Show("IP 선택 안됨...");
                cbox_ipaddr.Focus();
                return;
            }
            lview_name.Items.Clear();
            string ip_addr = cbox_ipaddr.Text;
            if (flag)
            {
                return;
            }
            int r_timeout = 1000;
            ICaptureDevice device = CaptureDeviceList.Instance[index];
            device.Open(DeviceMode.Promiscuous, r_timeout);

            thread = new Thread(() => ScanNetwork(device, ip_addr));
            thread.Start();
            if (thread.ThreadState == ThreadState.Aborted)
            {
                thread.Abort();
            }
        }

        private void ScanNetwork(ICaptureDevice dev, string ip_addr)
        {
            flag = true;
            LibPcapLiveDevice device = (LibPcapLiveDevice)dev;
            string ip;
            for (int i= 0;i<20;i++)
            {
                if (ip_addr.Length == 0)
                {
                    ip = "192.168.1.";
                }
                else
                {
                    ip = Regex.Replace(ip_addr, @"\d+$", "");
                }
                ip += i;
                string result = ScanHost(ip, device);
                if (result != "fail")
                    UpdateList(ip, result);
            }
            MessageBox.Show("완료");
            flag = false;
        }

        private string ScanHost(string ip, LibPcapLiveDevice device)
        {
            IPAddress t_ip = null;
            int delay = 1200000;
            bool pos = IPAddress.TryParse(ip, out t_ip);
            if (!pos)
            {
                flag = false;
                return "fail";
            }
            ARP arp = new ARP(device);
            arp.Timeout = new TimeSpan(delay);

            var re_mac = arp.Resolve(t_ip);
            if (re_mac == null)
            {
                flag = false;
                return "fail";
            }
            else
            {
                string mac = FormatMac(re_mac);
                return mac;
            }
        }

        private string FormatMac(PhysicalAddress re_mac)
        {
            string m = re_mac.ToString();
            MatchCollection split = Regex.Matches(m, @"\w{2}");
            string mac = "";

            foreach (Match item in split)
            {
                mac += item.Value + ":";
            }

            return mac.Remove(mac.Length - 1);
        }

        private delegate void AddDelegate(string ip, string mac);
        internal void UpdateList(string ip, string mac)
        {
            if (lview_name.InvokeRequired)
            {
                AddDelegate del = new AddDelegate(UpdateList);
                Invoke(del, new object[] {ip, mac });
            }
            else
            {
                string[] strs = {ip, mac };
                ListViewItem lvi = new ListViewItem(strs);
                lview_name.Items.Add(lvi);
            }
        }
        private void cbox_device_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = cbox_device.SelectedIndex;
            var devices = LibPcapLiveDeviceList.Instance;
            var sel_device = devices[index];
            cbox_ipaddr.Items.Clear();
            cbox_ipaddr.ResetText();
            for (int i = 0; i < sel_device.Addresses.Count; i++)
            {
                cbox_ipaddr.Items.Add(sel_device.Addresses.ElementAt(i).Addr);
            }
        }


        private void lview_name_Click(object sender, EventArgs e)
        {
            if (lview_name.SelectedItems[0] == null)
            {
                return;
            }

            string ip = lview_name.SelectedItems[0].Text;
            string mac = lview_name.SelectedItems[0].SubItems[1].Text;
            tbox_ip.Text = ip;
            tbox_mac.Text = mac;
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            if (thread.ThreadState == ThreadState.Running)
            {
                thread.Abort();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var device = LibPcapLiveDeviceList.Instance[1];
            device.Open(DeviceMode.Promiscuous, 1000);
            IPAddress dst_ip = null;
            IPAddress src_ip = null;
            PhysicalAddress dst_mac = null;
            PhysicalAddress src_mac = null;

            dst_ip = IPAddress.Parse(tbox_ip.Text);
            dst_mac = PhysicalAddress.Parse(tbox_mac.Text.Replace(':', '-'));
            src_ip = IPAddress.Parse("192.168.0.1");
            src_mac = NetworkInterface.GetAllNetworkInterfaces()[1].GetPhysicalAddress();

            ARPPacket arp = new ARPPacket(ARPOperation.Response, dst_mac, dst_ip, src_mac, src_ip);
            EthernetPacket epacket = new EthernetPacket(src_mac, dst_mac, EthernetPacketType.Arp);
            MessageBox.Show("Hardware len:" + arp.HardwareAddressType);
            MessageBox.Show("prot len:" + arp.ProtocolAddressType);
            epacket.PayloadPacket = arp;
            device.SendPacket(epacket);
            device.Close();
        }
    }
}
