Use QuanLyHoaDon

--CÁC TRUY VẤN

--a. Cho danh sách các hoá đơn lập trong năm 2020
	
	Select *
	From HOADON
	Where year(NGAYLAP) = 2020

	Create Index hoadonIndex On HOADON(NGAYLAP)

Drop Index hoadonIndex On HOADON

--b. Cho danh sách các khách hàng ở TPHCM

	Select *
	From KHACHHANG
	Where TPHO = 'TPHCM'

	Create Index hkIndex On KHACHHANG(TPHO)

Drop Index hkIndex On KHACHHANG

	GO
	CREATE NONCLUSTERED INDEX [<Name of Missing Index, sysname,>]
	ON [dbo].[KHACHHANG] ([TPHO])
	INCLUDE ([HO],[TEN],[NGSINH],[DUONG],[QUAN],[DTHOAI])
	GO

Drop Index [<Name of Missing Index, sysname,>] On KHACHHANG

--c. Cho danh sách các sản phẩm có giá trong một khoảng từ....đến

	Select *
	From SANPHAM
	Where GIA Between 100000 And 500000

	Create Index spIndex On SANPHAM(GIA)

Drop Index spIndex On SANPHAM

--d. Cho danh sách các sản phẩm có số lượng tồn < 100

		Select *
		From SANPHAM
		Where SL < 100

	Create Index sp2Index On SANPHAM(SL)

Drop Index sp2Index On SANPHAM

--e. Cho danh sách các sản phẩm bán chạy nhất (số lượng bán nhiều nhất)

--C0:

	Select sp.MASP, sp.TENSP, sp.SL, sp.MOTA, sp.GIA, SUM(SOLUONG) As N'Số lượng bán'
	From CT_HOADON ct, SANPHAM sp
	Where ct.MASP = sp.MASP
	Group by sp.MASP, sp.TENSP, sp.SL, sp.MOTA, sp.GIA
	Having SUM(ct.SOLUONG) >= ALL ( Select SUM(SOLUONG)
									From CT_HOADON
									Group by MASP
								  )

--C1:

	Select * From SANPHAM Where MASP IN (Select MASP
										 From CT_HOADON
										 Group by MASP
										 Having SUM(SOLUONG) >= ALL (Select SUM(SOLUONG)
																	 From CT_HOADON
																	 Group by MASP)
										)

	Create Index sp3Index On SANPHAM(MASP)

	Create Index ctIndex On CT_HOADON(MASP, SOLUONG)

Drop Index sp3Index On SANPHAM

Drop Index ctIndex On CT_HOADON

--C2:

	Select * From SANPHAM Where MASP IN (Select ct.MASP
										 From CT_HOADON ct
										 Group by ct.MASP
										 Having NOT EXISTS (Select ct2.MASP
															From CT_HOADON ct2 
															Group by ct2.MASP 
															Having SUM(ct2.SOLUONG) > SUM(ct.SOLUONG))
										)

--f. Cho danh sách các sản phẩm có doanh thu cao nhất

--C1:

	Select * From SANPHAM Where MASP IN (Select MASP
										 From CT_HOADON
										 Group by MASP
										 Having SUM(THANHTIEN) >= ALL (Select SUM(THANHTIEN) From CT_HOADON Group by MASP)
										 )

	Create Index sp4Index On SANPHAM(MASP)

	Create Index ct1Index On CT_HOADON(MASP, SOLUONG)

Drop Index sp4Index On SANPHAM

Drop Index ct1Index On CT_HOADON

--C2:

	Select * From SANPHAM Where MASP IN (Select ct.MASP
										 From CT_HOADON ct
										 Group by ct.MASP
										 Having NOT EXISTS (Select ct2.MASP 
															From CT_HOADON ct2 
															Group by ct2.MASP 
															Having SUM(ct2.THANHTIEN) > SUM(ct.THANHTIEN))
															)