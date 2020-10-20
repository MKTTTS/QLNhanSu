namespace View
{
    partial class Hopdong
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
            this.maskedTextBoxNgaysinh = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxGioitinh = new System.Windows.Forms.ComboBox();
            this.textBoxHoTen = new System.Windows.Forms.TextBox();
            this.textBoxMaNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.maskedTextBoxNgayky = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBoxNgayhethan = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxHopDong = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maskedTextBoxNgaysinh
            // 
            this.maskedTextBoxNgaysinh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxNgaysinh.ForeColor = System.Drawing.SystemColors.Desktop;
            this.maskedTextBoxNgaysinh.Location = new System.Drawing.Point(321, 232);
            this.maskedTextBoxNgaysinh.Mask = "00/00/0000";
            this.maskedTextBoxNgaysinh.Name = "maskedTextBoxNgaysinh";
            this.maskedTextBoxNgaysinh.Size = new System.Drawing.Size(344, 30);
            this.maskedTextBoxNgaysinh.TabIndex = 72;
            this.maskedTextBoxNgaysinh.ValidatingType = typeof(System.DateTime);
            // 
            // comboBoxGioitinh
            // 
            this.comboBoxGioitinh.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxGioitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGioitinh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGioitinh.ForeColor = System.Drawing.SystemColors.Highlight;
            this.comboBoxGioitinh.FormattingEnabled = true;
            this.comboBoxGioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboBoxGioitinh.Location = new System.Drawing.Point(321, 132);
            this.comboBoxGioitinh.Name = "comboBoxGioitinh";
            this.comboBoxGioitinh.Size = new System.Drawing.Size(114, 32);
            this.comboBoxGioitinh.TabIndex = 71;
            // 
            // textBoxHoTen
            // 
            this.textBoxHoTen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHoTen.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBoxHoTen.Location = new System.Drawing.Point(321, 183);
            this.textBoxHoTen.Name = "textBoxHoTen";
            this.textBoxHoTen.Size = new System.Drawing.Size(344, 30);
            this.textBoxHoTen.TabIndex = 70;
            // 
            // textBoxMaNV
            // 
            this.textBoxMaNV.Enabled = false;
            this.textBoxMaNV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaNV.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBoxMaNV.Location = new System.Drawing.Point(321, 83);
            this.textBoxMaNV.Name = "textBoxMaNV";
            this.textBoxMaNV.Size = new System.Drawing.Size(344, 30);
            this.textBoxMaNV.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(126, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 68;
            this.label4.Text = "NGÀY SINH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(126, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 67;
            this.label3.Text = "GIỚI TÍNH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(126, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 66;
            this.label2.Text = "HỌ TÊN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(126, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 19);
            this.label1.TabIndex = 65;
            this.label1.Text = "MÃ NHÂN VIÊN";
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.Color.DarkRed;
            this.buttonXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonXoa.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonXoa.Location = new System.Drawing.Point(553, 414);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(208, 105);
            this.buttonXoa.TabIndex = 81;
            this.buttonXoa.Text = "THOÁT";
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.BackColor = System.Drawing.Color.DarkRed;
            this.buttonSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSua.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSua.Location = new System.Drawing.Point(175, 414);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(208, 105);
            this.buttonSua.TabIndex = 79;
            this.buttonSua.Text = "THAY ĐỔI";
            this.buttonSua.UseVisualStyleBackColor = false;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // maskedTextBoxNgayky
            // 
            this.maskedTextBoxNgayky.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxNgayky.ForeColor = System.Drawing.SystemColors.Desktop;
            this.maskedTextBoxNgayky.Location = new System.Drawing.Point(321, 281);
            this.maskedTextBoxNgayky.Mask = "00/00/0000";
            this.maskedTextBoxNgayky.Name = "maskedTextBoxNgayky";
            this.maskedTextBoxNgayky.Size = new System.Drawing.Size(344, 30);
            this.maskedTextBoxNgayky.TabIndex = 83;
            this.maskedTextBoxNgayky.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(126, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 19);
            this.label6.TabIndex = 82;
            this.label6.Text = "NGÀY KÝ HỢP ĐỒNG";
            // 
            // maskedTextBoxNgayhethan
            // 
            this.maskedTextBoxNgayhethan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxNgayhethan.ForeColor = System.Drawing.SystemColors.Desktop;
            this.maskedTextBoxNgayhethan.Location = new System.Drawing.Point(321, 330);
            this.maskedTextBoxNgayhethan.Mask = "00/00/0000";
            this.maskedTextBoxNgayhethan.Name = "maskedTextBoxNgayhethan";
            this.maskedTextBoxNgayhethan.Size = new System.Drawing.Size(344, 30);
            this.maskedTextBoxNgayhethan.TabIndex = 85;
            this.maskedTextBoxNgayhethan.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(126, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 19);
            this.label7.TabIndex = 84;
            this.label7.Text = "NGÀY HẾT HẠN";
            // 
            // comboBoxHopDong
            // 
            this.comboBoxHopDong.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxHopDong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHopDong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxHopDong.ForeColor = System.Drawing.SystemColors.Highlight;
            this.comboBoxHopDong.FormattingEnabled = true;
            this.comboBoxHopDong.Items.AddRange(new object[] {
            "Không thời hạn",
            "Có thời hạn"});
            this.comboBoxHopDong.Location = new System.Drawing.Point(321, 32);
            this.comboBoxHopDong.Name = "comboBoxHopDong";
            this.comboBoxHopDong.Size = new System.Drawing.Size(344, 32);
            this.comboBoxHopDong.TabIndex = 87;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(126, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 19);
            this.label5.TabIndex = 86;
            this.label5.Text = "HỢP ĐỒNG";
            // 
            // Hopdong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(965, 586);
            this.Controls.Add(this.comboBoxHopDong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTextBoxNgayhethan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maskedTextBoxNgayky);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.maskedTextBoxNgaysinh);
            this.Controls.Add(this.comboBoxGioitinh);
            this.Controls.Add(this.textBoxHoTen);
            this.Controls.Add(this.textBoxMaNV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Hopdong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin hợp đồng";
            this.Load += new System.EventHandler(this.Hopdong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBoxNgaysinh;
        private System.Windows.Forms.ComboBox comboBoxGioitinh;
        private System.Windows.Forms.TextBox textBoxHoTen;
        private System.Windows.Forms.TextBox textBoxMaNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNgayky;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNgayhethan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxHopDong;
        private System.Windows.Forms.Label label5;
    }
}