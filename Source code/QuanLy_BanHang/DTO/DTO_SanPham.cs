using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SanPham
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public int SL { get; set; }
        public string MoTa { get; set; }
        public int Gia { get; set; }
        public DTO_SanPham(string MaSP1, string TenSP1,int SL1, string MoTa1, int Gia1)
        {
            MaSP = MaSP1;
            TenSP = TenSP1;
            SL = SL1;
            MoTa = MoTa1;
            Gia = Gia1;
        }
    }
}
