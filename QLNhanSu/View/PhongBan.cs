using DAO;
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
using System.Configuration;

namespace View
{
    public partial class PhongBan : Form
    {
        string connectionString = @"Data Source=DESKTOP-DO7Q21E\SQLEXPRESS;Initial Catalog=QuanLyNhanSu;Integrated Security=True";
        public PhongBan()
        {
            InitializeComponent();
            button1.Hide();
            button2.Hide();
        }

        private void PhongBan_Load(object sender, EventArgs e)
        {
            phongBanBindingSource.DataSource =  BUS.PhongBan.Instance.Load();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            mAPBTextBox.Enabled = true;
            mATPTextBox.Enabled = true;
            tENPBTextBox.Enabled = true;
            tENTPTextBox.Enabled = true;
            dIACHITextBox.Enabled = true;
            button1.Show();
        }

        private void mAPBTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool a = BUS.PhongBan.Instance.ThemPB(mAPBTextBox.Text, tENPBTextBox.Text, dIACHITextBox.Text);
            phongBanBindingSource.DataSource = BUS.PhongBan.Instance.Load();
           
            button1.Hide();
            if (a)
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("ThêM không thành công");
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            mAPBTextBox.Enabled = true;
            mATPTextBox.Enabled = true;
            tENPBTextBox.Enabled = true;
            tENTPTextBox.Enabled = true;
            dIACHITextBox.Enabled = true;
            button2.Show();
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool a = BUS.PhongBan.Instance.SuaPB(mAPBTextBox.Text, tENPBTextBox.Text, dIACHITextBox.Text);
            phongBanBindingSource.DataSource = BUS.PhongBan.Instance.Load();
            button2.Hide();
            if (a)
            {
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa không thành công");
            }
        }

    }
}
