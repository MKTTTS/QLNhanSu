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
    public partial class Vitri : Form
    {
        string flag;
        private int Level;
        SqlConnection connection;
        SqlCommand command;
        private string str = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
        SqlDataAdapter adapter = new SqlDataAdapter();
        System.Data.DataTable table = new System.Data.DataTable();
        void hienthi()
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "SELECT MaVT as N'Mã vị trí', TenVT as N'Tên vị trí' FROM dbo.VITRICONGVIEC";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgVT.DataSource = table;
            dgVT.ReadOnly = true;
            connection.Close();
            this.btn_EditVT.Enabled = false;
            this.txtMaVT.ReadOnly = true;
            this.txtTenVT.ReadOnly = true;
        }
        public Vitri(int level)
        {
            this.Level = level;
            InitializeComponent();
            if(this.Level > 1)
            {
                this.btn_EditVT.Visible = false;
                this.btn_AddVT.Visible = false;
                this.btn_save.Visible = false;
            }
            
        }

        private void Vitri_Load(object sender, EventArgs e)
        {
            lockcontrol();
            connection = new SqlConnection(str);
            hienthi();
        }
        public void lockcontrol()
        {
            btn_save.Enabled = false;
            txtMaVT.ReadOnly = true;
            txtTenVT.ReadOnly = true;
        }
        public void unlock()
        {
            txtMaVT.ReadOnly = true;
            txtTenVT.ReadOnly = false;
            btn_save.Enabled = true;
        }

        

        private void btn_AddVT_Click(object sender, EventArgs e)
        {
            unlock();
            txtMaVT.ReadOnly = false;
            this.btn_EditVT.Enabled = false;
            flag = "add";
            txtMaVT.Text = "";
            txtTenVT.Text = "";
        }

        private void btn_EditVT_Click(object sender, EventArgs e)
        {
            unlock();
            flag = "edit";
        }
        public bool check()
        {
            if (string.IsNullOrEmpty(txtMaVT.Text))
            {
                MessageBox.Show("Chưa nhập mã vị trí", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaVT.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTenVT.Text))
            {
                MessageBox.Show("Chưa nhập tên vị trí", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenVT.Focus();
                return false;
            }
            return true;
        }
        public bool check1(string mavt)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM dbo.VITRICONGVIEC";
            adapter.SelectCommand = command;
            int k = 0;
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                if (mavt == tb.Rows[i].ItemArray[0].ToString().Trim())
                {
                    k++;
                    break;
                }
            }
            connection.Close();
            if (k > 0)
            {
                MessageBox.Show("Mã vị trí đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaVT.Focus();
                return false;
            }
            else return true;
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (flag == "add")
            {
                if (check() && check1(txtMaVT.Text))
                {
                    connection.Open();
                    command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO dbo.VITRICONGVIEC (MaVT,TenVT) VALUES ('"+txtMaVT.Text+"',N'"+txtTenVT.Text+"')";
                    command.ExecuteNonQuery();
                    connection.Close();
                    hienthi();
                    this.btn_EditVT.Enabled = true;
                }
            }
            else if(flag=="edit")
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "UPDATE dbo.VITRICONGVIEC SET TenVT = N'"+txtTenVT.Text+"' WHERE MaVT = '"+txtMaVT.Text+"'";
                command.ExecuteNonQuery();
                connection.Close();
                hienthi();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgVT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lockcontrol();
            int i;
            i = dgVT.CurrentRow.Index;
            if (i >= 0)
            {

                var r = dgVT.Rows[i].Cells["Mã vị trí"].Value.ToString();
                if (!string.IsNullOrEmpty(r))
                {
                    txtMaVT.Text = dgVT.Rows[i].Cells[0].Value.ToString();
                    txtTenVT.Text = dgVT.Rows[i].Cells[1].Value.ToString();
                    this.btn_EditVT.Enabled = true;
                }
                else
                {
                    this.btn_EditVT.Enabled = false;
                }
            }
        }
    }
}
