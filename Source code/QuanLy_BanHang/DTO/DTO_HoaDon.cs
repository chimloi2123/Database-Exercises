using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HoaDon
    {
        public string MaHD { get; set; }
        public string MaKH { get; set; }
        public DateTime NGAYLAP { get; set; }
        public string TONGTIEN { get; set; }
        public DTO_HoaDon()
        {
            MaHD = "";
            MaKH = "";
            
            TONGTIEN = "";
        }
        public DTO_HoaDon(string MaHD1,string MaKH1, DateTime NGAYLAP1,  string TONGTIEN1)
        {
            MaHD = MaHD1;
            MaKH = MaKH1;
            NGAYLAP = NGAYLAP1;
            TONGTIEN = TONGTIEN1;
        }
    }
}
