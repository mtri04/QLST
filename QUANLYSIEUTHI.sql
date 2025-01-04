create database Quanlysieuthi
Go
USE [Quanlysieuthi]
GO

-- Tạo bảng nhân viên
CREATE TABLE [dbo].[nhanvien](
    [manv] [nvarchar](50) NOT NULL PRIMARY KEY,
    [email] [nvarchar](50) NULL,
	[sdt] [nvarchar](50) NULL,
	[avatar] [nvarchar](150) NULL,
    [fullname] [nvarchar](50) NULL
)

-- Tạo bảng tài khoản
CREATE TABLE [dbo].[taikhoan](
    [manv] [nvarchar](50) NOT NULL PRIMARY KEY, 
    [user] [nvarchar](50) NOT NULL UNIQUE, -- Thêm ràng buộc UNIQUE cho cột user
    [password] [nvarchar](50) NULL,
    [datecreate] [date] NULL, -- Thay đổi kiểu dữ liệu thành date
    [isAdmin] [bit] NULL, -- Thay đổi kiểu dữ liệu thành bit (0/1)
    CONSTRAINT [FK_taikhoan_nhanvien] FOREIGN KEY ([manv]) REFERENCES [dbo].[nhanvien]([manv])
)

-- Tạo bảng nhà cung cấp
CREATE TABLE [dbo].[nhacungcap](
    [mancc] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [tenncc] [nvarchar](50) NULL,
    [diachi] [nvarchar](50) NULL,
    [sdt] [nvarchar](50) NULL,
    [email] [nvarchar](50) NULL,
	[avatar] [nvarchar](150) NULL
)
-- Tạo bảng sản phẩm
CREATE TABLE [dbo].[sanpham](
    [masp] [nvarchar](50) NOT NULL PRIMARY KEY, 
    [tensp] [nvarchar](50) NULL,
    [mancc] [int] NULL,
    [gianhap] [int],
    [giaban] [int],
    [solg] [int] NULL,
    [hsd] [date] NULL,
    [noisx] [nvarchar](50) NOT NULL,
    [manv] [nvarchar](50) NOT NULL,
	[avatar] [nvarchar](150) NULL,
	[ngaynhap] [date] NOT NULL,
	CONSTRAINT [FK_sanpham_nhanvien] FOREIGN KEY ([manv]) REFERENCES [dbo].[nhanvien]([manv]) ON DELETE CASCADE,
	CONSTRAINT [FK_sanpham_nhacungcap] FOREIGN KEY ([mancc]) REFERENCES [dbo].[nhacungcap]([mancc]) ON DELETE SET NULL
)

CREATE TABLE [dbo].[hoadon](
    [madh] [nvarchar](50) NOT NULL PRIMARY KEY, 
    [tenkh] [nvarchar](100) NULL,
    [sdt] [nvarchar](20) NULL,
    [diachi] [nvarchar](200) NULL,
    [ngaymua] date NULL,	
    [manv] [nvarchar](50) NULL, -- Mã nhân viên bán hàng
    CONSTRAINT [FK_hoadon_nhanvien] FOREIGN KEY ([manv]) REFERENCES [dbo].[nhanvien]([manv])
)
-- Tạo bảng chi tiết đơn hàng
CREATE TABLE [dbo].[chitiethoadon](
    [madh] [nvarchar](50) NOT NULL,
    [masp] [nvarchar](50) NOT NULL,
    [soluong] int,
    [dongia] decimal(18,2),
    CONSTRAINT [PK_chitiethoadon] PRIMARY KEY ([madh], [masp]),
    CONSTRAINT [FK_chitiethoadon_hoadon] FOREIGN KEY ([madh]) REFERENCES [dbo].[hoadon]([madh]),
    CONSTRAINT [FK_chitiethoadon_sanpham] FOREIGN KEY ([masp]) REFERENCES [dbo].[sanpham]([masp])
)

-- Chèn dữ liệu vào bảng nhanvien
INSERT INTO nhanvien (manv, email, sdt, fullname, avatar)
VALUES
    ('NV001', N'nguyenvanA@gmail.com', '0912345678', N'Nguyễn Văn A', N''),
    ('NV002', N'tranthib@gmail.com', '0987654321', N'Trần Thị B', N''),
    ('NV003', N'nguyenvanC@gmail.com', '0123456789', N'Nguyễn Văn C', N'');
INSERT INTO nhanvien (manv, email, sdt, fullname, avatar)
VALUES
    ('NV004', N'phamthid@gmail.com', '0901234567', N'Phạm Thị D', N''),
    ('NV005', N'lethie@gmail.com', '0912345678', N'Lê Thị E', N''),
    ('NV006', N'vuquangf@gmail.com', '0987654321', N'Vũ Quang F', N'');
-- Chèn dữ liệu vào bảng taikhoan
INSERT INTO taikhoan (manv, [user], password, datecreate, isAdmin)
VALUES
    ('NV001', N'admin', N'123', '2023-11-24', 1),
    ('NV002', N'user1', N'123', '2023-12-01', 0),
    ('NV003', N'user2', N'234', '2023-12-05', 0);

