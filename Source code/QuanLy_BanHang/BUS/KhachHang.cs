using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class KhachHang
    {
        public static List<DTO_KhachHang> getDSKhachHangTheoMa(string maKH)
        {
            return DB_KhachHang.getDSKhachHangTheoMa(maKH);
        }
    }
}
