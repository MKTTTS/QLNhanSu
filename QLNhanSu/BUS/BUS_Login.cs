using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace BUS
{
    public class BUS_Login
    {
        private static BUS_Login instance;

        public static BUS_Login Instance
        {
            get { if (instance == null) instance = new BUS_Login(); return instance; }
            private set { instance = value; }
        }

        private BUS_Login() { }

        public string CheckLogin(object TenDN, object MatKhau)
        {
            return DataProvider.ExecuteScalar("SP_Login", CommandType.StoredProcedure, new string[] { "@TenDN", "@MatKhau" }, new object[] { TenDN, MatKhau });
        }

    }
}
