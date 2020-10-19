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
    public partial class PhongBan : Form
    {
        public PhongBan()
        {
            InitializeComponent();
            this.textBoxDiaChiPB.Enabled = false;
            this.textBoxMaPB.Enabled = false;
            this.textBoxTenPB.Enabled = false;
            this.textBoxMaTP.Enabled = false;
            this.textBoxTenTP.Enabled = false;
            this.buttonSua.Enabled = false;
       
        }
        private void LoadAgain()
        {
            var r = new DatabaseNV();
            List<CustomerParameter> lst = new List<CustomerParameter>();
            DataTable dt = r.SelectData("Load", lst);
            this.dataGridViewPhongban.DataSource = dt;
            this.buttonSua.Enabled = false;
        }

        private void PhongBan_Load(object sender, EventArgs e)
        {
            LoadAgain();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridViewPhongban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //MessageBox.Show(dataGridViewNhanVien.Rows[e.RowIndex].Cells["Mã nhân viên"].Value.ToString());
                
                    var mnv = dataGridViewPhongban.Rows[e.RowIndex].Cells["Mã phòng ban"].Value.ToString();
                if (!string.IsNullOrEmpty(mnv))
                {
                    var r = new DatabaseNV().Select("SELECTPHONGBAN '" + mnv + "'");
                    this.textBoxMaPB.Text = mnv;
                    this.textBoxTenPB.Text = r["TenPB"].ToString();
                    this.textBoxDiaChiPB.Text = r["DiaChi"].ToString();
                    if (!string.IsNullOrEmpty(r["MaTP"].ToString()))
                    {
                        this.textBoxMaTP.Text = r["MaTP"].ToString();
                    }
                    if (!string.IsNullOrEmpty(r["TenTP"].ToString()))
                    {
                        this.textBoxTenTP.Text = r["TenTP"].ToString();
                    }
                    this.buttonSua.Enabled = true;
                }
                
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if(this.buttonThem.Text == "THÊM")
            {
                this.buttonSua.Enabled = false;
                this.textBoxDiaChiPB.Enabled = true;
                this.textBoxMaPB.Enabled = true;
                this.textBoxTenPB.Enabled = true;
                this.dataGridViewPhongban.Enabled = false;
                this.textBoxDiaChiPB.Text = "";
                this.textBoxMaPB.Text = "";
                this.textBoxTenPB.Text = "";
                this.textBoxMaTP.Text = "";
                this.textBoxTenTP.Text = "";
                this.buttonThem.Text = "LƯU";
                return;
            }
            if(this.buttonThem.Text == "LƯU")
            {
                if(this.textBoxMaPB.Text == "")
                {
                    MessageBox.Show("Mã phòng ban không hợp lệ.");
                }
                
                else {
                    string s = this.textBoxMaPB.Text;
                    var r = new DatabaseNV().Select("SELECT CASE WHEN EXISTS(SELECT * FROM PHONGBAN WHERE MaPB = '"+s+"') THEN 1 WHEN NOT EXISTS(SELECT * FROM PHONGBAN WHERE MaPB = '"+s+"') THEN 0 END AS Flag");
                    if (r["Flag"].ToString() == "1")
                    {
                        MessageBox.Show("Mã phòng ban đã tồn tại.");
                    }
                    else
                    {
                        if (this.textBoxTenPB.Text == "")
                        {
                            MessageBox.Show("Tên phòng ban không hợp lệ.");
                        }
                        else
                        {
                            if (this.textBoxDiaChiPB.Text == "")
                            {
                                MessageBox.Show("Địa chỉ phòng ban không hợp lệ.");
                            }
                            else
                            {

                                string sql = "ThemPB";
                                List<CustomerParameter> lstpara = new List<CustomerParameter>();
                                lstpara.Add(new CustomerParameter() { key = "@MaPB", value = this.textBoxMaPB.Text });
                                lstpara.Add(new CustomerParameter() { key = "@TenPB", value = this.textBoxTenPB.Text });
                                lstpara.Add(new CustomerParameter() { key = "@DiaChi", value = this.textBoxDiaChiPB.Text });
                                var rs = new DatabaseNV().Excute(sql, lstpara, null);
                                if (rs > 0)
                                {
                                    MessageBox.Show("Thêm thành công.");
                                    //this.Dispose();

                                }
                            }
                        }
                    }
                }
                this.buttonSua.Enabled = true;
                this.textBoxDiaChiPB.Enabled = false;
                this.textBoxMaPB.Enabled = false;
                this.textBoxTenPB.Enabled = false;
                this.dataGridViewPhongban.Enabled = true;
                this.buttonThem.Text = "THÊM";
                
                LoadAgain();
                return;
                


            }

        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if(this.buttonSua.Text == "SỬA")
            {
                this.dataGridViewPhongban.Enabled = false;
                this.buttonThem.Enabled = false;
                this.textBoxMaTP.Enabled = false;
                this.textBoxTenTP.Enabled = false;
                this.textBoxMaPB.Enabled = false;
                this.textBoxTenPB.Enabled = true;
                this.textBoxDiaChiPB.Enabled = true;
                this.buttonSua.Text = "LƯU";
                return;
            }
            if(this.buttonSua.Text == "LƯU")
            {
                if(this.textBoxTenPB.Text == "")
                {
                    MessageBox.Show("Tên phòng ban không hợp lệ");
                }
                else
                {
                    if(this.textBoxDiaChiPB.Text == "")
                    {
                        MessageBox.Show("Địa chỉ phòng ban không hợp lệ");
                    }
                    else
                    {
                        List<CustomerParameter> lst = new List<CustomerParameter>();
                        lst.Add(new CustomerParameter() { key = "@MaPB", value = this.textBoxMaPB.Text });
                        lst.Add(new CustomerParameter() { key = "@TenPB", value = this.textBoxTenPB.Text });
                        lst.Add(new CustomerParameter() { key = "@DiaChi", value = this.textBoxDiaChiPB.Text });

                        var rs = new DatabaseNV().Excute("SuaPB", lst, null);
                        if (rs > 0)
                        {
                            MessageBox.Show("Cập nhật thành công.");
                            //this.Dispose();

                        }
                        this.dataGridViewPhongban.Enabled = true;
                        this.buttonThem.Enabled = true;
                        this.textBoxTenPB.Enabled = false;
                        this.textBoxDiaChiPB.Enabled = false;
                        this.buttonSua.Text = "SỬA";
                        LoadAgain();
                        return;
                    }
                }
            }
        }
    }
}
