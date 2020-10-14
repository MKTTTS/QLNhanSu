using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void doiMatKhau_btn_Click(object sender, EventArgs e)
        {
            if(matKhauMoi_txb.Text == xacNhan_txb.Text)
            {
                bool check = BUS.BUS_TTTaiKhoan.Instance.DoiMatKhau(Form1.current_user_id, matKhauCu_txb.Text, matKhauMoi_txb.Text);
                if (check)
                {
                    MessageBox.Show("Đổi mật khẩu thành công!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Mật Khẩu không chính xác!");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu xác nhận phải trùng nhau!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
