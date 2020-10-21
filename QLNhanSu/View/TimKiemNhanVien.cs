using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace View
{
    public partial class TimKiemNhanVien : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
        public TimKiemNhanVien()
        {
            InitializeComponent();


        }

        private void cbxTieuChi_TextChanged(object sender, EventArgs e)
        {
            cbxDeMuc.Items.Clear();

            string conString = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(conString);
            sqlCon.Open();

            DataTable dt = new DataTable();

            if (cbxTieuChi.Text == "Bằng Cấp")
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT BangCap FROM NHANVIEN", sqlCon);
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (!string.IsNullOrEmpty(dt.Rows[i]["BangCap"].ToString())) {
                        cbxDeMuc.Items.Add(dt.Rows[i]["BangCap"]);
                    }
                }
                cbxDeMuc.Items.Add("Không");
            }

            if (cbxTieuChi.Text == "Phòng Ban")
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PHONGBAN", sqlCon);
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbxDeMuc.Items.Add(dt.Rows[i]["TenPB"]);
                }

            }
            if (cbxTieuChi.Text == "Địa Chỉ")
            {
                SqlDataAdapter da = new SqlDataAdapter("select distinct DiaChi from NHANVIEN", sqlCon);
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbxDeMuc.Items.Add(dt.Rows[i]["DiaChi"]);
                }

            }
        }

        private void btnTKTieuChi_Click(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(conString);


            DataTable dt = new DataTable();
            while (true)
            {
                if (cbxDeMuc.Text == "")
                {
                    MessageBox.Show("Điền đầy đủ thông tin");
                    break;
                }

                if (cbxTieuChi.Text == "Phòng Ban")
                {
                    sqlCon.Open();
                    string qry_CV = "SELECT NV.MaNV,NV.HoTen FROM PHONGBAN AS PB, NHANVIEN AS NV where PB.TenPB = N'" + cbxDeMuc.Text + "' and PB.MaPB = NV.MaPB";
                    SqlDataAdapter da = new SqlDataAdapter(qry_CV, sqlCon);
                    da.Fill(dt);
                    dgvKetQua.DataSource = dt;
                    sqlCon.Close();
                    break;
                }

                if (cbxTieuChi.Text == "Bằng Cấp")
                {
                    sqlCon.Open();
                    string qry_BC;
                    if (cbxDeMuc.Text == "Không")
                    {
                        qry_BC = "SELECT * FROM NHANVIEN where BangCap = ''";
                    }
                    else
                    {
                        qry_BC = "SELECT * FROM NHANVIEN where BangCap=N'" + cbxDeMuc.Text + "'";
                    }
                    
                    SqlDataAdapter da = new SqlDataAdapter(qry_BC, sqlCon);
                    da.Fill(dt);
                    dgvKetQua.DataSource = dt;
                    sqlCon.Close();
                    break;
                }

                if (cbxTieuChi.Text == "Địa Chỉ")
                {
                    sqlCon.Open();
                    string qry_DC = "SELECT * FROM NHANVIEN where DiaChi=N'" + cbxDeMuc.Text + "'";
                    SqlDataAdapter da = new SqlDataAdapter(qry_DC, sqlCon);
                    da.Fill(dt);
                    dgvKetQua.DataSource = dt;
                    sqlCon.Close();
                    break;
                }
            }
        }
        #region tìm kiếm theo tên

        private void btnTKTenMaNV_Click(object sender, EventArgs e)
        {
            while (true)
            {
                string conString = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
                SqlConnection sqlCon = new SqlConnection(conString);


                DataTable dt = new DataTable();
                if (cbHoTen.Checked && cbMaNV.Checked)
                {
                    MessageBox.Show("Chỉ tìm theo tên hoặc theo mã nhân viên");
                    break;
                }

                if (cbHoTen.Checked)
                {
                    sqlCon.Open();

                    string qry_Ten = "select MaNV,HoTen,SDT,DiaChi from NHANVIEN where HoTen like '%" + txtTen.Text + "%'";
                    SqlDataAdapter da = new SqlDataAdapter(qry_Ten, sqlCon);
                    da.Fill(dt);
                    dgvKetQua.DataSource = dt;

                    sqlCon.Close();
                    break;
                }

                if (cbMaNV.Checked)
                {
                    sqlCon.Open();

                    string qry_MaNV = "select MaNV,HoTen,SDT,DiaChi from NHANVIEN where MaNV = '" + txtMaNV.Text + "'";
                    SqlDataAdapter da = new SqlDataAdapter(qry_MaNV, sqlCon);
                    da.Fill(dt);
                    dgvKetQua.DataSource = dt;

                    sqlCon.Close();
                    break;
                }
            }
        }

        


        /*private void TimKiemNhanVien_Load(object sender, EventArgs e)
        {


                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                         cbxDeMuc.Items.Add(dt.Rows[i]["DiaChi"]);
                    }
               }
          }*/

        /*private void btnTimKiemTieuChi_Click(object sender, EventArgs e)
        {

             string conString = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
             SqlConnection sqlCon = new SqlConnection(conString);


             DataTable dt = new DataTable();
             while (true)
             {
                  if (cbxDeMuc.Text == "")
                  {
                       MessageBox.Show("Điền đầy đủ thông tin");
                       break;
                  }

                  if(cbxTieuChi.Text == "Phòng Ban")
                  {
                       sqlCon.Open();
                       string qry_CV = "SELECT NV.MaNV,NV.HoTen FROM PHONGBAN AS PB, NHANVIEN AS NV where PB.TenPB = N'" + cbxDeMuc.Text + "' and PB.MaPB = NV.MaPB";
                       SqlDataAdapter da = new SqlDataAdapter(qry_CV, sqlCon);
                       da.Fill(dt);
                       dgvKetQua.DataSource = dt;
                       sqlCon.Close();
                       break;
                  }

                  if (cbxTieuChi.Text == "Bằng Cấp")
                  {
                       sqlCon.Open();
                       string qry_BC = "SELECT * FROM NHANVIEN where BangCap=N'" + cbxDeMuc.Text + "'";
                       SqlDataAdapter da = new SqlDataAdapter(qry_BC, sqlCon);
                       da.Fill(dt);
                       dgvKetQua.DataSource = dt;
                       sqlCon.Close();
                       break;
                  }

                  if (cbxTieuChi.Text == "Địa Chỉ")
                  {
                       sqlCon.Open();
                       string qry_DC = "SELECT * FROM NHANVIEN where DiaChi=N'" + cbxDeMuc.Text + "'";
                       SqlDataAdapter da = new SqlDataAdapter(qry_DC, sqlCon);
                       da.Fill(dt);
                       dgvKetQua.DataSource = dt;
                       sqlCon.Close();
                       break;
                  }
             }
        }
        #region tìm kiếm theo tên

        private void btnTKTenMaNV_Click(object sender, EventArgs e)
        {
             while (true)
             {
                  string conString = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
                  SqlConnection sqlCon = new SqlConnection(conString);


                  DataTable dt = new DataTable();
                  if (cbHoTen.Checked && cbMaNV.Checked)
                  {
                       MessageBox.Show("Chỉ tìm theo tên hoặc theo mã nhân viên");
                       break;
                  }

                  if(cbHoTen.Checked)
                  {
                       sqlCon.Open();

                       string qry_Ten = "select MaNV,HoTen,SDT,DiaChi from NHANVIEN where HoTen like '%" + txtTen.Text + "%'";
                       SqlDataAdapter da = new SqlDataAdapter(qry_Ten, sqlCon);
                       da.Fill(dt);
                       dgvKetQua.DataSource = dt;

                       sqlCon.Close();
                       break;
                  }

                  if (cbMaNV.Checked)
                  {
                       sqlCon.Open();

                       string qry_MaNV = "select MaNV,HoTen,SDT,DiaChi from NHANVIEN where MaNV = '" + txtMaNV.Text + "'";
                       SqlDataAdapter da = new SqlDataAdapter(qry_MaNV, sqlCon);
                       da.Fill(dt);
                       dgvKetQua.DataSource = dt;

                       sqlCon.Close();
                       break;
                  }
             }
        }*/

        #endregion
        
        private void cbHoTen_CheckedChanged(object sender, EventArgs e)
        {
             if (cbHoTen.Checked)
             {
                  txtMaNV.Enabled = false;
                  txtTen.Enabled = true;
             }
             else
             {
                  txtTen.Enabled = false;
             }
        }
        
        private void cbMaNV_CheckedChanged(object sender, EventArgs e)
        {
             if (cbMaNV.Checked)
             {
                  txtTen.Enabled = false;
                  txtMaNV.Enabled = true;
             }
             else
             {
                  txtMaNV.Enabled = false;
             }
        }
    }
}

        



