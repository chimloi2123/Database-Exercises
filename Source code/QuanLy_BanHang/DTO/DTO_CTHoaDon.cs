using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class DTO_CTHoaDon
	{
		public string MaHD { get; set; }
		public string MaSP { get; set; }
		public string TenSP { get; set; }
		public int SoLuong { get; set; }
		public float GiaBan { get; set; }
		public float GiaGiam { get; set; }
		public float ThanhTien { get; set; }
		public DTO_CTHoaDon(string MaHD1, string MaSP1,string tenSP1, int SoLuong1,float GiaBan1, float GiaGiam1, float ThanhTien1){
			MaHD = MaHD1;
			MaSP = MaSP1;
			TenSP = tenSP1;
			SoLuong = SoLuong1;
			GiaBan = GiaBan1;
			GiaGiam = GiaGiam1;
			ThanhTien = ThanhTien1;
			}
		public DTO_CTHoaDon()
		{
			MaHD ="";
			MaSP = "";
			TenSP = "";
			SoLuong = 0;
			GiaBan = 0;
			GiaGiam = 0;
			ThanhTien = 0;
		}

	}
}
