
  
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class ChucVu : Form
    {
        string connectionString = "Data Source = MIIINH\\SQLEXPRESS;Initial Catalog=QuanLyNhanSu;Integrated Security=True";
        public ChucVu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();
            string sql = "select MaCV, TenCV from CHUCVU";
            SqlCommand com = new SqlCommand(sql, sqlCon);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            sqlCon.Close();
            dgrChucVu.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool check = BUS.BUS_ChucVu.Instance.ThemChucVu(txtMaCV.Text, txtTenCV.Text);
            if (check)
            {
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool check = BUS.BUS_ChucVu.Instance.SuaChucVu(txtMaCV.Text, txtTenCV.Text);
            if (check)
            {
                MessageBox.Show("Sửa thành công!");
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }
    }
}
