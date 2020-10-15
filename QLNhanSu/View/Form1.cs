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
    public partial class Form1 : Form
    {
        public static string current_user_id = "NV00000001";

        public Form1()
        {
            InitializeComponent();
            hideSubMenu();
        }

        private void hideSubMenu()
        {
            panelQuanLySubMenu.Visible = false;
            panelDanhMucSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            showSubMenu(panelQuanLySubMenu);
        }
        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDanhMucSubMenu);
        }



        #region QuanLyNhanVienSubMenu
        private void btnThongTinNhanVien_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            hideSubMenu();
               TimKiemNhanVien tknv = new TimKiemNhanVien();
               openChildForm(tknv);
        }
        #endregion


        #region DanhMucSubMenu

        private void btnDanToc_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnTonGiao_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnTrinhDoHocVan_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnChucVu_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }



        #endregion

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new ThongTinTaiKhoan());
        }
        #region ToolsSubMenu


        #endregion



        private void btnHelp_Click(object sender, EventArgs e)
        {

            hideSubMenu();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private Form activeForm = null;



        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


    }
}
