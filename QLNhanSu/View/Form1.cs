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
        private string MaNV;
        private int Level;

        public Form1(string mnv)
        {
            this.MaNV = mnv;
            List<CustomerParameter> lst = new List<CustomerParameter>();
            lst.Add(new CustomerParameter() { key = "@manhanvien", value = mnv });
            var r = new DatabaseNV().SelectData("LEVELDANGNHAP", lst);
            this.Level = Convert.ToInt32(r.Rows[0]["Level"].ToString());
            InitializeComponent();
            hideSubMenu();
        }
        public string GETMANV()
        {
            return this.MaNV;
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
            FormThongTinNhanVien ttnv = new FormThongTinNhanVien(this.Level);
            ttnv.TopLevel = false;
            panelChildForm.Controls.Add(ttnv);
            //ttnv.Show();
            openChildForm(ttnv);

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            hideSubMenu();
               TimKiemNhanVien tknv = new TimKiemNhanVien();
            tknv.TopLevel = false;
            openChildForm(tknv);
        }
        #endregion


        #region DanhMucSubMenu

        

        private void btnTrinhDoHocVan_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Vitri vt = new Vitri(this.Level);
            vt.TopLevel = false;
            openChildForm(vt);
        }

        private void btnPhongBan_Click(object sender, EventArgs e)
        {

            hideSubMenu();
            PhongBan pb = new PhongBan(this.Level);
            pb.TopLevel = false;
            openChildForm(pb);
        }

        private void btnChucVu_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ChucVu cv = new ChucVu(this.Level);
            cv.TopLevel = false;
            openChildForm(cv);
        }



        #endregion

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new ThongTinTaiKhoan(this.MaNV));
        }
        #region ToolsSubMenu


        #endregion



        private void btnHelp_Click(object sender, EventArgs e)
        {

            hideSubMenu();
            Help hp = new Help();
            hp.TopLevel = false;
            openChildForm(hp);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
