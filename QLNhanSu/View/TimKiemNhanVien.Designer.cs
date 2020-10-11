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
               this.button2 = new System.Windows.Forms.Button();
               this.cbxDeMuc = new System.Windows.Forms.ComboBox();
               this.label2 = new System.Windows.Forms.Label();
               ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
               this.SuspendLayout();
               // 
               // dgvKetQua
               // 
               this.dgvKetQua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               this.dgvKetQua.BackgroundColor = System.Drawing.SystemColors.Control;
               this.dgvKetQua.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
               this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dgvKetQua.Location = new System.Drawing.Point(12, 181);
               this.dgvKetQua.Name = "dgvKetQua";
               this.dgvKetQua.Size = new System.Drawing.Size(757, 306);
               this.dgvKetQua.TabIndex = 0;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(171, 31);
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
               this.cbxTieuChi.Location = new System.Drawing.Point(223, 28);
               this.cbxTieuChi.Name = "cbxTieuChi";
               this.cbxTieuChi.Size = new System.Drawing.Size(105, 21);
               this.cbxTieuChi.TabIndex = 2;
               this.cbxTieuChi.TextChanged += new System.EventHandler(this.cbxTieuChi_TextChanged);
               // 
               // button1
               // 
               this.button1.Location = new System.Drawing.Point(253, 100);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(75, 23);
               this.button1.TabIndex = 5;
               this.button1.Text = "Tìm Kiếm";
               this.button1.UseVisualStyleBackColor = true;
               // 
               // button2
               // 
               this.button2.Location = new System.Drawing.Point(428, 100);
               this.button2.Name = "button2";
               this.button2.Size = new System.Drawing.Size(75, 23);
               this.button2.TabIndex = 6;
               this.button2.Text = "Thoát";
               this.button2.UseVisualStyleBackColor = true;
               // 
               // cbxDeMuc
               // 
               this.cbxDeMuc.FormattingEnabled = true;
               this.cbxDeMuc.Location = new System.Drawing.Point(428, 28);
               this.cbxDeMuc.Name = "cbxDeMuc";
               this.cbxDeMuc.Size = new System.Drawing.Size(133, 21);
               this.cbxDeMuc.TabIndex = 8;
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(376, 31);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(45, 13);
               this.label2.TabIndex = 7;
               this.label2.Text = "Đề Mục";
               // 
               // TimKiemNhanVien
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(781, 499);
               this.Controls.Add(this.cbxDeMuc);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.button2);
               this.Controls.Add(this.button1);
               this.Controls.Add(this.cbxTieuChi);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.dgvKetQua);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
               this.Name = "TimKiemNhanVien";
               this.Text = "TimKiemNhanVien";
               ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

          #endregion

          private System.Windows.Forms.DataGridView dgvKetQua;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.ComboBox cbxTieuChi;
          private System.Windows.Forms.Button button1;
          private System.Windows.Forms.Button button2;
          private System.Windows.Forms.ComboBox cbxDeMuc;
          private System.Windows.Forms.Label label2;
     }
}