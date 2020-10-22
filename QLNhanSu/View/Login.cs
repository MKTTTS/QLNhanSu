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
                
                List<CustomerParameter> lst = new List<CustomerParameter>();
                lst.Add(new CustomerParameter() { key = "@manhanvien", value = this.tenDangNhap_txb.Text });
                var r = new DatabaseNV().SelectData("CHECKHOPDONG", lst);
                int n = Convert.ToInt32(r.Rows[0]["TrangThai"].ToString());
                if (n == 1)
                {
                    this.Hide();
                    string mnv = this.tenDangNhap_txb.Text;
                    Form1 fm = new Form1(mnv);
                    fm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hợp đồng của bạn đã hết hạn!");
                }
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
