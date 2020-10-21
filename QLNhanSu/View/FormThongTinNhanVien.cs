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
    public partial class FormThongTinNhanVien : Form
    {
        private int Level;
        public FormThongTinNhanVien(int level)
        {
            this.Level = level;
            InitializeComponent();
            this.radioButton1.Checked = true;
            if(this.Level > 3)
            {
                this.button2.Visible = false;
            }


        }

        public void LoadAgain()
        {

            var db = new DatabaseNV();
            List<CustomerParameter> lst = new List<CustomerParameter>();
            lst.Add(new CustomerParameter() { key = "@tukhoa", value = textBoxTimkiem.Text });
            string sql = "";
            if (this.radioButton1.Checked == true)
            {
                sql = "SelectAllNhanVien";
            }
            if (this.radioButton2.Checked == true)
            {
                sql = "SelectAllNhanVienHetHan";
            }
            dgvKetQua.DataSource = db.SelectData(sql, lst);
        }

        private void FormThongTinNhanVienNhanVien_Load(object sender, EventArgs e)
        {
            LoadAgain();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadAgain();
        }

        private void dgvKetQua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //MessageBox.Show(dataGridViewNhanVien.Rows[e.RowIndex].Cells["Mã nhân viên"].Value.ToString());
                var mnv = dgvKetQua.Rows[e.RowIndex].Cells["Mã nhân viên"].Value.ToString();
                List<CustomerParameter> lst = new List<CustomerParameter>();
                lst.Add(new CustomerParameter() { key = "@manhanvien", value = mnv });
                var r = new DatabaseNV().SelectData("LEVELDANGNHAP", lst);
                int m = Convert.ToInt32(r.Rows[0]["Level"].ToString());
                new ThongTinNhanVien(mnv, this.Level, m).ShowDialog();
                LoadAgain();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FormThemNhanVien them = new FormThemNhanVien();
            them.ShowDialog();
        }
    }
}
