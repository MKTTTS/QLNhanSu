using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace View
{
    public partial class ThongTinNhanVien : Form
    { 
        private string mnv;
        public ThongTinNhanVien(string mnv)
        {
            this.mnv = mnv;
            InitializeComponent();
            this.buttonLuu.Enabled = false;
            this.textBoxHoTen.Enabled = false;
            this.comboBoxGioitinh.Enabled = false;
            this.maskedTextBoxNgaysinh.Enabled = false;
            this.textBoxDiaChi.Enabled = false;
            this.textBoxSDT.Enabled = false;
            this.comboboxChucVu.Enabled = false;
            this.textBoxBangCap.Enabled = false;
            this.comboBoxPhongBan.Enabled = false;
            this.comboBoxViTri.Enabled = false;
         
        }

        private void ThongTinNhanVien_Load(object sender, EventArgs e)
        {
            var r = new DatabaseNV().Select("SELECTNhanVien '" + mnv + "'");
            textBoxMaNV.Text = mnv;
            textBoxHoTen.Text = r["HoTen"].ToString();
            textBoxCMND.Text = r["CMTND"].ToString();
            textBoxSDT.Text = r["SDT"].ToString();
            textBoxDiaChi.Text = r["DiaChi"].ToString();
            maskedTextBoxNgaysinh.Text = r["NgaySinh"].ToString(); //// Convert to Date có vấn đề
            //maskedTextBoxNgayvaolam.Text = r["NgayVaoLam"].ToString();
            comboBoxGioitinh.Text = r["GioiTinh"].ToString();
            textBoxBangCap.Text = r["BangCap"].ToString();
            this.mnv = mnv;
            string conString = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(conString);
            sqlCon.Open();
            comboboxChucVu.Items.Clear();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CHUCVU", sqlCon);
                da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboboxChucVu.Items.Add(dt.Rows[i]["TenCV"]);
            }
            comboboxChucVu.Items.Add("Không");
            comboboxChucVu.Text = r["TenCV"].ToString();
            comboBoxPhongBan.Items.Clear();
            dt.Clear();
            da = new SqlDataAdapter("SELECT * FROM PHONGBAN", sqlCon);
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBoxPhongBan.Items.Add(dt.Rows[i]["TenPB"]);
            }
            
            comboBoxPhongBan.Text = r["TenPB"].ToString();
            comboBoxViTri.Items.Clear();
            dt.Clear();
            da = new SqlDataAdapter("SELECT * FROM VITRICONGVIEC", sqlCon);
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBoxViTri.Items.Add(dt.Rows[i]["TenVT"]);
            }

            comboBoxViTri.Text = r["TenVT"].ToString();

            sqlCon.Close();
        }

        private void buttontExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            this.buttonLuu.Enabled = true;
            this.textBoxHoTen.Enabled = true;
            this.comboBoxGioitinh.Enabled = true;
            this.maskedTextBoxNgaysinh.Enabled = true;
            this.textBoxDiaChi.Enabled = true;
            this.textBoxSDT.Enabled = true;
            this.comboboxChucVu.Enabled = true;
            this.textBoxBangCap.Enabled = true;
            this.comboBoxPhongBan.Enabled = true;
            this.comboBoxViTri.Enabled = true;

        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            string sql = "UPDATENHANVIEN";
            string Name = textBoxHoTen.Text;
            string Gioitinh = comboBoxGioitinh.Text;
            DateTime ngaysinh;
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
            string DiaChi = textBoxDiaChi.Text;
            string ChucVu = comboboxChucVu.Text;
            string sdt = textBoxSDT.Text;
            string BangCap = textBoxBangCap.Text;
            string Phongban = comboBoxPhongBan.Text;
            string Vitri = comboBoxViTri.Text;



            List<CustomerParameter> lstPara = new List<CustomerParameter>();
            

            lstPara.Add(new CustomerParameter() { key = "@manhanvien", value = mnv });
            lstPara.Add(new CustomerParameter() { key = "@Gioitinh", value = Gioitinh });
            lstPara.Add(new CustomerParameter() { key = "@Hoten", value = Name });
            lstPara.Add(new CustomerParameter() { key = "@ngaysinh", value = ngaysinh.ToString("yyyy-MM-dd") });
            lstPara.Add(new CustomerParameter() { key = "@diachi", value = DiaChi });
            lstPara.Add(new CustomerParameter() { key = "@sodienthoai", value = sdt });
            lstPara.Add(new CustomerParameter() { key = "@chucvu", value = ChucVu });
            lstPara.Add(new CustomerParameter() { key = "@bangcap", value = BangCap });
            lstPara.Add(new CustomerParameter() { key = "@phongban", value = Phongban });
            lstPara.Add(new CustomerParameter() { key = "@vitricongviec", value = Vitri });
            var rs = new DatabaseNV().Excute(sql, lstPara, null);
            if (rs > 0)
            {
                MessageBox.Show("Cập nhật thành công.");
                this.Dispose();

            }
        }
    }
}
