namespace View
{
    partial class PhongBan
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
            this.dataGridViewPhongban = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMaPB = new System.Windows.Forms.TextBox();
            this.textBoxTenPB = new System.Windows.Forms.TextBox();
            this.textBoxDiaChiPB = new System.Windows.Forms.TextBox();
            this.textBoxTenTP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMaTP = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhongban)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPhongban
            // 
            this.dataGridViewPhongban.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPhongban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhongban.Location = new System.Drawing.Point(134, 353);
            this.dataGridViewPhongban.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewPhongban.MultiSelect = false;
            this.dataGridViewPhongban.Name = "dataGridViewPhongban";
            this.dataGridViewPhongban.ReadOnly = true;
            this.dataGridViewPhongban.RowHeadersWidth = 51;
            this.dataGridViewPhongban.RowTemplate.Height = 24;
            this.dataGridViewPhongban.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPhongban.Size = new System.Drawing.Size(895, 292);
            this.dataGridViewPhongban.TabIndex = 0;
            this.dataGridViewPhongban.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPhongban_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(396, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ PHÒNG BAN";
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(615, 261);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(170, 57);
            this.buttonThem.TabIndex = 2;
            this.buttonThem.Text = "THÊM";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.Location = new System.Drawing.Point(882, 261);
            this.buttonSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(170, 57);
            this.buttonSua.TabIndex = 3;
            this.buttonSua.Text = "SỬA";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 276);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên phòng ban";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mã phòng ban";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(624, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tên trưởng phòng";
            // 
            // textBoxMaPB
            // 
            this.textBoxMaPB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaPB.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBoxMaPB.Location = new System.Drawing.Point(257, 116);
            this.textBoxMaPB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMaPB.Name = "textBoxMaPB";
            this.textBoxMaPB.Size = new System.Drawing.Size(225, 30);
            this.textBoxMaPB.TabIndex = 59;
            // 
            // textBoxTenPB
            // 
            this.textBoxTenPB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenPB.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBoxTenPB.Location = new System.Drawing.Point(257, 191);
            this.textBoxTenPB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTenPB.Name = "textBoxTenPB";
            this.textBoxTenPB.Size = new System.Drawing.Size(225, 30);
            this.textBoxTenPB.TabIndex = 60;
            // 
            // textBoxDiaChiPB
            // 
            this.textBoxDiaChiPB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiaChiPB.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBoxDiaChiPB.Location = new System.Drawing.Point(257, 271);
            this.textBoxDiaChiPB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDiaChiPB.Name = "textBoxDiaChiPB";
            this.textBoxDiaChiPB.Size = new System.Drawing.Size(225, 30);
            this.textBoxDiaChiPB.TabIndex = 61;
            // 
            // textBoxTenTP
            // 
            this.textBoxTenTP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenTP.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBoxTenTP.Location = new System.Drawing.Point(827, 191);
            this.textBoxTenTP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTenTP.Name = "textBoxTenTP";
            this.textBoxTenTP.Size = new System.Drawing.Size(225, 30);
            this.textBoxTenTP.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(624, 121);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mã trưởng phòng";
            // 
            // textBoxMaTP
            // 
            this.textBoxMaTP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaTP.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBoxMaTP.Location = new System.Drawing.Point(827, 116);
            this.textBoxMaTP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMaTP.Name = "textBoxMaTP";
            this.textBoxMaTP.Size = new System.Drawing.Size(225, 30);
            this.textBoxMaTP.TabIndex = 62;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(1059, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 34);
            this.button3.TabIndex = 108;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 658);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBoxTenTP);
            this.Controls.Add(this.textBoxMaTP);
            this.Controls.Add(this.textBoxDiaChiPB);
            this.Controls.Add(this.textBoxTenPB);
            this.Controls.Add(this.textBoxMaPB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPhongban);
            this.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "PhongBan";
            this.Text = "PhongBan";
            this.Load += new System.EventHandler(this.PhongBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhongban)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPhongban;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMaPB;
        private System.Windows.Forms.TextBox textBoxTenPB;
        private System.Windows.Forms.TextBox textBoxDiaChiPB;
        private System.Windows.Forms.TextBox textBoxTenTP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMaTP;
        private System.Windows.Forms.Button button3;
    }
}