-- Chèn dữ liệu vào bảng nhacungcap
INSERT INTO nhacungcap (tenncc, diachi, sdt, email, avatar)
VALUES
    (N'Công ty A', N'Hà Nội', '0912345678', 'congtyA@gmail.com', N''),
    (N'Công ty B', N'Hồ Chí Minh', '0987654321', 'congtyB@gmail.com', N''),
    (N'Công ty C', N'Đà Nẵng', '0123456789', 'congtyC@gmail.com', N''),
	(N'Tập đoàn Vingroup', N'Hà Nội', '02439749999', 'vincommerce@vingroup.net', N''),
    (N'Saigon Co.op', N'Hồ Chí Minh', '02838214744', 'info@saigoncoop.com.vn', N''),
    (N'Tập đoàn TH', N'Nghệ An', '02383601010', 'info@thmilk.vn', N''),
	(N'CJ Group', N'Hàn Quốc', '0082222716114', 'global@cj.net', N''),
    (N'Aeon Group', N'Nhật Bản', '00818187782310', 'contact@aeon.info', N''),
    (N'Masan Group', N'Hồ Chí Minh', '02862658888', 'masangroup@masan.vn', N''),
    (N'Walmart', N'Mỹ', '18009256278', 'support@walmart.com', N''),
    (N'Woolworths', N'Úc', '00118006582260', 'customerservice@woolworths.com.au', N''),
    (N'Ahold Delhaize', N'Hà Lan', '00817178910400', 'info@aholddelhaize.com', N''),
    (N'CP Group', N'Thái Lan', '00862216613000', 'info@cpgroupglobal.com', N''),
    (N'Carrefour', N'Pháp', '0033178306011', 'contact@carrefour.com', N''),
    (N'Lidl', N'Đức', '00493612693470', 'service@lidl.com', N''),
    (N'Loblaw Companies', N'Canada', '0018884955111', 'customer@loblaw.ca', N''),
    (N'Mercadona', N'Tây Ban Nha', '0034960329090', 'atencionalcliente@mercadona.es', N''),
    (N'Coop Italia', N'Ý', '0039051303400', 'info@coopitalia.coop', N''),
    (N'Magnit', N'Nga', '0078612222220', 'support@magnit.ru', N''),
    (N'Alibaba Group', N'Trung Quốc', '00865717195118', 'support@alibaba.com', N''),
    (N'Reliance Retail', N'Ấn Độ', '00911233022519', 'contact@relianceretail.com', N''),
    (N'PT Indomarco', N'Indonesia', '00622169000000', 'info@indomaret.co.id', N''),
    (N'NTUC FairPrice', N'Singapore', '006567132235', 'info@fairprice.com.sg', N''),
    (N'Mydin', N'Malaysia', '0060360608888', 'mydin@mydin.com.my', N''),
    (N'SM Supermalls', N'Philippines', '0063256677777', 'contact@smsupermalls.com', N''),
    (N'Migros', N'Thụy Sĩ', '0041585733030', 'servicecenter@migros.ch', N''),
    (N'Jerónimo Martins', N'Bồ Đào Nha', '00351213471000', 'info@jeronimomartins.com', N'');

