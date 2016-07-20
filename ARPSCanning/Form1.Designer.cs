namespace ARPSCanning
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.lview_name = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbox_ipaddr = new System.Windows.Forms.ComboBox();
            this.cbox_device = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbox_ip = new System.Windows.Forms.TextBox();
            this.tbox_mac = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_stop = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Scan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lview_name
            // 
            this.lview_name.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.lview_name.Location = new System.Drawing.Point(1, 86);
            this.lview_name.Name = "lview_name";
            this.lview_name.Size = new System.Drawing.Size(425, 274);
            this.lview_name.TabIndex = 6;
            this.lview_name.UseCompatibleStateImageBehavior = false;
            this.lview_name.View = System.Windows.Forms.View.Details;
            this.lview_name.Click += new System.EventHandler(this.lview_name_Click);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "IP";
            this.columnHeader2.Width = 154;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "MAC";
            this.columnHeader3.Width = 180;
            // 
            // cbox_ipaddr
            // 
            this.cbox_ipaddr.FormattingEnabled = true;
            this.cbox_ipaddr.Location = new System.Drawing.Point(74, 49);
            this.cbox_ipaddr.Name = "cbox_ipaddr";
            this.cbox_ipaddr.Size = new System.Drawing.Size(219, 23);
            this.cbox_ipaddr.TabIndex = 11;
            // 
            // cbox_device
            // 
            this.cbox_device.FormattingEnabled = true;
            this.cbox_device.Location = new System.Drawing.Point(74, 10);
            this.cbox_device.Name = "cbox_device";
            this.cbox_device.Size = new System.Drawing.Size(219, 23);
            this.cbox_device.TabIndex = 10;
            this.cbox_device.SelectedIndexChanged += new System.EventHandler(this.cbox_device_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "IPADDR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Device";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "IP";
            // 
            // tbox_ip
            // 
            this.tbox_ip.Location = new System.Drawing.Point(74, 376);
            this.tbox_ip.Name = "tbox_ip";
            this.tbox_ip.ReadOnly = true;
            this.tbox_ip.Size = new System.Drawing.Size(239, 25);
            this.tbox_ip.TabIndex = 13;
            // 
            // tbox_mac
            // 
            this.tbox_mac.Location = new System.Drawing.Point(74, 415);
            this.tbox_mac.Name = "tbox_mac";
            this.tbox_mac.ReadOnly = true;
            this.tbox_mac.Size = new System.Drawing.Size(239, 25);
            this.tbox_mac.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "MAC";
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(319, 49);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(97, 23);
            this.btn_stop.TabIndex = 16;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(320, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 70);
            this.button2.TabIndex = 17;
            this.button2.Text = "Send";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(428, 448);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.tbox_mac);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbox_ip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lview_name);
            this.Controls.Add(this.cbox_ipaddr);
            this.Controls.Add(this.cbox_device);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lview_name;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ComboBox cbox_ipaddr;
        private System.Windows.Forms.ComboBox cbox_device;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbox_ip;
        private System.Windows.Forms.TextBox tbox_mac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button button2;
    }
}

