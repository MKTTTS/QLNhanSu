
  
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
    public partial class ChucVu : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
        private int Level;
        public ChucVu(int level)
        {
            this.Level = level;
            InitializeComponent();
            this.txtMaCV.ReadOnly = true;
            this.txtTenCV.ReadOnly = true;
            if(this.Level > 1)
            {
                this.button2.Visible = false;
                this.button4.Visible = false;
            }
        }

        private void LoadAgain()
        {
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();
            string sql = "select MaCV as N'Mã chức vụ', TenCV as N'Tên chức vụ' from CHUCVU";
            SqlCommand com = new SqlCommand(sql, sqlCon);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            sqlCon.Close();
            dgrChucVu.DataSource = dt;
            this.button2.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.button4.Text == "THÊM")
            {
                this.txtTenCV.ReadOnly = false;
                this.dgrChucVu.Enabled = false;
                var r = new DatabaseNV().Select("MACVMAX");
                int n = Int32.Parse(r["MaLonNhat"].ToString());
                n = n + 1;
                if (n < 10)
                {
                    this.txtMaCV.Text = String.Concat("CV", "0000000", n.ToString());
                }
                if (n > 9 && n < 100)
                {
                    this.txtMaCV.Text = String.Concat("CV", "000000", n.ToString());
                }
                if (n > 99 && n < 1000)
                {
                    this.txtMaCV.Text = String.Concat("CV", "00000", n.ToString());
                }
                if (n > 999 && n < 10000)
                {
                    this.txtMaCV.Text = String.Concat("CV", "0000", n.ToString());
                }
                if (n > 9999 && n < 100000)
                {
                    this.txtMaCV.Text = String.Concat("CV", "000", n.ToString());
                }
                if (n > 99999 && n < 1000000)
                {
                    this.txtMaCV.Text = String.Concat("CV", "00", n.ToString());
                }
                if (n > 999999 && n < 10000000)
                {
                    this.txtMaCV.Text = String.Concat("CV", "0", n.ToString());
                }
                if (n > 9999999 && n < 100000000)
                {
                    this.txtMaCV.Text = String.Concat("CV", n.ToString());
                }
                this.txtTenCV.Text = "";
                this.button2.Enabled = false;
                this.button4.Text = "LƯU";
                return;
            }
            else
            {
                if (txtTenCV.Text == "")
                {
                    MessageBox.Show("Chưa có tên chức vụ");
                    this.button4.Text = "THÊM";
                    this.txtTenCV.ReadOnly = true;
                    this.dgrChucVu.Enabled = true;
                    LoadAgain();
                    return;
                }
                else
                {
                    bool check = BUS.BUS_ChucVu.Instance.ThemChucVu(txtMaCV.Text, txtTenCV.Text);
                    if (check)
                    {
                        MessageBox.Show("Thêm thành công");
                        this.button4.Text = "THÊM";
                        this.txtTenCV.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");

                    }
                    this.button4.Text = "THÊM";
                    this.txtTenCV.ReadOnly = true;
                    this.dgrChucVu.Enabled = true;
                    LoadAgain();
                    return;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.button2.Text == "SỬA")
            {
                this.txtTenCV.ReadOnly = false;
                this.button2.Text = "LƯU";
                return;
            }
            else
            {

                if (txtTenCV.Text == "")
                {
                    MessageBox.Show("Chưa có tên chức vụ");
                    this.button2.Text = "SỬA";
                    this.txtTenCV.ReadOnly = true;
                    
                    LoadAgain();
                    return;
                }
                else
                {
                    bool check = BUS.BUS_ChucVu.Instance.SuaChucVu(txtMaCV.Text, txtTenCV.Text);
                    if (check)
                    {
                        MessageBox.Show("Sửa thành công");
                        this.button2.Text = "SỬA";
                        this.txtTenCV.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");

                    }
                    this.button2.Text = "SỬA";
                    this.txtTenCV.ReadOnly = true;
                    
                    LoadAgain();
                    return;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ChucVu_Load(object sender, EventArgs e)
        {
            LoadAgain();
        }

        private void dgrChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                var r = dgrChucVu.Rows[e.RowIndex].Cells["Mã chức vụ"].Value.ToString();
                this.button2.Text = "SỬA";
                this.txtTenCV.ReadOnly = true;
                if (!string.IsNullOrEmpty(r))
                {
                    var rs = new DatabaseNV().Select("SELECT * FROM CHUCVU WHERE MaCV = '" + r + "'");
                    this.txtMaCV.Text = rs["MaCV"].ToString();
                    this.txtTenCV.Text = rs["TenCV"].ToString();
                    this.button2.Enabled = true;
                }
                else
                {
                    this.button2.Enabled = false;
                    
                }
            }
        }
    }
}