-- Chèn dữ liệu vào bảng sanpham
INSERT INTO sanpham (masp, tensp, mancc, gianhap, giaban, solg, hsd, noisx, manv, avatar, ngaynhap)
VALUES
    ('SP001', N'Điện thoại iPhone 15', 1, 15000000, 18000000, 100, '2024-12-31', N'Trung Quốc', 'NV001', N'', '2023-12-01'),
    ('SP002', N'Laptop Dell XPS', 2, 20000000, 25000000, 50, '2024-11-30', N'Mỹ', 'NV001', N'', '2023-11-15'),
    ('SP003', N'Bàn phím cơ', 3, 500000, 700000, 100, '2024-12-31', N'Đài Loan', 'NV002', N'', '2023-10-10'),
    ('SP004', N'Chuột không dây', 2, 300000, 400000, 200, '2024-12-31', N'Trung Quốc', 'NV003', N'', '2023-12-05'),
    ('SP005', N'Tivi Samsung 4K', 4, 12000000, 15000000, 30, '2025-06-30', N'Hàn Quốc', 'NV002', N'', '2023-09-25'),
    ('SP006', N'Tủ lạnh Panasonic', 5, 8000000, 9500000, 20, '2025-12-31', N'Nhật Bản', 'NV004', N'', '2023-08-18'),
    ('SP007', N'Máy giặt LG', 4, 7000000, 8500000, 15, '2025-05-31', N'Hàn Quốc', 'NV001', N'', '2023-11-20'),
    ('SP008', N'Nồi cơm điện Sharp', 5, 1500000, 2000000, 100, '2025-12-31', N'Nhật Bản', 'NV005', N'', '2023-07-10'),
    ('SP009', N'Quạt điện Senko', 6, 500000, 600000, 200, '2024-07-31', N'Việt Nam', 'NV002', N'', '2023-06-15'),
    ('SP010', N'Máy điều hòa Daikin', 7, 12000000, 14000000, 25, '2025-09-30', N'Nhật Bản', 'NV006', N'', '2023-08-25'),
    ('SP011', N'Bột giặt OMO', 8, 80000, 100000, 300, '2026-03-31', N'Việt Nam', 'NV003', N'', '2023-10-01'),
    ('SP012', N'Dầu gội Sunsilk', 9, 50000, 70000, 500, '2026-01-31', N'Việt Nam', 'NV004', N'', '2023-09-10'),
    ('SP013', N'Sữa tươi Vinamilk', 10, 15000, 20000, 1000, '2024-12-15', N'Việt Nam', 'NV005', N'', '2023-08-05'),
    ('SP014', N'Nước ngọt Coca-Cola', 11, 8000, 12000, 1000, '2025-01-31', N'Mỹ', 'NV001', N'', '2023-07-15'),
    ('SP015', N'Snack Poca', 12, 10000, 15000, 700, '2024-10-31', N'Việt Nam', 'NV002', N'', '2023-08-20'),
    ('SP016', N'Trứng gà sạch', 13, 3000, 5000, 500, '2024-01-07', N'Việt Nam', 'NV006', N'', '2023-07-01'),
    ('SP017', N'Thịt bò Úc', 14, 250000, 300000, 50, '2024-01-05', N'Úc', 'NV003', N'', '2023-09-05'),
    ('SP018', N'Rau sạch Đà Lạt', 15, 20000, 30000, 200, '2024-01-10', N'Việt Nam', 'NV004', N'', '2023-08-12'),
    ('SP019', N'Bánh mì gối', 16, 15000, 25000, 150, '2024-01-03', N'Việt Nam', 'NV005', N'', '2023-11-30'),
    ('SP020', N'Kem đánh răng P/S', 17, 20000, 35000, 400, '2026-05-31', N'Việt Nam', 'NV001', N'', '2023-10-10'),
    ('SP021', N'Mì gói Hảo Hảo', 18, 3000, 5000, 2000, '2025-12-31', N'Việt Nam', 'NV002', N'', '2023-09-25'),
    ('SP022', N'Cafe Trung Nguyên', 19, 50000, 70000, 500, '2026-02-28', N'Việt Nam', 'NV003', N'', '2023-12-01'),
    ('SP023', N'Dầu ăn Tường An', 20, 40000, 60000, 300, '2026-06-30', N'Việt Nam', 'NV004', N'', '2023-08-01'),
    ('SP024', N'Nước mắm Nam Ngư', 21, 20000, 30000, 400, '2026-04-30', N'Việt Nam', 'NV005', N'', '2023-09-10'),
    ('SP025', N'Phở bò VIFON', 18, 10000, 15000, 1000, '2025-11-30', N'Việt Nam', 'NV006', N'', '2023-10-05'),
    ('SP026', N'Sữa chua Vinamilk', 10, 5000, 8000, 1500, '2024-12-20', N'Việt Nam', 'NV002', N'', '2023-11-10'),
    ('SP027', N'Trứng vịt muối', 13, 4000, 7000, 300, '2024-02-15', N'Việt Nam', 'NV003', N'', '2023-12-20'),
    ('SP028', N'Kem Wall"s', 22, 10000, 15000, 500, '2025-08-31', N'Thái Lan', 'NV004', N'', '2023-11-25'),
    ('SP029', N'Bánh trung thu Kinh Đô', 23, 40000, 60000, 100, '2024-09-15', N'Việt Nam', 'NV005', N'', '2023-09-15'),
    ('SP030', N'Bia Heineken', 24, 15000, 20000, 1000, '2025-12-31', N'Hà Lan', 'NV001', N'', '2023-11-01');


INSERT INTO [dbo].[hoadon] ([madh], [tenkh], [sdt], [diachi], [ngaymua], [manv]) 
VALUES


INSERT INTO [dbo].[chitiethoadon] ([madh], [masp], [soluong], [dongia]) 
VALUES



CREATE PROCEDURE GetHoaDonDetails
    @MaHD NVARCHAR(50)
AS
BEGIN
    SELECT 
        hd.madh AS MaHD,
        hd.tenkh AS TenKH,
        hd.diachi AS DiaChi,
        hd.sdt AS SDT,
        hd.ngaymua AS NgayMua,
        hd.manv AS MaNV,
        sp.masp AS MaSP,
        sp.tensp AS TenSP,
        sp.giaban AS GiaBan,
        cthd.soluong AS SoLuong,
        cthd.dongia AS DonGia,
        SUM(cthd.dongia) OVER (PARTITION BY hd.madh) AS TongTien
    FROM 
        hoadon hd
    INNER JOIN 
        chitiethoadon cthd ON hd.madh = cthd.madh
    INNER JOIN 
        sanpham sp ON cthd.masp = sp.masp
    WHERE 
        hd.madh = @MaHD;
END;
GO


EXEC GetHoaDonDetails @MaHD = 'HD001';
