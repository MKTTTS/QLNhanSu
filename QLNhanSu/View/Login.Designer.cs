namespace View
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tenDangNhap_txb = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.matKhau_txb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dangNhap_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tenDangNhap_txb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(81, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 41);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "PM QUẢN LÝ NHÂN VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // tenDangNhap_txb
            // 
            this.tenDangNhap_txb.Location = new System.Drawing.Point(94, 10);
            this.tenDangNhap_txb.Name = "tenDangNhap_txb";
            this.tenDangNhap_txb.Size = new System.Drawing.Size(228, 20);
            this.tenDangNhap_txb.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.matKhau_txb);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(81, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 41);
            this.panel2.TabIndex = 0;
            // 
            // matKhau_txb
            // 
            this.matKhau_txb.Location = new System.Drawing.Point(94, 10);
            this.matKhau_txb.Name = "matKhau_txb";
            this.matKhau_txb.PasswordChar = '*';
            this.matKhau_txb.Size = new System.Drawing.Size(228, 20);
            this.matKhau_txb.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu";
            // 
            // dangNhap_btn
            // 
            this.dangNhap_btn.Location = new System.Drawing.Point(291, 143);
            this.dangNhap_btn.Name = "dangNhap_btn";
            this.dangNhap_btn.Size = new System.Drawing.Size(116, 23);
            this.dangNhap_btn.TabIndex = 0;
            this.dangNhap_btn.Text = "ĐĂNG NHẬP";
            this.dangNhap_btn.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 189);
            this.Controls.Add(this.dangNhap_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tenDangNhap_txb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox matKhau_txb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button dangNhap_btn;
    }
}