using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class SanPham
    {
        public static List<DTO_SanPham> getDSSanPham()
        {
            return DB_SanPham.getDSSanPham();
        }
    }
}
