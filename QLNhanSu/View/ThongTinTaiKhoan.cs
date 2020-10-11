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
    public partial class ThongTinTaiKhoan : Form
    {
        public ThongTinTaiKhoan()
        {
            InitializeComponent();
        }

        private void ThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            Loadt(Form1.current_user_id);

        }

        private void Loadt(string MaNV)
        {
            thongTinTaiKhoanBindingSource.DataSource = BUS_TTTaiKhoan.Instance.LoadThongTinTaiKhoan(Form1.current_user_id);
        }

        private void danTocLabel_Click(object sender, EventArgs e)
        {

        }

        private void thongTinTaiKhoanDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //nguyen van kien
        }
    }
}
