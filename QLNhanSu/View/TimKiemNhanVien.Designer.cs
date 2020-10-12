namespace View
{
    partial class TimKiemNhanVien
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
               this.dgvKetQua = new System.Windows.Forms.DataGridView();
               this.label1 = new System.Windows.Forms.Label();
               this.cbxTieuChi = new System.Windows.Forms.ComboBox();
               this.btnTKTieuChi = new System.Windows.Forms.Button();
               this.label2 = new System.Windows.Forms.Label();
               this.groupBox1 = new System.Windows.Forms.GroupBox();
               this.groupBox2 = new System.Windows.Forms.GroupBox();
               this.txtTen = new System.Windows.Forms.TextBox();
               this.btnTKTenMaNV = new System.Windows.Forms.Button();
               this.cbxDeMuc = new System.Windows.Forms.ComboBox();
               this.textBox1 = new System.Windows.Forms.TextBox();
               this.cbHoTen = new System.Windows.Forms.CheckBox();
               this.cbMaNV = new System.Windows.Forms.CheckBox();
               ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
               this.groupBox1.SuspendLayout();
               this.groupBox2.SuspendLayout();
               this.SuspendLayout();
               // 
               // dgvKetQua
               // 
               this.dgvKetQua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               this.dgvKetQua.BackgroundColor = System.Drawing.SystemColors.Control;
               this.dgvKetQua.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
               this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dgvKetQua.Location = new System.Drawing.Point(12, 162);
               this.dgvKetQua.Name = "dgvKetQua";
               this.dgvKetQua.Size = new System.Drawing.Size(757, 325);
               this.dgvKetQua.TabIndex = 0;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(47, 32);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(48, 13);
               this.label1.TabIndex = 1;
               this.label1.Text = "Tiêu Chí";
               // 
               // cbxTieuChi
               // 
               this.cbxTieuChi.FormattingEnabled = true;
               this.cbxTieuChi.Items.AddRange(new object[] {
            "Chức Vụ",
            "Bằng Cấp",
            "Phòng Ban",
            "Địa Chỉ"});
               this.cbxTieuChi.Location = new System.Drawing.Point(101, 32);
               this.cbxTieuChi.Name = "cbxTieuChi";
               this.cbxTieuChi.Size = new System.Drawing.Size(109, 21);
               this.cbxTieuChi.TabIndex = 2;
               this.cbxTieuChi.TextChanged += new System.EventHandler(this.cbxTieuChi_TextChanged);
               // 
               // btnTKTieuChi
               // 
               this.btnTKTieuChi.Location = new System.Drawing.Point(253, 51);
               this.btnTKTieuChi.Name = "btnTKTieuChi";
               this.btnTKTieuChi.Size = new System.Drawing.Size(75, 23);
               this.btnTKTieuChi.TabIndex = 5;
               this.btnTKTieuChi.Text = "Tìm Kiếm";
               this.btnTKTieuChi.UseVisualStyleBackColor = true;
               this.btnTKTieuChi.Click += new System.EventHandler(this.btnTimKiemTieuChi_Click);
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(50, 74);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(45, 13);
               this.label2.TabIndex = 7;
               this.label2.Text = "Đề Mục";
               // 
               // groupBox1
               // 
               this.groupBox1.Controls.Add(this.cbxTieuChi);
               this.groupBox1.Controls.Add(this.cbxDeMuc);
               this.groupBox1.Controls.Add(this.label1);
               this.groupBox1.Controls.Add(this.label2);
               this.groupBox1.Controls.Add(this.btnTKTieuChi);
               this.groupBox1.Location = new System.Drawing.Point(12, 12);
               this.groupBox1.Name = "groupBox1";
               this.groupBox1.Size = new System.Drawing.Size(366, 131);
               this.groupBox1.TabIndex = 9;
               this.groupBox1.TabStop = false;
               this.groupBox1.Text = "Theo Các Tiêu Chí";
               // 
               // groupBox2
               // 
               this.groupBox2.Controls.Add(this.cbMaNV);
               this.groupBox2.Controls.Add(this.cbHoTen);
               this.groupBox2.Controls.Add(this.textBox1);
               this.groupBox2.Controls.Add(this.txtTen);
               this.groupBox2.Controls.Add(this.btnTKTenMaNV);
               this.groupBox2.Location = new System.Drawing.Point(415, 12);
               this.groupBox2.Name = "groupBox2";
               this.groupBox2.Size = new System.Drawing.Size(354, 131);
               this.groupBox2.TabIndex = 10;
               this.groupBox2.TabStop = false;
               this.groupBox2.Text = "Theo Tên";
               // 
               // txtTen
               // 
               this.txtTen.Enabled = false;
               this.txtTen.Location = new System.Drawing.Point(85, 37);
               this.txtTen.Multiline = true;
               this.txtTen.Name = "txtTen";
               this.txtTen.Size = new System.Drawing.Size(162, 20);
               this.txtTen.TabIndex = 7;
               // 
               // btnTKTenMaNV
               // 
               this.btnTKTenMaNV.Location = new System.Drawing.Point(264, 51);
               this.btnTKTenMaNV.Name = "btnTKTenMaNV";
               this.btnTKTenMaNV.Size = new System.Drawing.Size(75, 23);
               this.btnTKTenMaNV.TabIndex = 5;
               this.btnTKTenMaNV.Text = "Tìm Kiếm";
               this.btnTKTenMaNV.UseVisualStyleBackColor = true;
               // 
               // cbxDeMuc
               // 
               this.cbxDeMuc.FormattingEnabled = true;
               this.cbxDeMuc.IntegralHeight = false;
               this.cbxDeMuc.Location = new System.Drawing.Point(101, 71);
               this.cbxDeMuc.Name = "cbxDeMuc";
               this.cbxDeMuc.Size = new System.Drawing.Size(109, 21);
               this.cbxDeMuc.TabIndex = 8;
               // 
               // textBox1
               // 
               this.textBox1.Enabled = false;
               this.textBox1.Location = new System.Drawing.Point(117, 71);
               this.textBox1.Multiline = true;
               this.textBox1.Name = "textBox1";
               this.textBox1.Size = new System.Drawing.Size(130, 21);
               this.textBox1.TabIndex = 9;
               // 
               // cbHoTen
               // 
               this.cbHoTen.AutoSize = true;
               this.cbHoTen.Location = new System.Drawing.Point(17, 40);
               this.cbHoTen.Name = "cbHoTen";
               this.cbHoTen.Size = new System.Drawing.Size(62, 17);
               this.cbHoTen.TabIndex = 10;
               this.cbHoTen.Text = "Họ Tên";
               this.cbHoTen.UseVisualStyleBackColor = true;
               // 
               // cbMaNV
               // 
               this.cbMaNV.AutoSize = true;
               this.cbMaNV.Location = new System.Drawing.Point(17, 73);
               this.cbMaNV.Name = "cbMaNV";
               this.cbMaNV.Size = new System.Drawing.Size(94, 17);
               this.cbMaNV.TabIndex = 11;
               this.cbMaNV.Text = "Mã Nhân Viên";
               this.cbMaNV.UseVisualStyleBackColor = true;
               // 
               // TimKiemNhanVien
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(781, 499);
               this.Controls.Add(this.groupBox2);
               this.Controls.Add(this.groupBox1);
               this.Controls.Add(this.dgvKetQua);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
               this.Name = "TimKiemNhanVien";
               this.Text = "TimKiemNhanVien";
               ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
               this.groupBox1.ResumeLayout(false);
               this.groupBox1.PerformLayout();
               this.groupBox2.ResumeLayout(false);
               this.groupBox2.PerformLayout();
               this.ResumeLayout(false);

        }

          #endregion

          private System.Windows.Forms.DataGridView dgvKetQua;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.ComboBox cbxTieuChi;
          private System.Windows.Forms.Button btnTKTieuChi;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.GroupBox groupBox1;
          private System.Windows.Forms.GroupBox groupBox2;
          private System.Windows.Forms.TextBox txtTen;
          private System.Windows.Forms.Button btnTKTenMaNV;
          private System.Windows.Forms.CheckBox cbHoTen;
          private System.Windows.Forms.TextBox textBox1;
          private System.Windows.Forms.CheckBox cbMaNV;
          private System.Windows.Forms.ComboBox cbxDeMuc;
     }
}