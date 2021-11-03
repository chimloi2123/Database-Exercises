use QuanLyHoaDon

--a. Select * from A join B join C on.... Và Select * from A,B,C where A.x = B.x....

		Select *
		From HOADON hd, CT_HOADON ct, KHACHHANG kh
		Where hd.MAHD = ct.MAHD and kh.MAKH = hd.MAKH

		Select *
		From CT_HOADON join HOADON join KHACHHANG
		on KHACHHANG.MAKH = HOADON.MAKH
		on CT_HOADON.MAHD = HOADON.MAHD


--b. Select * from A jọin B (A có số dòng nhỏ, B rất lớn) và Select * from B join A

		select * From SANPHAM join CT_HOADON on SANPHAM.MASP = CT_HOADON.MASP

		select * From CT_HOADON join SANPHAM on SANPHAM.MASP = CT_HOADON.MASP

		GO
		CREATE NONCLUSTERED INDEX [<Name of Missing Index, sysname,>]
		ON [dbo].[CT_HOADON] ([MASP])
		INCLUDE ([SOLUONG],[GIABAN],[GIAGIAM],[THANHTIEN])
		GO

		Drop index [<Name of Missing Index, sysname,>] on CT_HOADON