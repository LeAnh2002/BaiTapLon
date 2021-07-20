namespace WindowsFormsApp9
{
    partial class ThongTinCaNhan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinCaNhan));
            this.btnthoat = new System.Windows.Forms.Button();
            this.btncapnhap = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtremkm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtmkmoi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtpasswork = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txttenhienthi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtusename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnthoat
            // 
            this.btnthoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnthoat.Location = new System.Drawing.Point(254, 282);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 13;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btncapnhap
            // 
            this.btncapnhap.Location = new System.Drawing.Point(77, 282);
            this.btncapnhap.Name = "btncapnhap";
            this.btncapnhap.Size = new System.Drawing.Size(75, 23);
            this.btncapnhap.TabIndex = 12;
            this.btncapnhap.Text = "Cập nhập";
            this.btncapnhap.UseVisualStyleBackColor = true;
            this.btncapnhap.Click += new System.EventHandler(this.btncapnhap_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtremkm);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(43, 229);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(363, 45);
            this.panel5.TabIndex = 8;
            // 
            // txtremkm
            // 
            this.txtremkm.Location = new System.Drawing.Point(141, 8);
            this.txtremkm.Name = "txtremkm";
            this.txtremkm.Size = new System.Drawing.Size(201, 20);
            this.txtremkm.TabIndex = 1;
            this.txtremkm.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nhập lại mật khẩu mới";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtmkmoi);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(43, 178);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(363, 45);
            this.panel4.TabIndex = 11;
            // 
            // txtmkmoi
            // 
            this.txtmkmoi.Location = new System.Drawing.Point(141, 8);
            this.txtmkmoi.Name = "txtmkmoi";
            this.txtmkmoi.Size = new System.Drawing.Size(201, 20);
            this.txtmkmoi.TabIndex = 1;
            this.txtmkmoi.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mật khẩu mới";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtpasswork);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(43, 127);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(363, 45);
            this.panel3.TabIndex = 10;
            // 
            // txtpasswork
            // 
            this.txtpasswork.Location = new System.Drawing.Point(141, 8);
            this.txtpasswork.Name = "txtpasswork";
            this.txtpasswork.Size = new System.Drawing.Size(201, 20);
            this.txtpasswork.TabIndex = 1;
            this.txtpasswork.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txttenhienthi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(43, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 45);
            this.panel1.TabIndex = 9;
            // 
            // txttenhienthi
            // 
            this.txttenhienthi.Location = new System.Drawing.Point(141, 12);
            this.txttenhienthi.Name = "txttenhienthi";
            this.txttenhienthi.Size = new System.Drawing.Size(201, 20);
            this.txttenhienthi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên hiển thị";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtusename);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(43, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 45);
            this.panel2.TabIndex = 7;
            // 
            // txtusename
            // 
            this.txtusename.Location = new System.Drawing.Point(141, 12);
            this.txtusename.Name = "txtusename";
            this.txtusename.ReadOnly = true;
            this.txtusename.Size = new System.Drawing.Size(201, 20);
            this.txtusename.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // ThongTinCaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(465, 358);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btncapnhap);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "ThongTinCaNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongTinCaNhan";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btncapnhap;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtremkm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtmkmoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtpasswork;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txttenhienthi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtusename;
        private System.Windows.Forms.Label label1;
    }
}