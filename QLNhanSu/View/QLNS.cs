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
    public partial class QLNS : Form
    {
        public QLNS()
        {
            InitializeComponent();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinTaiKhoan tttk = new ThongTinTaiKhoan();
            tttk.TopLevel = false;
            panel1.Controls.Add(tttk);
            tttk.Show();
        }

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinNhanVien ttnv = new ThongTinNhanVien();
            ttnv.TopLevel = false;
            panel1.Controls.Add(ttnv);
            ttnv.Show();
        }

        private void lọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimKiemNhanVien tknv = new TimKiemNhanVien();
            tknv.TopLevel = false;
            panel1.Controls.Add(tknv);
            tknv.Show();
        }

        private void dânTộcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanToc dt = new DanToc();
            dt.TopLevel = false;
            panel1.Controls.Add(dt);
            dt.Show();
        }

        private void tônGiáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TonGiao tg = new TonGiao();
            tg.TopLevel = false;
            panel1.Controls.Add(tg);
            tg.Show();
        }

        private void trìnhĐộHọcVấnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrinhDoHocVan tdhv = new TrinhDoHocVan();
            tdhv.TopLevel = false;
            panel1.Controls.Add(tdhv);
            tdhv.Show();
        }

        private void trìnhĐộTiếngAnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrinhDoTiengAnh tdta = new TrinhDoTiengAnh();
            tdta.TopLevel = false;
            panel1.Controls.Add(tdta);
            tdta.Show();
        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhongBan pb = new PhongBan();
            pb.TopLevel = false;
            panel1.Controls.Add(pb);
            pb.Show();
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChucVu cv = new ChucVu();
            cv.TopLevel = false;
            panel1.Controls.Add(cv);
            cv.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help h = new Help();
            h.ShowDialog();
        }
    }
}
