namespace View
{
    partial class Form1
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
<<<<<<< HEAD
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
               this.panelSideMenu = new System.Windows.Forms.Panel();
               this.btnExit = new System.Windows.Forms.Button();
               this.btnHelp = new System.Windows.Forms.Button();
               this.btnTaiKhoan = new System.Windows.Forms.Button();
               this.panelDanhMucSubMenu = new System.Windows.Forms.Panel();
               this.btnChucVu = new System.Windows.Forms.Button();
               this.btnPhongBan = new System.Windows.Forms.Button();
               this.btnTrinhDoHocVan = new System.Windows.Forms.Button();
               this.btnTonGiao = new System.Windows.Forms.Button();
               this.btnDanToc = new System.Windows.Forms.Button();
               this.btnDanhMuc = new System.Windows.Forms.Button();
               this.panelQuanLySubMenu = new System.Windows.Forms.Panel();
               this.btnTimKiem = new System.Windows.Forms.Button();
               this.btnThongTinNhanVien = new System.Windows.Forms.Button();
               this.btnQuanLy = new System.Windows.Forms.Button();
               this.panelLogo = new System.Windows.Forms.Panel();
               this.label1 = new System.Windows.Forms.Label();
               this.panelChildForm = new System.Windows.Forms.Panel();
               this.panelSideMenu.SuspendLayout();
               this.panelDanhMucSubMenu.SuspendLayout();
               this.panelQuanLySubMenu.SuspendLayout();
               this.panelLogo.SuspendLayout();
               this.SuspendLayout();
               // 
               // panelSideMenu
               // 
               this.panelSideMenu.AutoScroll = true;
               this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
               this.panelSideMenu.Controls.Add(this.btnExit);
               this.panelSideMenu.Controls.Add(this.btnHelp);
               this.panelSideMenu.Controls.Add(this.btnTaiKhoan);
               this.panelSideMenu.Controls.Add(this.panelDanhMucSubMenu);
               this.panelSideMenu.Controls.Add(this.btnDanhMuc);
               this.panelSideMenu.Controls.Add(this.panelQuanLySubMenu);
               this.panelSideMenu.Controls.Add(this.btnQuanLy);
               this.panelSideMenu.Controls.Add(this.panelLogo);
               this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
               this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
               this.panelSideMenu.Name = "panelSideMenu";
               this.panelSideMenu.Size = new System.Drawing.Size(250, 711);
               this.panelSideMenu.TabIndex = 0;
               // 
               // btnExit
               // 
               this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
               this.btnExit.FlatAppearance.BorderSize = 0;
               this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
               this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
               this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnExit.ForeColor = System.Drawing.Color.Silver;
               this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
               this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.btnExit.Location = new System.Drawing.Point(0, 666);
               this.btnExit.Name = "btnExit";
               this.btnExit.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
               this.btnExit.Size = new System.Drawing.Size(250, 45);
               this.btnExit.TabIndex = 9;
               this.btnExit.Text = "  Exit";
               this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
               this.btnExit.UseVisualStyleBackColor = true;
               this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
               // 
               // btnHelp
               // 
               this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
               this.btnHelp.FlatAppearance.BorderSize = 0;
               this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
               this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
               this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnHelp.ForeColor = System.Drawing.Color.Silver;
               this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
               this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.btnHelp.Location = new System.Drawing.Point(0, 513);
               this.btnHelp.Name = "btnHelp";
               this.btnHelp.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
               this.btnHelp.Size = new System.Drawing.Size(250, 45);
               this.btnHelp.TabIndex = 8;
               this.btnHelp.Text = "    Help";
               this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
               this.btnHelp.UseVisualStyleBackColor = true;
               this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
               // 
               // btnTaiKhoan
               // 
               this.btnTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
               this.btnTaiKhoan.FlatAppearance.BorderSize = 0;
               this.btnTaiKhoan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
               this.btnTaiKhoan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
               this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnTaiKhoan.ForeColor = System.Drawing.Color.Silver;
               this.btnTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiKhoan.Image")));
               this.btnTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.btnTaiKhoan.Location = new System.Drawing.Point(0, 468);
               this.btnTaiKhoan.Name = "btnTaiKhoan";
               this.btnTaiKhoan.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
               this.btnTaiKhoan.Size = new System.Drawing.Size(250, 45);
               this.btnTaiKhoan.TabIndex = 6;
               this.btnTaiKhoan.Text = "  Tài khoản";
               this.btnTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.btnTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
               this.btnTaiKhoan.UseVisualStyleBackColor = true;
               this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
               // 
               // panelDanhMucSubMenu
               // 
               this.panelDanhMucSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
               this.panelDanhMucSubMenu.Controls.Add(this.btnChucVu);
               this.panelDanhMucSubMenu.Controls.Add(this.btnPhongBan);
               this.panelDanhMucSubMenu.Controls.Add(this.btnTrinhDoHocVan);
               this.panelDanhMucSubMenu.Controls.Add(this.btnTonGiao);
               this.panelDanhMucSubMenu.Controls.Add(this.btnDanToc);
               this.panelDanhMucSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
               this.panelDanhMucSubMenu.Location = new System.Drawing.Point(0, 264);
               this.panelDanhMucSubMenu.Name = "panelDanhMucSubMenu";
               this.panelDanhMucSubMenu.Size = new System.Drawing.Size(250, 204);
               this.panelDanhMucSubMenu.TabIndex = 4;
               // 
               // btnChucVu
               // 
               this.btnChucVu.Dock = System.Windows.Forms.DockStyle.Top;
               this.btnChucVu.FlatAppearance.BorderSize = 0;
               this.btnChucVu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
               this.btnChucVu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
               this.btnChucVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnChucVu.ForeColor = System.Drawing.Color.Silver;
               this.btnChucVu.Location = new System.Drawing.Point(0, 160);
               this.btnChucVu.Name = "btnChucVu";
               this.btnChucVu.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
               this.btnChucVu.Size = new System.Drawing.Size(250, 40);
               this.btnChucVu.TabIndex = 4;
               this.btnChucVu.Text = "Chức vụ";
               this.btnChucVu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.btnChucVu.UseVisualStyleBackColor = true;
               this.btnChucVu.Click += new System.EventHandler(this.btnChucVu_Click);
               // 
               // btnPhongBan
               // 
               this.btnPhongBan.Dock = System.Windows.Forms.DockStyle.Top;
               this.btnPhongBan.FlatAppearance.BorderSize = 0;
               this.btnPhongBan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
               this.btnPhongBan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
               this.btnPhongBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnPhongBan.ForeColor = System.Drawing.Color.Silver;
               this.btnPhongBan.Location = new System.Drawing.Point(0, 120);
               this.btnPhongBan.Name = "btnPhongBan";
               this.btnPhongBan.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
               this.btnPhongBan.Size = new System.Drawing.Size(250, 40);
               this.btnPhongBan.TabIndex = 3;
               this.btnPhongBan.Text = "Phòng ban";
               this.btnPhongBan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.btnPhongBan.UseVisualStyleBackColor = true;
               this.btnPhongBan.Click += new System.EventHandler(this.btnPhongBan_Click);
               // 
               // btnTrinhDoHocVan
               // 
               this.btnTrinhDoHocVan.Dock = System.Windows.Forms.DockStyle.Top;
               this.btnTrinhDoHocVan.FlatAppearance.BorderSize = 0;
               this.btnTrinhDoHocVan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
               this.btnTrinhDoHocVan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
               this.btnTrinhDoHocVan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnTrinhDoHocVan.ForeColor = System.Drawing.Color.Silver;
               this.btnTrinhDoHocVan.Location = new System.Drawing.Point(0, 80);
               this.btnTrinhDoHocVan.Name = "btnTrinhDoHocVan";
               this.btnTrinhDoHocVan.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
               this.btnTrinhDoHocVan.Size = new System.Drawing.Size(250, 40);
               this.btnTrinhDoHocVan.TabIndex = 2;
               this.btnTrinhDoHocVan.Text = "Trình độ học vấn";
               this.btnTrinhDoHocVan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.btnTrinhDoHocVan.UseVisualStyleBackColor = true;
               this.btnTrinhDoHocVan.Click += new System.EventHandler(this.btnTrinhDoHocVan_Click);
               // 
               // btnTonGiao
               // 
               this.btnTonGiao.Dock = System.Windows.Forms.DockStyle.Top;
               this.btnTonGiao.FlatAppearance.BorderSize = 0;
               this.btnTonGiao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
               this.btnTonGiao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
               this.btnTonGiao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnTonGiao.ForeColor = System.Drawing.Color.Silver;
               this.btnTonGiao.Location = new System.Drawing.Point(0, 40);
               this.btnTonGiao.Name = "btnTonGiao";
               this.btnTonGiao.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
               this.btnTonGiao.Size = new System.Drawing.Size(250, 40);
               this.btnTonGiao.TabIndex = 1;
               this.btnTonGiao.Text = "Tôn giáo";
               this.btnTonGiao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.btnTonGiao.UseVisualStyleBackColor = true;
               this.btnTonGiao.Click += new System.EventHandler(this.btnTonGiao_Click);
               // 
               // btnDanToc
               // 
               this.btnDanToc.Dock = System.Windows.Forms.DockStyle.Top;
               this.btnDanToc.FlatAppearance.BorderSize = 0;
               this.btnDanToc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
               this.btnDanToc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
               this.btnDanToc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnDanToc.ForeColor = System.Drawing.Color.Silver;
               this.btnDanToc.Location = new System.Drawing.Point(0, 0);
               this.btnDanToc.Name = "btnDanToc";
               this.btnDanToc.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
               this.btnDanToc.Size = new System.Drawing.Size(250, 40);
               this.btnDanToc.TabIndex = 0;
               this.btnDanToc.Text = "Dân tộc";
               this.btnDanToc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.btnDanToc.UseVisualStyleBackColor = true;
               this.btnDanToc.Click += new System.EventHandler(this.btnDanToc_Click);
               // 
               // btnDanhMuc
               // 
               this.btnDanhMuc.Dock = System.Windows.Forms.DockStyle.Top;
               this.btnDanhMuc.FlatAppearance.BorderSize = 0;
               this.btnDanhMuc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
               this.btnDanhMuc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
               this.btnDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnDanhMuc.ForeColor = System.Drawing.Color.Silver;
               this.btnDanhMuc.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhMuc.Image")));
               this.btnDanhMuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.btnDanhMuc.Location = new System.Drawing.Point(0, 219);
               this.btnDanhMuc.Name = "btnDanhMuc";
               this.btnDanhMuc.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
               this.btnDanhMuc.Size = new System.Drawing.Size(250, 45);
               this.btnDanhMuc.TabIndex = 3;
               this.btnDanhMuc.Text = "  Danh mục";
               this.btnDanhMuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.btnDanhMuc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
               this.btnDanhMuc.UseVisualStyleBackColor = true;
               this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);
               // 
               // panelQuanLySubMenu
               // 
               this.panelQuanLySubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
               this.panelQuanLySubMenu.Controls.Add(this.btnTimKiem);
               this.panelQuanLySubMenu.Controls.Add(this.btnThongTinNhanVien);
               this.panelQuanLySubMenu.Dock = System.Windows.Forms.DockStyle.Top;
               this.panelQuanLySubMenu.Location = new System.Drawing.Point(0, 137);
               this.panelQuanLySubMenu.Name = "panelQuanLySubMenu";
               this.panelQuanLySubMenu.Size = new System.Drawing.Size(250, 82);
               this.panelQuanLySubMenu.TabIndex = 2;
               // 
               // btnTimKiem
               // 
               this.btnTimKiem.Dock = System.Windows.Forms.DockStyle.Top;
               this.btnTimKiem.FlatAppearance.BorderSize = 0;
               this.btnTimKiem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
               this.btnTimKiem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
               this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnTimKiem.ForeColor = System.Drawing.Color.Silver;
               this.btnTimKiem.Location = new System.Drawing.Point(0, 40);
               this.btnTimKiem.Name = "btnTimKiem";
               this.btnTimKiem.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
               this.btnTimKiem.Size = new System.Drawing.Size(250, 40);
               this.btnTimKiem.TabIndex = 1;
               this.btnTimKiem.Text = "Tìm kiếm nhân viên";
               this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.btnTimKiem.UseVisualStyleBackColor = true;
               this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
               // 
               // btnThongTinNhanVien
               // 
               this.btnThongTinNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
               this.btnThongTinNhanVien.FlatAppearance.BorderSize = 0;
               this.btnThongTinNhanVien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
               this.btnThongTinNhanVien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
               this.btnThongTinNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnThongTinNhanVien.ForeColor = System.Drawing.Color.Silver;
               this.btnThongTinNhanVien.Location = new System.Drawing.Point(0, 0);
               this.btnThongTinNhanVien.Name = "btnThongTinNhanVien";
               this.btnThongTinNhanVien.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
               this.btnThongTinNhanVien.Size = new System.Drawing.Size(250, 40);
               this.btnThongTinNhanVien.TabIndex = 0;
               this.btnThongTinNhanVien.Text = "Thông tin nhân viên";
               this.btnThongTinNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.btnThongTinNhanVien.UseVisualStyleBackColor = true;
               this.btnThongTinNhanVien.Click += new System.EventHandler(this.btnThongTinNhanVien_Click);
               // 
               // btnQuanLy
               // 
               this.btnQuanLy.Dock = System.Windows.Forms.DockStyle.Top;
               this.btnQuanLy.FlatAppearance.BorderSize = 0;
               this.btnQuanLy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
               this.btnQuanLy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
               this.btnQuanLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnQuanLy.ForeColor = System.Drawing.Color.Silver;
               this.btnQuanLy.Image = ((System.Drawing.Image)(resources.GetObject("btnQuanLy.Image")));
               this.btnQuanLy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.btnQuanLy.Location = new System.Drawing.Point(0, 92);
               this.btnQuanLy.Name = "btnQuanLy";
               this.btnQuanLy.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
               this.btnQuanLy.Size = new System.Drawing.Size(250, 45);
               this.btnQuanLy.TabIndex = 1;
               this.btnQuanLy.Text = "  Quản lý nhân viên";
               this.btnQuanLy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.btnQuanLy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
               this.btnQuanLy.UseVisualStyleBackColor = true;
               this.btnQuanLy.Click += new System.EventHandler(this.btnQuanLy_Click);
               // 
               // panelLogo
               // 
               this.panelLogo.Controls.Add(this.label1);
               this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
               this.panelLogo.Location = new System.Drawing.Point(0, 0);
               this.panelLogo.Name = "panelLogo";
               this.panelLogo.Size = new System.Drawing.Size(250, 92);
               this.panelLogo.TabIndex = 0;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
               this.label1.Location = new System.Drawing.Point(35, 29);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(158, 31);
               this.label1.TabIndex = 0;
               this.label1.Text = "QL Nhân sự";
               // 
               // panelChildForm
               // 
               this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
               this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
               this.panelChildForm.Location = new System.Drawing.Point(250, 0);
               this.panelChildForm.Name = "panelChildForm";
               this.panelChildForm.Size = new System.Drawing.Size(1043, 711);
               this.panelChildForm.TabIndex = 2;
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.SystemColors.Control;
               this.ClientSize = new System.Drawing.Size(1293, 711);
               this.Controls.Add(this.panelChildForm);
               this.Controls.Add(this.panelSideMenu);
               this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.Margin = new System.Windows.Forms.Padding(4);
               this.MinimumSize = new System.Drawing.Size(950, 600);
               this.Name = "Form1";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "QL Nhan Su";
               this.panelSideMenu.ResumeLayout(false);
               this.panelDanhMucSubMenu.ResumeLayout(false);
               this.panelQuanLySubMenu.ResumeLayout(false);
               this.panelLogo.ResumeLayout(false);
               this.panelLogo.PerformLayout();
               this.ResumeLayout(false);
