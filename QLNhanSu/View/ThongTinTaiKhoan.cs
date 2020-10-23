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
        private string MaNV;
        private string SoCMND;
        public ThongTinTaiKhoan(string mnv)
        {
            this.MaNV = mnv;
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
            this.cMTNDTextBox.Enabled = false;
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
            this.bangCapTextBox.Enabled = false;
            //this.cMTNDTextBox.Enabled = false;
        }
        private void Loadt(string MaNV)
        {
            thongTinTaiKhoanBindingSource.DataSource = BUS_TTTaiKhoan.Instance.LoadThongTinTaiKhoan(this.MaNV);
        }

        private void ThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            Loadt(this.MaNV);
            disableComponent();
            this.SoCMND = this.cMTNDTextBox.Text;
        }

        private void chinhSua_btn_Click(object sender, EventArgs e)
        {
            enableComponent();
        }
        public bool CheckCMND(string S)
        {
            if (S.Length != 9 && S.Length != 12)
            {
                return false;
            }
            else
            {
                bool Result = true;

                foreach (Char c in S)
                {
                    if (!Char.IsDigit(c))
                    {
                        Result = false;
                    }
                }
                if (Result == true)
                {
                    var r = new DatabaseNV().Select("EXEC CHECKCMND '" + S + "'");
                    if (r["TonTai"].ToString() == "1")
                    {
                        Result = false;
                    }
                }
                return Result;



            }
        }
        private void xong_btn_Click(object sender, EventArgs e)
        {
            if(CheckCMND(this.cMTNDTextBox.Text) == false && this.SoCMND != this.cMTNDTextBox.Text)
            {
                MessageBox.Show("Số chứng minh nhân dân không hợp lệ");
                return;
            }
            BUS_TTTaiKhoan.Instance.DoiThongTinCaNhan(this.MaNV, hoTenTextBox.Text, gioiTinhComboBox.Text, ngaySinhDateTimePicker.Value, cMTNDTextBox.Text, danTocTextBox.Text, tonGiaoTextBox.Text, diaChiTextBox.Text, sDTTextBox.Text, bangCapTextBox.Text);
            MessageBox.Show("Cập nhật thông tin thành công");
            disableComponent();
            
        }

        private void doiMatKhau_btn_Click(object sender, EventArgs e)
        {
            DoiMatKhau dmk = new DoiMatKhau(this.MaNV);
            dmk.ShowDialog();
        }
    }
}
