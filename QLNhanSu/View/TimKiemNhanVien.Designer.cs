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
               this.button1 = new System.Windows.Forms.Button();
               this.cbxDeMuc = new System.Windows.Forms.ComboBox();
               this.label2 = new System.Windows.Forms.Label();
               this.groupBox1 = new System.Windows.Forms.GroupBox();
               this.groupBox2 = new System.Windows.Forms.GroupBox();
               this.textBox1 = new System.Windows.Forms.TextBox();
               this.label3 = new System.Windows.Forms.Label();
               this.button3 = new System.Windows.Forms.Button();
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
               this.label1.Location = new System.Drawing.Point(47, 35);
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
            "Mã Nhân Viên",
            "Bằng Cấp",
            "Phòng Ban",
            "Địa Chỉ",
            ""});
               this.cbxTieuChi.Location = new System.Drawing.Point(101, 32);
               this.cbxTieuChi.Name = "cbxTieuChi";
               this.cbxTieuChi.Size = new System.Drawing.Size(109, 21);
               this.cbxTieuChi.TabIndex = 2;
               this.cbxTieuChi.TextChanged += new System.EventHandler(this.cbxTieuChi_TextChanged);
               // 
               // button1
               // 
               this.button1.Location = new System.Drawing.Point(253, 51);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(75, 23);
               this.button1.TabIndex = 5;
               this.button1.Text = "Tìm Kiếm";
               this.button1.UseVisualStyleBackColor = true;
               // 
               // cbxDeMuc
               // 
               this.cbxDeMuc.FormattingEnabled = true;
               this.cbxDeMuc.Location = new System.Drawing.Point(101, 71);
               this.cbxDeMuc.Name = "cbxDeMuc";
               this.cbxDeMuc.Size = new System.Drawing.Size(109, 21);
               this.cbxDeMuc.TabIndex = 8;
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
               this.groupBox1.Controls.Add(this.button1);
               this.groupBox1.Location = new System.Drawing.Point(12, 12);
               this.groupBox1.Name = "groupBox1";
               this.groupBox1.Size = new System.Drawing.Size(366, 131);
               this.groupBox1.TabIndex = 9;
               this.groupBox1.TabStop = false;
               this.groupBox1.Text = "Theo Các Tiêu Chí";
               // 
               // groupBox2
               // 
               this.groupBox2.Controls.Add(this.textBox1);
               this.groupBox2.Controls.Add(this.label3);
               this.groupBox2.Controls.Add(this.button3);
               this.groupBox2.Location = new System.Drawing.Point(415, 12);
               this.groupBox2.Name = "groupBox2";
               this.groupBox2.Size = new System.Drawing.Size(354, 131);
               this.groupBox2.TabIndex = 10;
               this.groupBox2.TabStop = false;
               this.groupBox2.Text = "Theo Tên";
               // 
               // textBox1
               // 
               this.textBox1.Location = new System.Drawing.Point(73, 53);
               this.textBox1.Multiline = true;
               this.textBox1.Name = "textBox1";
               this.textBox1.Size = new System.Drawing.Size(174, 20);
               this.textBox1.TabIndex = 7;
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Location = new System.Drawing.Point(24, 56);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(43, 13);
               this.label3.TabIndex = 1;
               this.label3.Text = "Họ Tên";
               // 
               // button3
               // 
               this.button3.Location = new System.Drawing.Point(265, 51);
               this.button3.Name = "button3";
               this.button3.Size = new System.Drawing.Size(75, 23);
               this.button3.TabIndex = 5;
               this.button3.Text = "Tìm Kiếm";
               this.button3.UseVisualStyleBackColor = true;
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
          private System.Windows.Forms.Button button1;
          private System.Windows.Forms.ComboBox cbxDeMuc;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.GroupBox groupBox1;
          private System.Windows.Forms.GroupBox groupBox2;
          private System.Windows.Forms.TextBox textBox1;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.Button button3;
     }
}