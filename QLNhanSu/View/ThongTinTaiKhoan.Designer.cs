namespace View
{
    partial class ThongTinTaiKhoan
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label viTriLabel;
            System.Windows.Forms.Label tonGiaoLabel;
            System.Windows.Forms.Label sDTLabel;
            System.Windows.Forms.Label phongBanLabel;
            System.Windows.Forms.Label ngaySinhLabel;
            System.Windows.Forms.Label luongLabel;
            System.Windows.Forms.Label hoTenLabel;
            System.Windows.Forms.Label diaChiLabel;
            System.Windows.Forms.Label danTocLabel;
            System.Windows.Forms.Label chucVuLabel;
            System.Windows.Forms.Label cMTNDLabel;
            System.Windows.Forms.Label gioiTinhLabel;
            System.Windows.Forms.Label bangCapLabel;
            this.chinhSua_btn = new System.Windows.Forms.Button();
            this.doiMatKhau_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.viTriTextBox = new System.Windows.Forms.TextBox();
            this.tonGiaoTextBox = new System.Windows.Forms.TextBox();
            this.sDTTextBox = new System.Windows.Forms.TextBox();
            this.phongBanTextBox = new System.Windows.Forms.TextBox();
            this.ngaySinhDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.luongTextBox = new System.Windows.Forms.TextBox();
            this.hoTenTextBox = new System.Windows.Forms.TextBox();
            this.diaChiTextBox = new System.Windows.Forms.TextBox();
            this.danTocTextBox = new System.Windows.Forms.TextBox();
            this.chucVuTextBox = new System.Windows.Forms.TextBox();
            this.cMTNDTextBox = new System.Windows.Forms.TextBox();
            this.gioiTinhRadioButton = new System.Windows.Forms.RadioButton();
            this.NuRadio_btn = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.hoTenLabel2 = new System.Windows.Forms.Label();
            this.thongTinTaiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bangCapTextBox = new System.Windows.Forms.TextBox();
            viTriLabel = new System.Windows.Forms.Label();
            tonGiaoLabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            phongBanLabel = new System.Windows.Forms.Label();
            ngaySinhLabel = new System.Windows.Forms.Label();
            luongLabel = new System.Windows.Forms.Label();
            hoTenLabel = new System.Windows.Forms.Label();
            diaChiLabel = new System.Windows.Forms.Label();
            danTocLabel = new System.Windows.Forms.Label();
            chucVuLabel = new System.Windows.Forms.Label();
            cMTNDLabel = new System.Windows.Forms.Label();
            gioiTinhLabel = new System.Windows.Forms.Label();
            bangCapLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinTaiKhoanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chinhSua_btn
            // 
            this.chinhSua_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chinhSua_btn.Location = new System.Drawing.Point(43, 81);
            this.chinhSua_btn.Name = "chinhSua_btn";
            this.chinhSua_btn.Size = new System.Drawing.Size(145, 84);
            this.chinhSua_btn.TabIndex = 0;
            this.chinhSua_btn.Text = "CHỈNH SỬA";
            this.chinhSua_btn.UseVisualStyleBackColor = true;
            // 
            // doiMatKhau_btn
            // 
            this.doiMatKhau_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doiMatKhau_btn.Location = new System.Drawing.Point(43, 216);
            this.doiMatKhau_btn.Name = "doiMatKhau_btn";
            this.doiMatKhau_btn.Size = new System.Drawing.Size(145, 84);
            this.doiMatKhau_btn.TabIndex = 1;
            this.doiMatKhau_btn.Text = "ĐỔI MẬT KHẨU";
            this.doiMatKhau_btn.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.doiMatKhau_btn);
            this.panel2.Controls.Add(this.chinhSua_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1111, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 800);
            this.panel2.TabIndex = 1;
            // 
            // viTriTextBox
            // 
            this.viTriTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thongTinTaiKhoanBindingSource, "ViTri", true));
            this.viTriTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viTriTextBox.Location = new System.Drawing.Point(177, 535);
            this.viTriTextBox.Name = "viTriTextBox";
            this.viTriTextBox.Size = new System.Drawing.Size(335, 30);
            this.viTriTextBox.TabIndex = 23;
            // 
            // viTriLabel
            // 
            viTriLabel.AutoSize = true;
            viTriLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            viTriLabel.Location = new System.Drawing.Point(39, 538);
            viTriLabel.Name = "viTriLabel";
            viTriLabel.Size = new System.Drawing.Size(56, 25);
            viTriLabel.TabIndex = 22;
            viTriLabel.Text = "Vị trí:";
            // 
            // tonGiaoTextBox
            // 
            this.tonGiaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thongTinTaiKhoanBindingSource, "TonGiao", true));
            this.tonGiaoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tonGiaoTextBox.Location = new System.Drawing.Point(710, 286);
            this.tonGiaoTextBox.Name = "tonGiaoTextBox";
            this.tonGiaoTextBox.Size = new System.Drawing.Size(335, 30);
            this.tonGiaoTextBox.TabIndex = 21;
            // 
            // tonGiaoLabel
            // 
            tonGiaoLabel.AutoSize = true;
            tonGiaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tonGiaoLabel.Location = new System.Drawing.Point(581, 289);
            tonGiaoLabel.Name = "tonGiaoLabel";
            tonGiaoLabel.Size = new System.Drawing.Size(95, 25);
            tonGiaoLabel.TabIndex = 20;
            tonGiaoLabel.Text = "Tôn giáo:";
            // 
            // sDTTextBox
            // 
            this.sDTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thongTinTaiKhoanBindingSource, "SDT", true));
            this.sDTTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sDTTextBox.Location = new System.Drawing.Point(177, 452);
            this.sDTTextBox.Name = "sDTTextBox";
            this.sDTTextBox.Size = new System.Drawing.Size(335, 30);
            this.sDTTextBox.TabIndex = 19;
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sDTLabel.Location = new System.Drawing.Point(39, 455);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(132, 25);
            sDTLabel.TabIndex = 18;
            sDTLabel.Text = "Số điện thoại:";
            // 
            // phongBanTextBox
            // 
            this.phongBanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thongTinTaiKhoanBindingSource, "PhongBan", true));
            this.phongBanTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phongBanTextBox.Location = new System.Drawing.Point(177, 618);
            this.phongBanTextBox.Name = "phongBanTextBox";
            this.phongBanTextBox.Size = new System.Drawing.Size(335, 30);
            this.phongBanTextBox.TabIndex = 17;
            // 
            // phongBanLabel
            // 
            phongBanLabel.AutoSize = true;
            phongBanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phongBanLabel.Location = new System.Drawing.Point(39, 621);
            phongBanLabel.Name = "phongBanLabel";
            phongBanLabel.Size = new System.Drawing.Size(113, 25);
            phongBanLabel.TabIndex = 16;
            phongBanLabel.Text = "Phòng ban:";
            // 
            // ngaySinhDateTimePicker
            // 
            this.ngaySinhDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.thongTinTaiKhoanBindingSource, "NgaySinh", true));
            this.ngaySinhDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaySinhDateTimePicker.Location = new System.Drawing.Point(177, 203);
            this.ngaySinhDateTimePicker.Name = "ngaySinhDateTimePicker";
            this.ngaySinhDateTimePicker.Size = new System.Drawing.Size(335, 30);
            this.ngaySinhDateTimePicker.TabIndex = 15;
            // 
            // ngaySinhLabel
            // 
            ngaySinhLabel.AutoSize = true;
            ngaySinhLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngaySinhLabel.Location = new System.Drawing.Point(39, 206);
            ngaySinhLabel.Name = "ngaySinhLabel";
            ngaySinhLabel.Size = new System.Drawing.Size(105, 25);
            ngaySinhLabel.TabIndex = 14;
            ngaySinhLabel.Text = "Ngày sinh:";
            // 
            // luongTextBox
            // 
            this.luongTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thongTinTaiKhoanBindingSource, "Luong", true));
            this.luongTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luongTextBox.Location = new System.Drawing.Point(710, 618);
            this.luongTextBox.Name = "luongTextBox";
            this.luongTextBox.Size = new System.Drawing.Size(335, 30);
            this.luongTextBox.TabIndex = 13;
            // 
            // luongLabel
            // 
            luongLabel.AutoSize = true;
            luongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            luongLabel.Location = new System.Drawing.Point(581, 621);
            luongLabel.Name = "luongLabel";
            luongLabel.Size = new System.Drawing.Size(73, 25);
            luongLabel.TabIndex = 12;
            luongLabel.Text = "Lương:";
            // 
            // hoTenTextBox
            // 
            this.hoTenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thongTinTaiKhoanBindingSource, "HoTen", true));
            this.hoTenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoTenTextBox.Location = new System.Drawing.Point(177, 120);
            this.hoTenTextBox.Name = "hoTenTextBox";
            this.hoTenTextBox.Size = new System.Drawing.Size(335, 30);
            this.hoTenTextBox.TabIndex = 11;
            // 
            // hoTenLabel
            // 
            hoTenLabel.AutoSize = true;
            hoTenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hoTenLabel.Location = new System.Drawing.Point(39, 123);
            hoTenLabel.Name = "hoTenLabel";
            hoTenLabel.Size = new System.Drawing.Size(101, 25);
            hoTenLabel.TabIndex = 10;
            hoTenLabel.Text = "Họ và tên:";
            // 
            // diaChiTextBox
            // 
            this.diaChiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thongTinTaiKhoanBindingSource, "DiaChi", true));
            this.diaChiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diaChiTextBox.Location = new System.Drawing.Point(177, 369);
            this.diaChiTextBox.Name = "diaChiTextBox";
            this.diaChiTextBox.Size = new System.Drawing.Size(868, 30);
            this.diaChiTextBox.TabIndex = 7;
            // 
            // diaChiLabel
            // 
            diaChiLabel.AutoSize = true;
            diaChiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            diaChiLabel.Location = new System.Drawing.Point(39, 372);
            diaChiLabel.Name = "diaChiLabel";
            diaChiLabel.Size = new System.Drawing.Size(77, 25);
            diaChiLabel.TabIndex = 6;
            diaChiLabel.Text = "Địa chỉ:";
            // 
            // danTocTextBox
            // 
            this.danTocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thongTinTaiKhoanBindingSource, "DanToc", true));
            this.danTocTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danTocTextBox.Location = new System.Drawing.Point(177, 286);
            this.danTocTextBox.Name = "danTocTextBox";
            this.danTocTextBox.Size = new System.Drawing.Size(335, 30);
            this.danTocTextBox.TabIndex = 5;
            // 
            // danTocLabel
            // 
            danTocLabel.AutoSize = true;
            danTocLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            danTocLabel.Location = new System.Drawing.Point(39, 289);
            danTocLabel.Name = "danTocLabel";
            danTocLabel.Size = new System.Drawing.Size(85, 25);
            danTocLabel.TabIndex = 4;
            danTocLabel.Text = "Dân tộc:";
            // 
            // chucVuTextBox
            // 
            this.chucVuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thongTinTaiKhoanBindingSource, "ChucVu", true));
            this.chucVuTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chucVuTextBox.Location = new System.Drawing.Point(710, 535);
            this.chucVuTextBox.Name = "chucVuTextBox";
            this.chucVuTextBox.Size = new System.Drawing.Size(335, 30);
            this.chucVuTextBox.TabIndex = 3;
            // 
            // chucVuLabel
            // 
            chucVuLabel.AutoSize = true;
            chucVuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chucVuLabel.Location = new System.Drawing.Point(581, 538);
            chucVuLabel.Name = "chucVuLabel";
            chucVuLabel.Size = new System.Drawing.Size(91, 25);
            chucVuLabel.TabIndex = 2;
            chucVuLabel.Text = "Chức vụ:";
            // 
            // cMTNDTextBox
            // 
            this.cMTNDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thongTinTaiKhoanBindingSource, "CMTND", true));
            this.cMTNDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cMTNDTextBox.Location = new System.Drawing.Point(710, 205);
            this.cMTNDTextBox.Name = "cMTNDTextBox";
            this.cMTNDTextBox.Size = new System.Drawing.Size(335, 30);
            this.cMTNDTextBox.TabIndex = 1;
            // 
            // cMTNDLabel
            // 
            cMTNDLabel.AutoSize = true;
            cMTNDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cMTNDLabel.Location = new System.Drawing.Point(581, 206);
            cMTNDLabel.Name = "cMTNDLabel";
            cMTNDLabel.Size = new System.Drawing.Size(91, 25);
            cMTNDLabel.TabIndex = 0;
            cMTNDLabel.Text = "CMTND:";
            // 
            // gioiTinhRadioButton
            // 
            this.gioiTinhRadioButton.Checked = true;
            this.gioiTinhRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.thongTinTaiKhoanBindingSource, "GioiTinh", true));
            this.gioiTinhRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gioiTinhRadioButton.Location = new System.Drawing.Point(710, 123);
            this.gioiTinhRadioButton.Name = "gioiTinhRadioButton";
            this.gioiTinhRadioButton.Size = new System.Drawing.Size(88, 24);
            this.gioiTinhRadioButton.TabIndex = 24;
            this.gioiTinhRadioButton.TabStop = true;
            this.gioiTinhRadioButton.Text = "Nam";
            this.gioiTinhRadioButton.UseVisualStyleBackColor = true;
            // 
            // gioiTinhLabel
            // 
            gioiTinhLabel.AutoSize = true;
            gioiTinhLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gioiTinhLabel.Location = new System.Drawing.Point(577, 123);
            gioiTinhLabel.Name = "gioiTinhLabel";
            gioiTinhLabel.Size = new System.Drawing.Size(88, 25);
            gioiTinhLabel.TabIndex = 23;
            gioiTinhLabel.Text = "Giới tính:";
            // 
            // NuRadio_btn
            // 
            this.NuRadio_btn.AutoSize = true;
            this.NuRadio_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuRadio_btn.Location = new System.Drawing.Point(804, 121);
            this.NuRadio_btn.Name = "NuRadio_btn";
            this.NuRadio_btn.Size = new System.Drawing.Size(58, 29);
            this.NuRadio_btn.TabIndex = 25;
            this.NuRadio_btn.Text = "Nữ";
            this.NuRadio_btn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(bangCapLabel);
            this.panel1.Controls.Add(this.bangCapTextBox);
            this.panel1.Controls.Add(this.hoTenLabel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NuRadio_btn);
            this.panel1.Controls.Add(gioiTinhLabel);
            this.panel1.Controls.Add(this.gioiTinhRadioButton);
            this.panel1.Controls.Add(cMTNDLabel);
            this.panel1.Controls.Add(this.cMTNDTextBox);
            this.panel1.Controls.Add(chucVuLabel);
            this.panel1.Controls.Add(this.chucVuTextBox);
            this.panel1.Controls.Add(danTocLabel);
            this.panel1.Controls.Add(this.danTocTextBox);
            this.panel1.Controls.Add(diaChiLabel);
            this.panel1.Controls.Add(this.diaChiTextBox);
            this.panel1.Controls.Add(hoTenLabel);
            this.panel1.Controls.Add(this.hoTenTextBox);
            this.panel1.Controls.Add(luongLabel);
            this.panel1.Controls.Add(this.luongTextBox);
            this.panel1.Controls.Add(ngaySinhLabel);
            this.panel1.Controls.Add(this.ngaySinhDateTimePicker);
            this.panel1.Controls.Add(phongBanLabel);
            this.panel1.Controls.Add(this.phongBanTextBox);
            this.panel1.Controls.Add(sDTLabel);
            this.panel1.Controls.Add(this.sDTTextBox);
            this.panel1.Controls.Add(tonGiaoLabel);
            this.panel1.Controls.Add(this.tonGiaoTextBox);
            this.panel1.Controls.Add(viTriLabel);
            this.panel1.Controls.Add(this.viTriTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1111, 800);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F);
            this.label1.Location = new System.Drawing.Point(37, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 39);
            this.label1.TabIndex = 26;
            this.label1.Text = "Thông tin nhân viên:";
            // 
            // hoTenLabel2
            // 
            this.hoTenLabel2.AutoSize = true;
            this.hoTenLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thongTinTaiKhoanBindingSource, "HoTen", true));
            this.hoTenLabel2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F);
            this.hoTenLabel2.Location = new System.Drawing.Point(396, 38);
            this.hoTenLabel2.Name = "hoTenLabel2";
            this.hoTenLabel2.Size = new System.Drawing.Size(116, 39);
            this.hoTenLabel2.TabIndex = 27;
            this.hoTenLabel2.Text = "label2";
            // 
            // thongTinTaiKhoanBindingSource
            // 
            this.thongTinTaiKhoanBindingSource.DataSource = typeof(DTO.ThongTinTaiKhoan);
            // 
            // bangCapLabel
            // 
            bangCapLabel.AutoSize = true;
            bangCapLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            bangCapLabel.Location = new System.Drawing.Point(581, 455);
            bangCapLabel.Name = "bangCapLabel";
            bangCapLabel.Size = new System.Drawing.Size(101, 25);
            bangCapLabel.TabIndex = 27;
            bangCapLabel.Text = "Bằng cấp:";
            // 
            // bangCapTextBox
            // 
            this.bangCapTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thongTinTaiKhoanBindingSource, "BangCap", true));
            this.bangCapTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bangCapTextBox.Location = new System.Drawing.Point(710, 452);
            this.bangCapTextBox.Name = "bangCapTextBox";
            this.bangCapTextBox.Size = new System.Drawing.Size(335, 30);
            this.bangCapTextBox.TabIndex = 28;
            // 
            // ThongTinTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 800);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ThongTinTaiKhoan";
            this.Text = "ThongTinTaiKhoan";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinTaiKhoanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource thongTinTaiKhoanBindingSource;
        private System.Windows.Forms.Button chinhSua_btn;
        private System.Windows.Forms.Button doiMatKhau_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox viTriTextBox;
        private System.Windows.Forms.TextBox tonGiaoTextBox;
        private System.Windows.Forms.TextBox sDTTextBox;
        private System.Windows.Forms.TextBox phongBanTextBox;
        private System.Windows.Forms.DateTimePicker ngaySinhDateTimePicker;
        private System.Windows.Forms.TextBox luongTextBox;
        private System.Windows.Forms.TextBox hoTenTextBox;
        private System.Windows.Forms.TextBox diaChiTextBox;
        private System.Windows.Forms.TextBox danTocTextBox;
        private System.Windows.Forms.TextBox chucVuTextBox;
        private System.Windows.Forms.TextBox cMTNDTextBox;
        private System.Windows.Forms.RadioButton gioiTinhRadioButton;
        private System.Windows.Forms.RadioButton NuRadio_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label hoTenLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bangCapTextBox;
    }
}