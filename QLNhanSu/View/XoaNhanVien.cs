using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class XoaNhanVien : Form
    {
        private string manv;
        public XoaNhanVien(string mnv)
        {
            this.manv = mnv;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "DELETENHANVIEN";
            List<CustomerParameter> lstPara = new List<CustomerParameter>();
            lstPara.Add(new CustomerParameter() { key = "@manhanvien", value = manv });
            var rs = new DatabaseNV().Excute(sql, lstPara, null);
            if (rs > 0)
            {
                MessageBox.Show("Xóa thành công");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
                this.Dispose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
