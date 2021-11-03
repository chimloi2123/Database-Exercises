using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class CTHoaDon
    {
        public static List<DTO_CTHoaDon> GetDSCTHoaDon(string maHD)
        {
            return DB_CTHoaDon.GetDSCTHoaDon(maHD);
        }
        public static void TaoCTHoaDon(string maHD, string maSP, int soLuong, float giaBan,float giaGiam)
        {
             DB_CTHoaDon.TaoCTHoaDon(maHD, maSP, soLuong, giaBan,giaGiam);
        }


    }
}
