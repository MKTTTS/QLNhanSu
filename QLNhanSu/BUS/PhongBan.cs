using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using DAO;

namespace BUS
{
    public class PhongBan
    {
        private static PhongBan instance;

        public static PhongBan Instance
        {
            get { if (instance == null) instance = new PhongBan(); return instance; }
            private set { instance = value; }
        }

        private PhongBan() { }

        public DataTable Load()
        {
            return DataProvider.GetDataTable("Load",CommandType.StoredProcedure);
        }

        public bool ThemPB(string mapb, string tenpb, string diachi ) 
        {
            return DataProvider.ExecuteNonQuery("ThemPB", CommandType.StoredProcedure, new string[] { "@MaPB", "@TenPB", "@DiaChi" },
                new object[] { mapb, tenpb, diachi });
        }
        public bool SuaPB(string mapb, string tenpb, string diachi)
        {
            return DataProvider.ExecuteNonQuery("Sua", CommandType.StoredProcedure, new string[] { "@MaPB", "@TenPB", "@DiaChi" },
                new object[] { mapb, tenpb, diachi });
        }
    }
}
