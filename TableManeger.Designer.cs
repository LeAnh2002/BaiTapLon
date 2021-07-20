namespace WindowsFormsApp9
{
    partial class TableManeger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableManeger));
            this.flptable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nmfoodcount = new System.Windows.Forms.NumericUpDown();
            this.btnaddfood = new System.Windows.Forms.Button();
            this.cbfood = new System.Windows.Forms.ComboBox();
            this.cbcategory = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.nmgiamgia = new System.Windows.Forms.NumericUpDown();
            this.btngiamgia = new System.Windows.Forms.Button();
            this.btnthanhtoan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvbill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmfoodcount)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmgiamgia)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flptable
            // 
            this.flptable.AutoScroll = true;
            this.flptable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flptable.BackgroundImage")));
            this.flptable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flptable.Location = new System.Drawing.Point(9, 30);
            this.flptable.Name = "flptable";
            this.flptable.Size = new System.Drawing.Size(430, 418);
            this.flptable.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nmfoodcount);
            this.panel4.Controls.Add(this.btnaddfood);
            this.panel4.Controls.Add(this.cbfood);
            this.panel4.Controls.Add(this.cbcategory);
            this.panel4.Location = new System.Drawing.Point(448, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(348, 64);
            this.panel4.TabIndex = 9;
            // 
            // nmfoodcount
            // 
            this.nmfoodcount.Location = new System.Drawing.Point(292, 23);
            this.nmfoodcount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmfoodcount.Name = "nmfoodcount";
            this.nmfoodcount.Size = new System.Drawing.Size(46, 20);
            this.nmfoodcount.TabIndex = 3;
            this.nmfoodcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmfoodcount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnaddfood
            // 
            this.btnaddfood.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddfood.Location = new System.Drawing.Point(211, 8);
            this.btnaddfood.Name = "btnaddfood";
            this.btnaddfood.Size = new System.Drawing.Size(75, 49);
            this.btnaddfood.TabIndex = 2;
            this.btnaddfood.Text = "Thêm món ";
            this.btnaddfood.UseVisualStyleBackColor = true;
            this.btnaddfood.Click += new System.EventHandler(this.btnaddfood_Click);
            // 
            // cbfood
            // 
            this.cbfood.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbfood.FormattingEnabled = true;
            this.cbfood.Location = new System.Drawing.Point(3, 33);
            this.cbfood.Name = "cbfood";
            this.cbfood.Size = new System.Drawing.Size(188, 23);
            this.cbfood.TabIndex = 1;
            // 
            // cbcategory
            // 
            this.cbcategory.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcategory.FormattingEnabled = true;
            this.cbcategory.Location = new System.Drawing.Point(3, 3);
            this.cbcategory.Name = "cbcategory";
            this.cbcategory.Size = new System.Drawing.Size(188, 23);
            this.cbcategory.TabIndex = 0;
            this.cbcategory.SelectedIndexChanged += new System.EventHandler(this.cbcategory_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtTotalPrice);
            this.panel3.Controls.Add(this.nmgiamgia);
            this.panel3.Controls.Add(this.btngiamgia);
            this.panel3.Controls.Add(this.btnthanhtoan);
            this.panel3.Location = new System.Drawing.Point(445, 394);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(359, 54);
            this.panel3.TabIndex = 8;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTotalPrice.ForeColor = System.Drawing.Color.Maroon;
            this.txtTotalPrice.Location = new System.Drawing.Point(123, 16);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(130, 22);
            this.txtTotalPrice.TabIndex = 5;
            this.txtTotalPrice.Text = "0";
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nmgiamgia
            // 
            this.nmgiamgia.Location = new System.Drawing.Point(21, 30);
            this.nmgiamgia.Name = "nmgiamgia";
            this.nmgiamgia.Size = new System.Drawing.Size(75, 20);
            this.nmgiamgia.TabIndex = 2;
            this.nmgiamgia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btngiamgia
            // 
            this.btngiamgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngiamgia.Location = new System.Drawing.Point(21, 0);
            this.btngiamgia.Name = "btngiamgia";
            this.btngiamgia.Size = new System.Drawing.Size(75, 27);
            this.btngiamgia.TabIndex = 1;
            this.btngiamgia.Text = "Giảm giá";
            this.btngiamgia.UseVisualStyleBackColor = true;
            // 
            // btnthanhtoan
            // 
            this.btnthanhtoan.Location = new System.Drawing.Point(280, 6);
            this.btnthanhtoan.Name = "btnthanhtoan";
            this.btnthanhtoan.Size = new System.Drawing.Size(75, 42);
            this.btnthanhtoan.TabIndex = 0;
            this.btnthanhtoan.Text = "Thanh toán";
            this.btnthanhtoan.UseVisualStyleBackColor = true;
            this.btnthanhtoan.Click += new System.EventHandler(this.btnthanhtoan_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvbill);
            this.panel2.Location = new System.Drawing.Point(442, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(362, 293);
            this.panel2.TabIndex = 7;
            // 
            // lsvbill
            // 
            this.lsvbill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvbill.GridLines = true;
            this.lsvbill.HideSelection = false;
            this.lsvbill.Location = new System.Drawing.Point(2, 3);
            this.lsvbill.Name = "lsvbill";
            this.lsvbill.Size = new System.Drawing.Size(357, 287);
            this.lsvbill.TabIndex = 0;
            this.lsvbill.UseCompatibleStateImageBehavior = false;
            this.lsvbill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 158;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 66;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 79;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(816, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // TableManeger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 457);
            this.Controls.Add(this.flptable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "TableManeger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TableManeger";
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmfoodcount)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmgiamgia)).EndInit();
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flptable;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown nmfoodcount;
        private System.Windows.Forms.Button btnaddfood;
        private System.Windows.Forms.ComboBox cbfood;
        private System.Windows.Forms.ComboBox cbcategory;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.NumericUpDown nmgiamgia;
        private System.Windows.Forms.Button btngiamgia;
        private System.Windows.Forms.Button btnthanhtoan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lsvbill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }
}