using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    class TimKiem
    {
        private static TimKiem instance;
        public static TimKiem Instance {
            get
            {
                if (instance == null)
                    instance = new TimKiem();
                return TimKiem.instance;
            }
            private set
            {
                TimKiem.instance = value;
            }
        }
        public bool Search(string ten)
        {
            string query = string.Format("select MaPB,TenPB, MaTP, TenTP from PHONGBAN where MaPB like N'%{0}%'", ten);
            DataTable results = DataProvider.Instance.ExecuteQuery(query);
            return results.Rows.Count > 0;
        }
    }
}
