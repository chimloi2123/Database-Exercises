using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class HoaDon
    {
        public static List<DTO_HoaDon> getDSHoaDon()
        {
            return DB_HoaDon.getDSHoaDon();
        }
        public static List<DTO_HoaDon> getDSHoaDonTheoMa(string maHD)
        {
            return DB_HoaDon.getDSHoaDonTheoMa(maHD);
        }
        public static void TaoHD(string maHD, string maKH, DateTime NgayLap)
        {
             DB_HoaDon.TaoHD(maHD, maKH, NgayLap);
        }
    }
}
