namespace WindowsFormsApp9
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtpasswork = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtusename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btnthoat);
            this.panel1.Controls.Add(this.btndangnhap);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(14, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 180);
            this.panel1.TabIndex = 1;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(270, 126);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btndangnhap
            // 
            this.btndangnhap.Location = new System.Drawing.Point(123, 126);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(75, 23);
            this.btndangnhap.TabIndex = 2;
            this.btndangnhap.Text = "Đăng nhập";
            this.btndangnhap.UseVisualStyleBackColor = true;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtpasswork);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(32, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(357, 36);
            this.panel3.TabIndex = 1;
            // 
            // txtpasswork
            // 
            this.txtpasswork.Location = new System.Drawing.Point(141, 8);
            this.txtpasswork.Name = "txtpasswork";
            this.txtpasswork.Size = new System.Drawing.Size(201, 20);
            this.txtpasswork.TabIndex = 1;
            this.txtpasswork.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtusename);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(32, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 37);
            this.panel2.TabIndex = 0;
            // 
            // txtusename
            // 
            this.txtusename.Location = new System.Drawing.Point(141, 8);
            this.txtusename.Name = "txtusename";
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
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 202);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtpasswork;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtusename;
        private System.Windows.Forms.Label label1;
    }
}

