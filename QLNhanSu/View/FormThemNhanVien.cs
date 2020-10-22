using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FormThemNhanVien : Form
    {
        public FormThemNhanVien()
        {

            
            InitializeComponent();
            this.maskedTextBoxNgayKy.Enabled = false;
            this.comboBoxGioitinh.Text = "Nam";
            this.comboBox1.Text = "Không thời hạn";
            this.maskedTextBoxNgayHetHan.Enabled = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FormThemNhanVien_Load(object sender, EventArgs e)
        {
            
            var r = new DatabaseNV().Select("MANVMAX");
            int n = Int32.Parse(r["MaLonNhat"].ToString());
            n = n + 1;
            if (n < 10)
            {
                this.textBoxMaNV.Text = String.Concat("NV", "0000000", n.ToString());
            }
            if (n > 9 && n < 100)
            {
                this.textBoxMaNV.Text = String.Concat("NV", "000000", n.ToString());
            }
            if (n > 99 && n < 1000)
            {
                this.textBoxMaNV.Text = String.Concat("NV", "00000", n.ToString());
            }
            if (n > 999 && n < 10000)
            {
                this.textBoxMaNV.Text = String.Concat("NV", "0000", n.ToString());
            }
            if (n > 9999 && n < 100000)
            {
                this.textBoxMaNV.Text = String.Concat("NV", "000", n.ToString());
            }
            if (n > 99999 && n < 1000000)
            {
                this.textBoxMaNV.Text = String.Concat("NV", "00", n.ToString());
            }
            if (n > 999999 && n < 10000000)
            {
                this.textBoxMaNV.Text = String.Concat("NV", "0", n.ToString());
            }
            if (n > 9999999 && n < 100000000)
            {
                this.textBoxMaNV.Text = String.Concat("NV", n.ToString());
            }
            DateTime now = DateTime.Now;
            this.maskedTextBoxNgayKy.Text = now.ToString("dd/MM/yyyy");
            string conString = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(conString);
            sqlCon.Open();
            comboBoxPhongBan.Items.Clear();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PHONGBAN", sqlCon);
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBoxPhongBan.Items.Add(dt.Rows[i]["TenPB"]);
            }
            


        }
            

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void comboBoxPhongBan_TextChanged(object sender, EventArgs e)
        {
            string phongban = comboBoxPhongBan.Text;
            string conString = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(conString);
            sqlCon.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            if (phongban != "Ban điều hành")
            {
                da = new SqlDataAdapter("SELECT * FROM PHONGBAN", sqlCon);
                dt.Clear();
                da.Fill(dt);
                int count = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["TenPB"].ToString() == phongban)
                    {
                        if (dt.Rows[i]["MaTP"].ToString().Length == 0)
                        {
                            count = 1;
                        }
                        else
                        {

                        }
                    }
                }
                da = new SqlDataAdapter("SELECT * FROM CHUCVU", sqlCon);
                dt.Clear();
                da.Fill(dt);
                this.comboboxChucVu.Items.Clear();
                if (count == 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i]["TenCV"].ToString() != "Trưởng phòng" && dt.Rows[i]["TenCV"].ToString() != "Chủ tịch" && dt.Rows[i]["TenCV"].ToString() != "Giám đốc" && dt.Rows[i]["TenCV"].ToString() != "Phó giám đốc")
                        {
                            this.comboboxChucVu.Items.Add(dt.Rows[i]["TenCV"]);
                        }
                    }
                    this.comboboxChucVu.Items.Add("Không");
                }
                else
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        if (dt.Rows[i]["TenCV"].ToString() != "Chủ tịch" && dt.Rows[i]["TenCV"].ToString() != "Giám đốc" && dt.Rows[i]["TenCV"].ToString() != "Phó giám đốc")
                        {
                            this.comboboxChucVu.Items.Add(dt.Rows[i]["TenCV"]);
                        }

                    }
                    this.comboboxChucVu.Items.Add("Không");
                }

            }
            else
            {
                da = new SqlDataAdapter("SELECT * FROM PHONGBAN", sqlCon);
                dt.Clear();
                da.Fill(dt);
                int count = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["TenPB"].ToString() == phongban)
                    {
                        if (dt.Rows[i]["MaTP"].ToString().Length == 0)
                        {
                            count = 1;
                        }
                        else
                        {

                        }
                    }
                }
                da = new SqlDataAdapter("SELECT * FROM CHUCVU", sqlCon);
                dt.Clear();
                da.Fill(dt);
                this.comboboxChucVu.Items.Clear();
                if (count == 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i]["TenCV"].ToString() != "Chủ tịch" && dt.Rows[i]["TenCV"].ToString() != "Trưởng phòng" && dt.Rows[i]["TenCV"].ToString() != "Phó phòng")
                        {
                            this.comboboxChucVu.Items.Add(dt.Rows[i]["TenCV"]);
                        }
                    }
                    
                }
                else
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        if (dt.Rows[i]["TenCV"].ToString() != "Trưởng phòng" && dt.Rows[i]["TenCV"].ToString() != "Phó phòng")
                        {
                            this.comboboxChucVu.Items.Add(dt.Rows[i]["TenCV"]);
                        }

                    }
                    
                }

            }
            sqlCon.Close();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if(this.comboBox1.Text == "Có thời hạn")
            {
                this.maskedTextBoxNgayHetHan.Enabled = true;
            }
            else
            {
                this.maskedTextBoxNgayHetHan.Enabled = false;
            }
        }
        public bool CheckCMND(string S)
        {
            if(S.Length != 9 && S.Length != 12)
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
                    if(r["TonTai"].ToString()== "1")
                    {
                        Result = false;
                    }
                }
                return Result;

                

            }
        }
        public bool CheckLuong(string S)
        {
            if (S.Length == 0)
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
                return Result;
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            DateTime ngaysinh;
            DateTime ngayhethan ;
            DateTime now = DateTime.Now;
            try
            {
                ngaysinh = DateTime.ParseExact(maskedTextBoxNgaysinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
                maskedTextBoxNgaysinh.Select();
                return;
            }
            if (DateTime.Compare(ngaysinh, now) >= 0)
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
                maskedTextBoxNgaysinh.Select();
                return;
            }
            if(CheckCMND(this.textBoxCMND.Text) == false)
            {
                MessageBox.Show("Số CMND không hợp lệ");
                this.textBoxCMND.Select();
                return;
            }
            if(this.textBoxDanToc.Text == "")
            {
                MessageBox.Show("Chưa điền dân tộc");
                return;
            }
            if(this.comboBox1.Text == "Có thời hạn")
            {
                try
                {
                    ngayhethan = DateTime.ParseExact(this.maskedTextBoxNgayHetHan.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ngày hết hạn không hợp lệ");
                    this.maskedTextBoxNgayHetHan.Select();
                    return;
                }
                if(DateTime.Compare(ngayhethan, now) <= 0)
                {
                    MessageBox.Show("Ngày hết hạn không hợp lệ");
                    this.maskedTextBoxNgayHetHan.Select();
                    return;
                }
                
            }
                if (this.comboBoxPhongBan.Text == "")
            {
                MessageBox.Show("Chưa có phòng ban");
                
                return;
            }
                if(this.comboBoxViTri.Text == "")
            {
                if (this.comboboxChucVu.Text != "Lao công" && this.comboboxChucVu.Text != "Chủ tịch")
                {
                    MessageBox.Show("Vị trí không hợp lệ");

                    return;
                }

            }
                if (CheckLuong(this.textBox1.Text) == false)
                {
                    MessageBox.Show("Số lương không hợp lệ");
                    this.textBox1.Select();
                    return;
                }
            string sql = "THEMMOINHANVIEN";
            List<CustomerParameter> lstPara = new List<CustomerParameter>();
            lstPara.Add(new CustomerParameter() { key = "@manhanvien", value = this.textBoxMaNV.Text });
            lstPara.Add(new CustomerParameter() { key = "@gioitinh", value = this.comboBoxGioitinh.Text });
            lstPara.Add(new CustomerParameter() { key = "@hoten", value = this.textBoxHoTen.Text });
            lstPara.Add(new CustomerParameter() { key = "@ngaysinh", value = ngaysinh.ToString("yyyy-MM-dd") });
            lstPara.Add(new CustomerParameter() { key = "@diachi", value = this.textBoxDiaChi.Text });
            lstPara.Add(new CustomerParameter() { key = "@sdt", value = this.textBoxSDT.Text });
            lstPara.Add(new CustomerParameter() { key = "@cmnd", value = this.textBoxCMND.Text });
            lstPara.Add(new CustomerParameter() { key = "@dantoc", value = this.textBoxDanToc.Text });
            lstPara.Add(new CustomerParameter() { key = "@tongiao", value = this.textBoxTongiao.Text });
            lstPara.Add(new CustomerParameter() { key = "@bangcap", value = this.textBoxBangCap.Text });
            lstPara.Add(new CustomerParameter() { key = "@hopdong", value = this.comboBox1.Text });
            lstPara.Add(new CustomerParameter() { key = "@ngayky", value = now.ToString("yyyy-MM-dd") });
            if (this.comboBox1.Text == "Không thời hạn")
            {
                lstPara.Add(new CustomerParameter() { key = "@ngayhethan", value = ngaysinh.ToString("yyyy-MM-dd") });
            }
            else
            {
                lstPara.Add(new CustomerParameter() { key = "@ngayhethan", value = DateTime.ParseExact(maskedTextBoxNgayHetHan.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd") });
            }
            lstPara.Add(new CustomerParameter() { key = "@phongban", value = this.comboBoxPhongBan.Text });
            lstPara.Add(new CustomerParameter() { key = "@chucvu", value = this.comboboxChucVu.Text });
            lstPara.Add(new CustomerParameter() { key = "@vitri", value = this.comboBoxViTri.Text });
            lstPara.Add(new CustomerParameter() { key = "@luong", value = this.textBox1.Text });
            var r = new DatabaseNV().Excute(sql, lstPara, null);
            if (r > 0)
            {
                MessageBox.Show("Thêm thành công.");
                this.Dispose();

            }




        }

        private void comboboxChucVu_TextChanged(object sender, EventArgs e)
        {
            string chucvu = comboboxChucVu.Text;
            string conString = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(conString);
            sqlCon.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da = new SqlDataAdapter("SELECT * FROM VITRICONGVIEC", sqlCon);
            dt.Clear();
            da.Fill(dt);
            if (chucvu != "Chủ tịch" && chucvu != "Lao công")
            {
                comboBoxViTri.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    comboBoxViTri.Items.Add(dt.Rows[i]["TenVT"]);
                }
            }
            else
            {
                comboBoxViTri.Items.Clear();
            }
            sqlCon.Close();
        }
    }
    }

