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
               string conString = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
               SqlConnection sqlCon = new SqlConnection(conString);
               sqlCon.Open();


               if(cbxTieuChi.Text=="Chức Vụ")
               {
                    cbxDeMuc.Text = "1";
               }

               if (cbxTieuChi.Text == "Bằng Cấp")
               {
                    cbxDeMuc.Text = "2";
               }

               if (cbxTieuChi.Text == "Phòng Ban")
               {
                    cbxDeMuc.Text = "3";
               }

               if (cbxTieuChi.Text == "Địa Chỉ")
               {
                    cbxDeMuc.Text = "4";
               }
          }
     }
}
