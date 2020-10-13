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
                         cbxDeMuc.Items.Add(dt.Rows[i]["BangCap"]);
                    }
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
                    SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT DiaChi FROM NHANVIEN", sqlCon);
                    da.Fill(dt);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                         cbxDeMuc.Items.Add(dt.Rows[i]["DiaChi"]);
                    }
               }
          }

          private void btnTimKiemTieuChi_Click(object sender, EventArgs e)
          {
               /*Bằng Cấp
                 Phòng Ban
                 Địa Chỉ*/
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
                         string qry_CV = "SELECT NV.MaNV,NV.HoTen FROM PHONGBAN AS PB, NHANVIEN AS NV where PB.TenPB = '" + cbxDeMuc.Text + "' and PB.MaPB = NV.MaPB";
                         SqlDataAdapter da = new SqlDataAdapter(qry_CV, sqlCon);
                         da.Fill(dt);
                         dgvKetQua.DataSource = dt;
                         sqlCon.Close();
                         break;
                    }

                    if (cbxTieuChi.Text == "Bằng Cấp")
                    {
                         sqlCon.Open();
                         string qry_BC = "SELECT * FROM NHANVIEN where BangCap='" + cbxDeMuc.Text + "'";
                         SqlDataAdapter da = new SqlDataAdapter(qry_BC, sqlCon);
                         da.Fill(dt);
                         dgvKetQua.DataSource = dt;
                         sqlCon.Close();
                         break;
                    }

                    if (cbxTieuChi.Text == "Địa Chỉ")
                    {
                         sqlCon.Open();
                         string qry_DC = "SELECT * FROM NHANVIEN where BangCap='" + cbxDeMuc.Text + "'";
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
                   
               }
          }

          #endregion
     }
}
