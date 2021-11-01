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
        public DateTime NgayLap { get; set; }
        public float TongTien { get; set; }
        public DTO_HoaDon(string MaHD1,string MaKH1, DateTime NgayLap1, float TongTien1)
        {
            MaHD = MaHD1;
            MaKH = MaKH1;
            NgayLap = NgayLap1;
            TongTien = TongTien1;
        }
    }
}
