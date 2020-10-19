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
            this.components = new System.ComponentModel.Container();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.phongBanDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phongBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbQLPB = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dIACHITextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mAPBTextBox = new System.Windows.Forms.TextBox();
            this.mATPTextBox = new System.Windows.Forms.TextBox();
            this.tENPBTextBox = new System.Windows.Forms.TextBox();
            this.tENTPTextBox = new System.Windows.Forms.TextBox();
            this.lbTenTp = new System.Windows.Forms.Label();
            this.lbTenPB = new System.Windows.Forms.Label();
            this.lbMaTP = new System.Windows.Forms.Label();
            this.lbMPB = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Location = new System.Drawing.Point(733, 254);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(81, 38);
            this.btSua.TabIndex = 7;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(493, 251);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(86, 38);
            this.btThem.TabIndex = 6;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.phongBanDataGridView);
            this.panel2.Location = new System.Drawing.Point(106, 345);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(952, 357);
            this.panel2.TabIndex = 1;
            // 
            // phongBanDataGridView
            // 
            this.phongBanDataGridView.AutoGenerateColumns = false;
            this.phongBanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phongBanDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.phongBanDataGridView.DataSource = this.phongBanBindingSource;
            this.phongBanDataGridView.Location = new System.Drawing.Point(165, 19);
            this.phongBanDataGridView.Name = "phongBanDataGridView";
            this.phongBanDataGridView.RowHeadersWidth = 51;
            this.phongBanDataGridView.Size = new System.Drawing.Size(678, 285);
            this.phongBanDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAPB";
            this.dataGridViewTextBoxColumn1.HeaderText = "MAPB";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENPB";
            this.dataGridViewTextBoxColumn2.HeaderText = "TENPB";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MATP";
            this.dataGridViewTextBoxColumn3.HeaderText = "MATP";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TENTP";
            this.dataGridViewTextBoxColumn4.HeaderText = "TENTP";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DIACHI";
            this.dataGridViewTextBoxColumn5.HeaderText = "DIACHI";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // phongBanBindingSource
            // 
            this.phongBanBindingSource.DataSource = typeof(DTO.PhongBan);
            // 
            // lbQLPB
            // 
            this.lbQLPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQLPB.Location = new System.Drawing.Point(333, 19);
            this.lbQLPB.Name = "lbQLPB";
            this.lbQLPB.Size = new System.Drawing.Size(246, 34);
            this.lbQLPB.TabIndex = 0;
            this.lbQLPB.Text = "Quản ý Phòng Ban";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.dIACHITextBox);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.mAPBTextBox);
            this.panel1.Controls.Add(this.mATPTextBox);
            this.panel1.Controls.Add(this.tENPBTextBox);
            this.panel1.Controls.Add(this.tENTPTextBox);
            this.panel1.Controls.Add(this.btSua);
            this.panel1.Controls.Add(this.btThem);
            this.panel1.Controls.Add(this.lbTenTp);
            this.panel1.Controls.Add(this.lbTenPB);
            this.panel1.Controls.Add(this.lbMaTP);
            this.panel1.Controls.Add(this.lbMPB);
            this.panel1.Controls.Add(this.lbQLPB);
            this.panel1.Location = new System.Drawing.Point(106, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 336);
            this.panel1.TabIndex = 0;
            // 
            // dIACHITextBox
            // 
            this.dIACHITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phongBanBindingSource, "DIACHI", true));
            this.dIACHITextBox.Enabled = false;
            this.dIACHITextBox.Location = new System.Drawing.Point(165, 223);
            this.dIACHITextBox.Name = "dIACHITextBox";
            this.dIACHITextBox.Size = new System.Drawing.Size(210, 22);
            this.dIACHITextBox.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(462, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 44);
            this.button1.TabIndex = 24;
            this.button1.Text = "Hoàn thành";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Địa  Chỉ";
            // 
            // mAPBTextBox
            // 
            this.mAPBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phongBanBindingSource, "MAPB", true));
            this.mAPBTextBox.Enabled = false;
            this.mAPBTextBox.Location = new System.Drawing.Point(165, 104);
            this.mAPBTextBox.Name = "mAPBTextBox";
            this.mAPBTextBox.Size = new System.Drawing.Size(210, 22);
            this.mAPBTextBox.TabIndex = 15;
            this.mAPBTextBox.TextChanged += new System.EventHandler(this.mAPBTextBox_TextChanged);
            // 
            // mATPTextBox
            // 
            this.mATPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phongBanBindingSource, "MATP", true));
            this.mATPTextBox.Enabled = false;
            this.mATPTextBox.Location = new System.Drawing.Point(638, 104);
            this.mATPTextBox.Name = "mATPTextBox";
            this.mATPTextBox.Size = new System.Drawing.Size(219, 22);
            this.mATPTextBox.TabIndex = 17;
            // 
            // tENPBTextBox
            // 
            this.tENPBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phongBanBindingSource, "TENPB", true));
            this.tENPBTextBox.Enabled = false;
            this.tENPBTextBox.Location = new System.Drawing.Point(165, 170);
            this.tENPBTextBox.Name = "tENPBTextBox";
            this.tENPBTextBox.Size = new System.Drawing.Size(210, 22);
            this.tENPBTextBox.TabIndex = 19;
            // 
            // tENTPTextBox
            // 
            this.tENTPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phongBanBindingSource, "TENTP", true));
            this.tENTPTextBox.Enabled = false;
            this.tENTPTextBox.Location = new System.Drawing.Point(638, 175);
            this.tENTPTextBox.Name = "tENTPTextBox";
            this.tENTPTextBox.Size = new System.Drawing.Size(219, 22);
            this.tENTPTextBox.TabIndex = 21;
            // 
            // lbTenTp
            // 
            this.lbTenTp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenTp.Location = new System.Drawing.Point(526, 175);
            this.lbTenTp.Name = "lbTenTp";
            this.lbTenTp.Size = new System.Drawing.Size(73, 17);
            this.lbTenTp.TabIndex = 4;
            this.lbTenTp.Text = "Tên TP";
            // 
            // lbTenPB
            // 
            this.lbTenPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenPB.Location = new System.Drawing.Point(73, 170);
            this.lbTenPB.Name = "lbTenPB";
            this.lbTenPB.Size = new System.Drawing.Size(75, 17);
            this.lbTenPB.TabIndex = 3;
            this.lbTenPB.Text = "Tên PB";
            // 
            // lbMaTP
            // 
            this.lbMaTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaTP.Location = new System.Drawing.Point(534, 104);
            this.lbMaTP.Name = "lbMaTP";
            this.lbMaTP.Size = new System.Drawing.Size(65, 17);
            this.lbMaTP.TabIndex = 2;
            this.lbMaTP.Text = "Mã TP";
            // 
            // lbMPB
            // 
            this.lbMPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMPB.Location = new System.Drawing.Point(77, 104);
            this.lbMPB.Name = "lbMPB";
            this.lbMPB.Size = new System.Drawing.Size(71, 17);
            this.lbMPB.TabIndex = 1;
            this.lbMPB.Text = "Mã PB";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.756098F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.2439F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.65248F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.34752F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1126, 705);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(715, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 46);
            this.button2.TabIndex = 26;
            this.button2.Text = "Hoàn Thành";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 708);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PhongBan";
            this.Text = "PhongBan";
            this.Load += new System.EventHandler(this.PhongBan_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.phongBanDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbQLPB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource phongBanBindingSource;
        private System.Windows.Forms.TextBox mAPBTextBox;
        private System.Windows.Forms.TextBox mATPTextBox;
        private System.Windows.Forms.TextBox tENPBTextBox;
        private System.Windows.Forms.TextBox tENTPTextBox;
        private System.Windows.Forms.Label lbTenTp;
        private System.Windows.Forms.Label lbTenPB;
        private System.Windows.Forms.Label lbMaTP;
        private System.Windows.Forms.Label lbMPB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView phongBanDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox dIACHITextBox;
        private System.Windows.Forms.Button button2;
    }
}