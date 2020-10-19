namespace View
{
    partial class Vitri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vitri));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgVT = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaVT = new System.Windows.Forms.TextBox();
            this.txtTenVT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_EditVT = new System.Windows.Forms.Button();
            this.btn_AddVT = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVT)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgVT);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(367, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 423);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // dgVT
            // 
            this.dgVT.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgVT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVT.Location = new System.Drawing.Point(11, 18);
            this.dgVT.Name = "dgVT";
            this.dgVT.RowHeadersWidth = 51;
            this.dgVT.Size = new System.Drawing.Size(398, 399);
            this.dgVT.TabIndex = 0;
            this.dgVT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVT_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(294, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 35);
            this.label1.TabIndex = 19;
            this.label1.Text = "QUẢN LÝ CHỨC VỤ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaVT);
            this.groupBox1.Controls.Add(this.txtTenVT);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 423);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn";
            // 
            // txtMaVT
            // 
            this.txtMaVT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaVT.Location = new System.Drawing.Point(115, 46);
            this.txtMaVT.Name = "txtMaVT";
            this.txtMaVT.Size = new System.Drawing.Size(179, 26);
            this.txtMaVT.TabIndex = 1;
            // 
            // txtTenVT
            // 
            this.txtTenVT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenVT.Location = new System.Drawing.Point(115, 96);
            this.txtTenVT.Name = "txtTenVT";
            this.txtTenVT.Size = new System.Drawing.Size(179, 26);
            this.txtTenVT.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên vị trí";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã vị trí";
            // 
            // btn_save
            // 
            this.btn_save.Image = global::View.Properties.Resources.Save_24x24;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(831, 370);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(92, 39);
            this.btn_save.TabIndex = 23;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_EditVT
            // 
            this.btn_EditVT.Image = ((System.Drawing.Image)(resources.GetObject("btn_EditVT.Image")));
            this.btn_EditVT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EditVT.Location = new System.Drawing.Point(831, 274);
            this.btn_EditVT.Name = "btn_EditVT";
            this.btn_EditVT.Size = new System.Drawing.Size(92, 39);
            this.btn_EditVT.TabIndex = 22;
            this.btn_EditVT.Text = "Sửa";
            this.btn_EditVT.UseVisualStyleBackColor = true;
            this.btn_EditVT.Click += new System.EventHandler(this.btn_EditVT_Click);
            // 
            // btn_AddVT
            // 
            this.btn_AddVT.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddVT.Image")));
            this.btn_AddVT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddVT.Location = new System.Drawing.Point(831, 188);
            this.btn_AddVT.Name = "btn_AddVT";
            this.btn_AddVT.Size = new System.Drawing.Size(92, 39);
            this.btn_AddVT.TabIndex = 21;
            this.btn_AddVT.Text = "Thêm";
            this.btn_AddVT.UseVisualStyleBackColor = true;
            this.btn_AddVT.Click += new System.EventHandler(this.btn_AddVT_Click);
            // 
            // Vitri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 559);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_EditVT);
            this.Controls.Add(this.btn_AddVT);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Vitri";
            this.Text = "Vitri";
            this.Load += new System.EventHandler(this.Vitri_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgVT)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_EditVT;
        private System.Windows.Forms.Button btn_AddVT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgVT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaVT;
        private System.Windows.Forms.TextBox txtTenVT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_save;
    }
}