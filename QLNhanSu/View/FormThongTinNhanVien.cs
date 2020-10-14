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
        public FormThongTinNhanVien()
        {
            InitializeComponent();

        }

        public void LoadAgain()
        {

            var db = new DatabaseNV();
            List<CustomerParameter> lst = new List<CustomerParameter>();
            lst.Add(new CustomerParameter() { key = "@tukhoa", value = textBoxTimkiem.Text });
            dgvKetQua.DataSource = db.SelectData("SelectAllNhanVien", lst);
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
                new ThongTinNhanVien(mnv).ShowDialog();
                LoadAgain();
            }
        }
    }
}
