using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhongBan 
    {
        String MaPB;
        String TenPB;
        String MaTP;
        String TenTP;
        string DiaChi;
        public String MAPB
        {
            get { return MaPB; }
            set { MaPB = value; }
        }
        public String TENPB
        {
            get { return TenPB; }
            set { TenPB = value; }
        }
        public String MATP
        {
            get { return MaTP; }
            set { MaTP = value; }
        }
        public String TENTP
        {
            get { return TenTP; }
            set { TenTP = value; }
        }
        public String DIACHI
        {
            get { return DiaChi; }
            set { DiaChi = value; }
        }
        public PhongBan(string mapb, string tenpb, string matp, string tentp,string diachi)
        {
            this.MAPB = mapb;
            this.TENPB = tenpb;
            this.MATP = matp;
            this.TENTP = tentp;
            this.DIACHI = diachi;
        }

    }
}
