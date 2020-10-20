using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new ChucVu());

            //Application.Run(new TimKiemNhanVien());
       }
=======

            Application.Run(new Form1());

        }
>>>>>>> c95d78b069871e04488717b5285bd8534b2afc27
    }
}
