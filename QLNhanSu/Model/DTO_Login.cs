using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Login
    {
        public string MaNV { get; set; }
        public string TenDN { get; set; }
        public string MatKhau { get; set; }
        public DTO_Login(string MaNV, string TenDN, string MatKhau)
        {
            this.MaNV = MaNV;
            this.TenDN = TenDN;
            this.MatKhau = MatKhau;
        }
    }
}
