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
            this.cbxDeMuc = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbMaNV = new System.Windows.Forms.CheckBox();
            this.cbHoTen = new System.Windows.Forms.CheckBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnTKTenMaNV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKetQua.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dgvKetQua.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Location = new System.Drawing.Point(28, 235);
            this.dgvKetQua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.RowHeadersWidth = 51;
            this.dgvKetQua.Size = new System.Drawing.Size(1000, 459);
            this.dgvKetQua.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(63, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tiêu Chí";
            // 
            // cbxTieuChi
            // 
            this.cbxTieuChi.FormattingEnabled = true;
            this.cbxTieuChi.Items.AddRange(new object[] {
            "Bằng Cấp",
            "Phòng Ban",
            "Địa Chỉ"});
            this.cbxTieuChi.Location = new System.Drawing.Point(135, 39);
            this.cbxTieuChi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxTieuChi.Name = "cbxTieuChi";
            this.cbxTieuChi.Size = new System.Drawing.Size(145, 24);
            this.cbxTieuChi.TabIndex = 2;
            this.cbxTieuChi.TextChanged += new System.EventHandler(this.cbxTieuChi_TextChanged);
            // 
            // btnTKTieuChi
            // 
            this.btnTKTieuChi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnTKTieuChi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTKTieuChi.Location = new System.Drawing.Point(309, 63);
            this.btnTKTieuChi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTKTieuChi.Name = "btnTKTieuChi";
            this.btnTKTieuChi.Size = new System.Drawing.Size(100, 28);
            this.btnTKTieuChi.TabIndex = 5;
            this.btnTKTieuChi.Text = "Tìm Kiếm";
            this.btnTKTieuChi.UseVisualStyleBackColor = false;
            this.btnTKTieuChi.Click += new System.EventHandler(this.btnTKTieuChi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(67, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Đề Mục";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.groupBox1.Controls.Add(this.cbxTieuChi);
            this.groupBox1.Controls.Add(this.cbxDeMuc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnTKTieuChi);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(28, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(460, 161);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Theo Các Tiêu Chí";
            // 
            // cbxDeMuc
            // 
            this.cbxDeMuc.FormattingEnabled = true;
            this.cbxDeMuc.IntegralHeight = false;
            this.cbxDeMuc.Location = new System.Drawing.Point(135, 87);
            this.cbxDeMuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxDeMuc.Name = "cbxDeMuc";
            this.cbxDeMuc.Size = new System.Drawing.Size(145, 24);
            this.cbxDeMuc.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.groupBox2.Controls.Add(this.cbMaNV);
            this.groupBox2.Controls.Add(this.cbHoTen);
            this.groupBox2.Controls.Add(this.txtMaNV);
            this.groupBox2.Controls.Add(this.txtTen);
            this.groupBox2.Controls.Add(this.btnTKTenMaNV);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(560, 28);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(468, 161);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Theo Tên";
            // 
            // cbMaNV
            // 
            this.cbMaNV.AutoSize = true;
            this.cbMaNV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbMaNV.Location = new System.Drawing.Point(23, 90);
            this.cbMaNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(119, 21);
            this.cbMaNV.TabIndex = 11;
            this.cbMaNV.Text = "Mã Nhân Viên";
            this.cbMaNV.UseVisualStyleBackColor = true;
            this.cbMaNV.CheckedChanged += new System.EventHandler(this.cbMaNV_CheckedChanged);
            // 
            // cbHoTen
            // 
            this.cbHoTen.AutoSize = true;
            this.cbHoTen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbHoTen.Location = new System.Drawing.Point(23, 49);
            this.cbHoTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbHoTen.Name = "cbHoTen";
            this.cbHoTen.Size = new System.Drawing.Size(77, 21);
            this.cbHoTen.TabIndex = 10;
            this.cbHoTen.Text = "Họ Tên";
            this.cbHoTen.UseVisualStyleBackColor = true;
            this.cbHoTen.CheckedChanged += new System.EventHandler(this.cbHoTen_CheckedChanged);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(156, 87);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaNV.Multiline = true;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(149, 25);
            this.txtMaNV.TabIndex = 9;
            // 
            // txtTen
            // 
            this.txtTen.Enabled = false;
            this.txtTen.Location = new System.Drawing.Point(113, 46);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTen.Multiline = true;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(192, 24);
            this.txtTen.TabIndex = 7;
            // 
            // btnTKTenMaNV
            // 
            this.btnTKTenMaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnTKTenMaNV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTKTenMaNV.Location = new System.Drawing.Point(333, 63);
            this.btnTKTenMaNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTKTenMaNV.Name = "btnTKTenMaNV";
            this.btnTKTenMaNV.Size = new System.Drawing.Size(100, 28);
            this.btnTKTenMaNV.TabIndex = 5;
            this.btnTKTenMaNV.Text = "Tìm Kiếm";
            this.btnTKTenMaNV.UseVisualStyleBackColor = false;
            this.btnTKTenMaNV.Click += new System.EventHandler(this.btnTKTenMaNV_Click);
            // 
            // TimKiemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1057, 722);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvKetQua);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TimKiemNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
          private System.Windows.Forms.TextBox txtMaNV;
          private System.Windows.Forms.CheckBox cbMaNV;
          private System.Windows.Forms.ComboBox cbxDeMuc;
     }

    

}