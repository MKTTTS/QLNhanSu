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
    public class BUS_ChucVu
    {
        private static BUS_ChucVu instance;

        public static BUS_ChucVu Instance
        {
            get { if (instance == null) instance = new BUS_ChucVu(); return instance; }
            private set { instance = value; }
        }

        private BUS_ChucVu() { }

        public bool ThemChucVu(string MaCV, string TenCV)
        {
            return DataProvider.ExecuteNonQuery("sp_insCHUCVU", CommandType.StoredProcedure, new string[] { "@MaCV", "@TenCV" }, new object[] { MaCV, TenCV });
        }

        public bool SuaChucVu(string MaCV, string TenCV)
        {
            return DataProvider.ExecuteNonQuery("sp_updateCV", CommandType.StoredProcedure, new string[] { "@MaCV", "@TenCV" }, new object[] { MaCV, TenCV });
        }

    }
}
