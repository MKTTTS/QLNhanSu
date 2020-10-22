using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class DanhSachLuong : Form
    {
        private string Manhanvien;
        private int Level;
        public DanhSachLuong(string MNV, int level)
        {
            this.Manhanvien = MNV;
            this.Level = level;
            InitializeComponent();
            string conString = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(conString);
            sqlCon.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da = new SqlDataAdapter("SELECT * FROM PHONGBAN", sqlCon);
            dt.Clear();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                this.comboBoxPhongban.Items.Add(dt.Rows[i]["TenPB"]);
            }
            sqlCon.Close();
            DateTime now = new DateTime();
            now = DateTime.Now;
            this.textBoxThang.Text = now.Month.ToString();
            this.textBoxNam.Text = now.Year.ToString();
            this.textBoxNam.ReadOnly = true;
            this.textBoxThang.ReadOnly = true;
            this.textBoxMaNV.Enabled = false;
            this.textBoxHoten.Enabled = false;
            this.textBoxLuongCB.Text = "0";
            this.textBoxLuongThuong.Text = "0";
            this.textBoxTongLuong.Text = "0";
        }
        public void ThongTinLuongNhanVien(string mnv, int Level, int Object)
        {
            var r = new DatabaseNV().Select("SELECTLUONG '" + mnv + "'");
            this.textBoxMaNV.Text = r["MaNV"].ToString();
            this.textBoxHoten.Text = r["HoTen"].ToString();
            string[] arr = r["LuongCB"].ToString().Split('.');
            this.textBoxLuongCB.Text = arr[0];
            this.textBoxLuongThuong.Text = r["LuongThuong"].ToString();
            this.numericUpDown1.Value = Int32.Parse(r["SoNgayTangCa"].ToString());
            this.textBoxTongLuong.Text = r["TongLuong"].ToString();
            this.textBoxNote.Text = r["GhiChu"].ToString();
            if(Level > Object)
            {
                this.panel2.Enabled = false;
            }
            else
            {
                if(Level == Object)
                {
                    if(Level > 1)
                    {
                        this.panel2.Enabled = false;
                    }
                    else
                    {
                        this.panel2.Enabled = false;
                    }
                }
                else
                {
                    if(Level == 2 && Object == 3)
                    {
                        this.panel2.Enabled = false;
                    }
                    else if(Level == 4 && Object == 5)
                    {
                        this.panel2.Enabled = false;
                    }
                    else
                    {
                        this.panel2.Enabled = true;
                    }
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void DanhSachLuong_Load(object sender, EventArgs e)
        {
            ThongTinLuongNhanVien(this.Manhanvien, this.Level, this.Level);
            if(this.Level > 5)
            {
                this.panel1.Enabled = false;
                this.panel2.Enabled = false;
            }
            else if (this.Level > 3 && this.Level <= 5)
            {
                this.buttonRefresh.Enabled = false;

                var r = new DatabaseNV().Select("TIMPHONGBANTHEONHANVIEN '" + this.Manhanvien + "'");
                string tenPB = r["TenPB"].ToString();
                this.comboBoxPhongban.Items.Clear();
                this.comboBoxPhongban.Items.Add(tenPB);
                this.textBoxLuongCB.Enabled = false;
            }
            }
            
        

        private void comboBoxPhongban_TextChanged(object sender, EventArgs e)
        {
            string TenPB = this.comboBoxPhongban.Text;
            List<CustomerParameter> lst = new List<CustomerParameter>();
            lst.Add(new CustomerParameter() { key = "@tenphongban", value = TenPB });
            var r = new DatabaseNV();
            dataGridViewLuong.DataSource = r.SelectData("BANGLUONGTHEOPHONG", lst);
        }

        private void dataGridViewLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //MessageBox.Show(dataGridViewNhanVien.Rows[e.RowIndex].Cells["Mã nhân viên"].Value.ToString());

                var mnv = dataGridViewLuong.Rows[e.RowIndex].Cells["Mã nhân viên"].Value.ToString();
                if (!string.IsNullOrEmpty(mnv))
                {
                    List<CustomerParameter> lst = new List<CustomerParameter>();
                    lst.Add(new CustomerParameter() { key = "@manhanvien", value = mnv });
                    var r = new DatabaseNV().SelectData("LEVELDANGNHAP", lst);
                    int n = Convert.ToInt32(r.Rows[0]["Level"].ToString());
                    ThongTinLuongNhanVien(mnv, this.Level, n);
                }

            }
        }

        private void textBoxLuongCB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int m, n, k;
                if (this.textBoxLuongCB.Text == "")
                {
                    n = 0;
                }
                else
                {
                    n = Int32.Parse(this.textBoxLuongCB.Text);
                }
                if (this.textBoxLuongThuong.Text == "")
                {
                    m = 0;
                }
                else
                {
                    m = Int32.Parse(this.textBoxLuongThuong.Text);
                }

                k = Int32.Parse(numericUpDown1.Value.ToString());
                this.textBoxTongLuong.Text = (m + n + k * 50000).ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Nhập lại lương cơ bản");
                this.textBoxLuongCB.Text = "0";

            }

        }

        private void textBoxLuongThuong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int m, n, k;
                if(this.textBoxLuongCB.Text == "")
                {
                    n = 0;
                }
                else
                {
                    n = Int32.Parse(this.textBoxLuongCB.Text);
                }
                if(this.textBoxLuongThuong.Text == "")
                {
                    m = 0;
                }
                else
                {
                    m = Int32.Parse(this.textBoxLuongThuong.Text);
                }
                
                k = Int32.Parse(numericUpDown1.Value.ToString());
                this.textBoxTongLuong.Text = (m + n + k * 50000).ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Nhập lại lương thưởng");
                this.textBoxLuongThuong.Text = "0";

            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int m, n, k;
                if (this.textBoxLuongCB.Text == "")
                {
                    n = 0;
                }
                else
                {
                    n = Int32.Parse(this.textBoxLuongCB.Text);
                }
                if (this.textBoxLuongThuong.Text == "")
                {
                    m = 0;
                }
                else
                {
                    m = Int32.Parse(this.textBoxLuongThuong.Text);
                }

                k = Int32.Parse(numericUpDown1.Value.ToString());
                this.textBoxTongLuong.Text = (m + n + k * 50000).ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Nhập lại số ngày tăng ca");
                this.textBoxLuongThuong.Clear();

            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            List<CustomerParameter> lst = new List<CustomerParameter>();
            lst.Add(new CustomerParameter() { key = "@manhanvien", value = this.textBoxMaNV.Text });
            lst.Add(new CustomerParameter() { key = "@luongCB", value = this.textBoxLuongCB.Text });
            lst.Add(new CustomerParameter() { key = "@luongthuong", value = this.textBoxLuongThuong.Text });
            lst.Add(new CustomerParameter() { key = "@songaytangca", value = this.numericUpDown1.Value.ToString() });
            lst.Add(new CustomerParameter() { key = "@tongluong", value = this.textBoxTongLuong.Text });
            lst.Add(new CustomerParameter() { key = "@ghichu", value = this.textBoxNote.Text });
            var r = new DatabaseNV().Excute("UPDATELUONG", lst, null);
            if (r > 0)
            {
                MessageBox.Show("Cập nhật thành công.");
                

            }

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            List<CustomerParameter> lst = new List<CustomerParameter>();
            var rs = new DatabaseNV().Excute("REFRESH", lst, null);
            if(rs > 0)
            {
                MessageBox.Show("Làm mới thành công");
            }
        }
    }
}