=======
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.panelDanhMucSubMenu = new System.Windows.Forms.Panel();
            this.btnChucVu = new System.Windows.Forms.Button();
            this.btnPhongBan = new System.Windows.Forms.Button();
            this.btnTrinhDoHocVan = new System.Windows.Forms.Button();
            this.btnTonGiao = new System.Windows.Forms.Button();
            this.btnDanToc = new System.Windows.Forms.Button();
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.panelQuanLySubMenu = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThongTinNhanVien = new System.Windows.Forms.Button();
            this.btnQuanLy = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panelDanhMucSubMenu.SuspendLayout();
            this.panelQuanLySubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.btnExit);
            this.panelSideMenu.Controls.Add(this.btnHelp);
            this.panelSideMenu.Controls.Add(this.btnTaiKhoan);
            this.panelSideMenu.Controls.Add(this.panelDanhMucSubMenu);
            this.panelSideMenu.Controls.Add(this.btnDanhMuc);
            this.panelSideMenu.Controls.Add(this.panelQuanLySubMenu);
            this.panelSideMenu.Controls.Add(this.btnQuanLy);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 671);
            this.panelSideMenu.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Silver;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 626);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(250, 45);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "  Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.ForeColor = System.Drawing.Color.Silver;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(0, 513);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnHelp.Size = new System.Drawing.Size(250, 45);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.Text = "    Help";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnTaiKhoan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnTaiKhoan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.Silver;
            this.btnTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiKhoan.Image")));
            this.btnTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.Location = new System.Drawing.Point(0, 468);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnTaiKhoan.Size = new System.Drawing.Size(250, 45);
            this.btnTaiKhoan.TabIndex = 6;
            this.btnTaiKhoan.Text = "  Tài khoản";
            this.btnTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // panelDanhMucSubMenu
            // 
            this.panelDanhMucSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelDanhMucSubMenu.Controls.Add(this.btnChucVu);
            this.panelDanhMucSubMenu.Controls.Add(this.btnPhongBan);
            this.panelDanhMucSubMenu.Controls.Add(this.btnTrinhDoHocVan);
            this.panelDanhMucSubMenu.Controls.Add(this.btnTonGiao);
            this.panelDanhMucSubMenu.Controls.Add(this.btnDanToc);
            this.panelDanhMucSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDanhMucSubMenu.Location = new System.Drawing.Point(0, 264);
            this.panelDanhMucSubMenu.Name = "panelDanhMucSubMenu";
            this.panelDanhMucSubMenu.Size = new System.Drawing.Size(250, 204);
            this.panelDanhMucSubMenu.TabIndex = 4;
            // 
            // btnChucVu
            // 
            this.btnChucVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChucVu.FlatAppearance.BorderSize = 0;
            this.btnChucVu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnChucVu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnChucVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChucVu.ForeColor = System.Drawing.Color.Silver;
            this.btnChucVu.Location = new System.Drawing.Point(0, 160);
            this.btnChucVu.Name = "btnChucVu";
            this.btnChucVu.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnChucVu.Size = new System.Drawing.Size(250, 40);
            this.btnChucVu.TabIndex = 4;
            this.btnChucVu.Text = "Chức vụ";
            this.btnChucVu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChucVu.UseVisualStyleBackColor = true;
            this.btnChucVu.Click += new System.EventHandler(this.btnChucVu_Click);
            // 
            // btnPhongBan
            // 
            this.btnPhongBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPhongBan.FlatAppearance.BorderSize = 0;
            this.btnPhongBan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnPhongBan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnPhongBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhongBan.ForeColor = System.Drawing.Color.Silver;
            this.btnPhongBan.Location = new System.Drawing.Point(0, 120);
            this.btnPhongBan.Name = "btnPhongBan";
            this.btnPhongBan.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPhongBan.Size = new System.Drawing.Size(250, 40);
            this.btnPhongBan.TabIndex = 3;
            this.btnPhongBan.Text = "Phòng ban";
            this.btnPhongBan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhongBan.UseVisualStyleBackColor = true;
            this.btnPhongBan.Click += new System.EventHandler(this.btnPhongBan_Click);
            // 
            // btnTrinhDoHocVan
            // 
            this.btnTrinhDoHocVan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrinhDoHocVan.FlatAppearance.BorderSize = 0;
            this.btnTrinhDoHocVan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnTrinhDoHocVan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnTrinhDoHocVan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrinhDoHocVan.ForeColor = System.Drawing.Color.Silver;
            this.btnTrinhDoHocVan.Location = new System.Drawing.Point(0, 80);
            this.btnTrinhDoHocVan.Name = "btnTrinhDoHocVan";
            this.btnTrinhDoHocVan.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnTrinhDoHocVan.Size = new System.Drawing.Size(250, 40);
            this.btnTrinhDoHocVan.TabIndex = 2;
            this.btnTrinhDoHocVan.Text = "Trình độ học vấn";
            this.btnTrinhDoHocVan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrinhDoHocVan.UseVisualStyleBackColor = true;
            this.btnTrinhDoHocVan.Click += new System.EventHandler(this.btnTrinhDoHocVan_Click);
            // 
            // btnTonGiao
            // 
            this.btnTonGiao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTonGiao.FlatAppearance.BorderSize = 0;
            this.btnTonGiao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnTonGiao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnTonGiao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTonGiao.ForeColor = System.Drawing.Color.Silver;
            this.btnTonGiao.Location = new System.Drawing.Point(0, 40);
            this.btnTonGiao.Name = "btnTonGiao";
            this.btnTonGiao.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnTonGiao.Size = new System.Drawing.Size(250, 40);
            this.btnTonGiao.TabIndex = 1;
            this.btnTonGiao.Text = "Tôn giáo";
            this.btnTonGiao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTonGiao.UseVisualStyleBackColor = true;
            this.btnTonGiao.Click += new System.EventHandler(this.btnTonGiao_Click);
            // 
            // btnDanToc
            // 
            this.btnDanToc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDanToc.FlatAppearance.BorderSize = 0;
            this.btnDanToc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnDanToc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnDanToc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanToc.ForeColor = System.Drawing.Color.Silver;
            this.btnDanToc.Location = new System.Drawing.Point(0, 0);
            this.btnDanToc.Name = "btnDanToc";
            this.btnDanToc.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDanToc.Size = new System.Drawing.Size(250, 40);
            this.btnDanToc.TabIndex = 0;
            this.btnDanToc.Text = "Dân tộc";
            this.btnDanToc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanToc.UseVisualStyleBackColor = true;
            this.btnDanToc.Click += new System.EventHandler(this.btnDanToc_Click);
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDanhMuc.FlatAppearance.BorderSize = 0;
            this.btnDanhMuc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnDanhMuc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhMuc.ForeColor = System.Drawing.Color.Silver;
            this.btnDanhMuc.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhMuc.Image")));
            this.btnDanhMuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhMuc.Location = new System.Drawing.Point(0, 219);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDanhMuc.Size = new System.Drawing.Size(250, 45);
            this.btnDanhMuc.TabIndex = 3;
            this.btnDanhMuc.Text = "  Danh mục";
            this.btnDanhMuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhMuc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDanhMuc.UseVisualStyleBackColor = true;
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);
            // 
            // panelQuanLySubMenu
            // 
            this.panelQuanLySubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelQuanLySubMenu.Controls.Add(this.btnTimKiem);
            this.panelQuanLySubMenu.Controls.Add(this.btnThongTinNhanVien);
            this.panelQuanLySubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuanLySubMenu.Location = new System.Drawing.Point(0, 137);
            this.panelQuanLySubMenu.Name = "panelQuanLySubMenu";
            this.panelQuanLySubMenu.Size = new System.Drawing.Size(250, 82);
            this.panelQuanLySubMenu.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnTimKiem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.ForeColor = System.Drawing.Color.Silver;
            this.btnTimKiem.Location = new System.Drawing.Point(0, 40);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnTimKiem.Size = new System.Drawing.Size(250, 40);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm nhân viên";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThongTinNhanVien
            // 
            this.btnThongTinNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongTinNhanVien.FlatAppearance.BorderSize = 0;
            this.btnThongTinNhanVien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnThongTinNhanVien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnThongTinNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongTinNhanVien.ForeColor = System.Drawing.Color.Silver;
            this.btnThongTinNhanVien.Location = new System.Drawing.Point(0, 0);
            this.btnThongTinNhanVien.Name = "btnThongTinNhanVien";
            this.btnThongTinNhanVien.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnThongTinNhanVien.Size = new System.Drawing.Size(250, 40);
            this.btnThongTinNhanVien.TabIndex = 0;
            this.btnThongTinNhanVien.Text = "Thông tin nhân viên";
            this.btnThongTinNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongTinNhanVien.UseVisualStyleBackColor = true;
            this.btnThongTinNhanVien.Click += new System.EventHandler(this.btnThongTinNhanVien_Click);
            // 
            // btnQuanLy
            // 
            this.btnQuanLy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLy.FlatAppearance.BorderSize = 0;
            this.btnQuanLy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnQuanLy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnQuanLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLy.ForeColor = System.Drawing.Color.Silver;
            this.btnQuanLy.Image = ((System.Drawing.Image)(resources.GetObject("btnQuanLy.Image")));
            this.btnQuanLy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLy.Location = new System.Drawing.Point(0, 92);
            this.btnQuanLy.Name = "btnQuanLy";
            this.btnQuanLy.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnQuanLy.Size = new System.Drawing.Size(250, 45);
            this.btnQuanLy.TabIndex = 1;
            this.btnQuanLy.Text = "  Quản lý nhân viên";
            this.btnQuanLy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLy.UseVisualStyleBackColor = true;
            this.btnQuanLy.Click += new System.EventHandler(this.btnQuanLy_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 92);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "QL Nhân sự";
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1112, 671);
            this.panelChildForm.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1362, 671);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QL Nhan Su";
            this.panelSideMenu.ResumeLayout(false);
            this.panelDanhMucSubMenu.ResumeLayout(false);
            this.panelQuanLySubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);
>>>>>>> XuanTung

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelQuanLySubMenu;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThongTinNhanVien;
        private System.Windows.Forms.Button btnQuanLy;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Panel panelDanhMucSubMenu;
        private System.Windows.Forms.Button btnPhongBan;
        private System.Windows.Forms.Button btnTrinhDoHocVan;
        private System.Windows.Forms.Button btnTonGiao;
        private System.Windows.Forms.Button btnDanToc;
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChucVu;
    }
}

