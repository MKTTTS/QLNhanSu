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
    public partial class Vitri : Form
    {
        string flag;
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-85J13SR;Initial Catalog=QuanLyNhanSu;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        System.Data.DataTable table = new System.Data.DataTable();
        void hienthi()
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM dbo.VITRICONGVIEC";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgVT.DataSource = table;
            dgVT.ReadOnly = true;
            connection.Close();
        }
        public Vitri()
        {
            InitializeComponent();
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

        private void dgVT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lockcontrol();
            int i;
            i = dgVT.CurrentRow.Index;
            txtMaVT.Text = dgVT.Rows[i].Cells[0].Value.ToString();
            txtTenVT.Text = dgVT.Rows[i].Cells[1].Value.ToString();
        }

        private void btn_AddVT_Click(object sender, EventArgs e)
        {
            unlock();
            txtMaVT.ReadOnly = false;
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
                    command.CommandText = "INSERT INTO dbo.VITRICONGVIEC (MaVT,TenVT) VALUES ('"+txtMaVT.Text+"','"+txtTenVT.Text+"')";
                    command.ExecuteNonQuery();
                    connection.Close();
                    hienthi();
                }
            }
            else if(flag=="edit")
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "UPDATE dbo.VITRICONGVIEC SET TenVT = '"+txtTenVT.Text+"' WHERE MaVT = '"+txtMaVT.Text+"'";
                command.ExecuteNonQuery();
                connection.Close();
                hienthi();
            }
        }
    }
}
