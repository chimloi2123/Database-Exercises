using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhachHang
    {
        public string MaKH { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public DateTime NgSinh { get; set; }
        public string Duong { get; set; }
        public string Quan { get; set; }
        public string TPho { get; set; }
        public string DThoai { get; set; }
        public DTO_KhachHang(string maKH1, string Ho1, string Ten1, string DThoai1, string Duong1, DateTime NgSinh1, string Quan1, string TPho1)
        {
            MaKH = maKH1;
            Ho = Ho1;
            Ten = Ten1;
            DThoai = DThoai1;
            Duong = Duong1;
            NgSinh = NgSinh1;
            Quan = Quan1;
            TPho = TPho1;
        }
        public DTO_KhachHang()
        {
            MaKH = "";
            Ho = "";
            Ten = "";
            DThoai = "";
            Duong = "";
           
            Quan = "";
            TPho = "";
        }

    }
}
