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
        List<Control> listOfControl = new List<Control>();
        public ThongTinTaiKhoan()
        {
            InitializeComponent();
            listOfControl.Add(this.hoTenTextBox);
            listOfControl.Add(this.gioiTinhComboBox);
            listOfControl.Add(this.ngaySinhDateTimePicker);
            listOfControl.Add(this.cMTNDTextBox);
            listOfControl.Add(this.danTocTextBox);
            listOfControl.Add(this.tonGiaoTextBox);
            listOfControl.Add(this.diaChiTextBox);
            listOfControl.Add(this.sDTTextBox);
            listOfControl.Add(this.bangCapTextBox);
            this.tenVTTextBox.Enabled = false;
            this.tenCVTextBox.Enabled = false;
            this.tenPBTextBox.Enabled = false;
            this.tongLuongTextBox.Enabled = false;
        }

        void disableComponent()
        {
            foreach (Control c in listOfControl)
            {
                c.Enabled = false;
            }
            xong_btn.Hide();
        }

        void enableComponent()
        {
            foreach (Control c in listOfControl)
            {
                c.Enabled = true;
            }
            xong_btn.Show();
        }
        private void Loadt(string MaNV)
        {
            thongTinTaiKhoanBindingSource.DataSource = BUS_TTTaiKhoan.Instance.LoadThongTinTaiKhoan(Form1.current_user_id);
        }

        private void ThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            Loadt(Form1.current_user_id);
            disableComponent();
        }

        private void chinhSua_btn_Click(object sender, EventArgs e)
        {
            enableComponent();
        }

        private void xong_btn_Click(object sender, EventArgs e)
        {
            BUS_TTTaiKhoan.Instance.DoiThongTinCaNhan(Form1.current_user_id, hoTenTextBox.Text, gioiTinhComboBox.Text, ngaySinhDateTimePicker.Value, cMTNDTextBox.Text, danTocTextBox.Text, tonGiaoTextBox.Text, diaChiTextBox.Text, sDTTextBox.Text, bangCapTextBox.Text);
            disableComponent();
            
        }

        private void doiMatKhau_btn_Click(object sender, EventArgs e)
        {
            DoiMatKhau dmk = new DoiMatKhau();
            dmk.ShowDialog();
        }
    }
}
