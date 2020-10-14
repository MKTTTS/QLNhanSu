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

        public bool DoiMatKhau(string id, string MKCu, string MKMoi)
        {
            return DAO.DataProvider.ExecuteNonQuery("SP_DoiMatKhau", CommandType.StoredProcedure, new string[] { "@id", "@MKCu", "@MKMoi" }, new object[] { id, MKCu, MKMoi });
        }
        public bool DoiThongTinCaNhan(string id, string HoTen,string GioiTinh, DateTime NgaySinh, string CMTND, string DanToc, string TonGiao, string DiaChi, string SDT, string BangCap)
        {
            return DAO.DataProvider.ExecuteNonQuery("SP_DoiTTCaNhan", CommandType.StoredProcedure,
                    new string[] { "@id", "@HoTen", "@GioiTinh", "@NgaySinh", "@CMTND", "@DanToc", "@TonGiao", "@DiaChi", "@SDT", "@BangCap" },
                    new object[] { id, HoTen, GioiTinh, NgaySinh, CMTND, DanToc, TonGiao, DiaChi, SDT, BangCap });
        }
    }
}
