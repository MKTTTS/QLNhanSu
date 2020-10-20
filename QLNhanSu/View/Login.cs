using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void dangNhap_btn_Click(object sender, EventArgs e)
        {
            string check;
            check = BUS_Login.Instance.CheckLogin((Object)tenDangNhap_txb.Text, (Object)matKhau_txb.Text);
            if (check == "1")
            {
                this.Hide();
                List<CustomerParameter> lst = new List<CustomerParameter>();
                string mnv = this.tenDangNhap_txb.Text;
                Form1 fm = new Form1(mnv);
                fm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc Mật khẩu không chính xác!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
