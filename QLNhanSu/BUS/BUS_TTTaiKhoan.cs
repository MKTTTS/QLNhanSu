using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_TTTaiKhoan
    {
        private static BUS_TTTaiKhoan instance;

        public static BUS_TTTaiKhoan Instance
        {
            get { if (instance == null) instance = new BUS_TTTaiKhoan(); return instance; }
            private set { instance = value; }
        }

        private BUS_TTTaiKhoan() { }

        public DataTable LoadThongTinTaiKhoan(string MaNV)
        {
            return DAO.DataProvider.GetDataTable("SP_LoadThongTinNhanVien", CommandType.StoredProcedure, new string[] { "@MaNV" }, new object[] { MaNV });
        }
    }
}
