using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class Hopdong : Form
    {
        private string manv;
        public Hopdong(string mnv)
        {
            this.manv = mnv;
            InitializeComponent();
            this.comboBoxHopDong.Enabled = false;
            this.textBoxHoTen.Enabled = false;
            this.textBoxMaNV.Enabled = false;
            this.comboBoxGioitinh.Enabled = false;
            this.maskedTextBoxNgaysinh.Enabled = false;
            this.maskedTextBoxNgayky.Enabled = false;
            this.maskedTextBoxNgayhethan.Enabled = false;
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Hopdong_Load(object sender, EventArgs e)
        {
            var r = new DatabaseNV().Select("SELECTHOPDONG '" + manv + "'");
            this.textBoxHoTen.Text = r["HoTen"].ToString();
            this.textBoxMaNV.Text = r["MaNV"].ToString();
            this.comboBoxGioitinh.Text = r["GioiTinh"].ToString();
            this.maskedTextBoxNgaysinh.Text = r["NgaySinh"].ToString();
            this.maskedTextBoxNgayky.Text = r["NgayKi"].ToString();
            this.maskedTextBoxNgayhethan.Text = r["NgayHetHan"].ToString();
            if(r["TenHD"].ToString() == "Hợp Đồng Có Thời Hạn")
            {
                this.comboBoxHopDong.Text = "Có thời hạn";
            }
            if(r["TenHD"].ToString() == "Hợp Đồng Không Thời Hạn")
            {
                this.comboBoxHopDong.Text = "Không thời hạn";
            }

        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (this.buttonSua.Text == "THAY ĐỔI")
            {
                this.comboBoxHopDong.Enabled = true;
                this.maskedTextBoxNgayhethan.Enabled = true;
                this.buttonSua.Text = "LƯU";
                return;
            }
            if (this.buttonSua.Text == "LƯU")
            {
                DateTime ngayhethan;
                DateTime now = DateTime.Now;
                if(this.comboBoxHopDong.Text == "Có thời hạn")
                {
                    try
                    {
                        ngayhethan = DateTime.ParseExact(this.maskedTextBoxNgayhethan.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ngày hết hạn không hợp lệ");
                        this.maskedTextBoxNgayhethan.Select();
                        return;
                    }
                    if (DateTime.Compare(ngayhethan, now) <= 0)
                    {
                        MessageBox.Show("Ngày hết hạn không hợp lệ");
                        this.maskedTextBoxNgayhethan.Select();
                        return;
                    }
                }
                string sql = "UPDATEHOPDONG";
                List<CustomerParameter> lst = new List<CustomerParameter>();
                lst.Add(new CustomerParameter() { key = "@manhanvien", value = manv });
                lst.Add(new CustomerParameter() { key = "@tenhopdong", value = this.comboBoxHopDong.Text });
                if(this.comboBoxHopDong.Text == "Có thời hạn")
                {
                    lst.Add(new CustomerParameter() { key = "@ngayhethan", value = DateTime.ParseExact(this.maskedTextBoxNgayhethan.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd") });
                }
                else
                {
                    lst.Add(new CustomerParameter() { key = "@ngayhethan", value = now.ToString("yyyy-MM-dd") });
                }
                var rs = new DatabaseNV().Excute(sql, lst, null);
                    if(rs > 0)
                {
                    MessageBox.Show("Cập nhật thành công.");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại.");
                    this.Dispose();
                }
            }

        }
    }
}
