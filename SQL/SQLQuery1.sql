CREATE DATABASE FILESQL
GO
USE FILESQL
GO

CREATE TABLE NHANVIEN(
	MANV CHAR(10) NOT NULL,
	TEN NVARCHAR(50) NOT NULL,
	EMAIL VARCHAR(255) UNIQUE,
	GIOITINH NVARCHAR(10) NOT NULL,
	SDT CHAR(10) UNIQUE NOT NULL,
	NGAYSINH DATE NOT NULL,
	DIACHI NVARCHAR(255) NOT NULL,
	CHUCVU NVARCHAR(50) NOT NULL
)
GO
CREATE TABLE TRUYEN(
	MATRUYEN CHAR(10) NOT NULL,
	MATG CHAR(10) NOT NULL,
	MANV CHAR(10) NOT NULL,
	TENTRUYEN NVARCHAR(50) NOT NULL,
	SOLUONG INT NOT NULL,
	THELOAI NVARCHAR(255) NOT NULL
)
GO
CREATE TABLE TACGIA(
	MATG CHAR(10) NOT NULL,
	TEN NVARCHAR(50) NOT NULL,
	NGAYSINH DATE NOT NULL
)
GO
CREATE TABLE DOCGIA(
	MADG CHAR(10) NOT NULL,
	TEN NVARCHAR(50) NOT NULL,
	NGAYSINH DATE NOT NULL,
	GIOITINH NVARCHAR(10) NOT NULL,
	SDT CHAR(10) UNIQUE NOT NULL,
	EMAIL VARCHAR(255) UNIQUE,
	DIACHI NVARCHAR(255) NOT NULL
)
GO
CREATE TABLE PHIEUMUON(
	MAPHIEUMUON CHAR(10) NOT NULL,
	MANV CHAR(10) NOT NULL,
	MADG CHAR(10) NOT NULL,
	NGAYMUON DATE NOT NULL,
	NGAYTRA DATE NOT NULL,
	TONGSL INT NOT NULL
)
GO
CREATE TABLE DANHSACHMUON(
	MAPHIEUMUON CHAR(10) NOT NULL,
	MATRUYEN CHAR(10) NOT NULL,
	SOLUONG INT NOT NULL
)
GO

-- RANG BUOC KHOA CHINH
ALTER TABLE NHANVIEN
ADD CONSTRAINT PK_NHANVIEN PRIMARY KEY(MANV)

ALTER TABLE TRUYEN
ADD CONSTRAINT PK_TRUYEN PRIMARY KEY(MATRUYEN)

ALTER TABLE TACGIA
ADD CONSTRAINT PK_TACGIA PRIMARY KEY(MATG)

ALTER TABLE DOCGIA
ADD CONSTRAINT PK_DOCGIA PRIMARY KEY(MADG)

ALTER TABLE PHIEUMUON
ADD CONSTRAINT PK_PHIEUMUON PRIMARY KEY(MAPHIEUMUON)

ALTER TABLE DANHSACHMUON
ADD CONSTRAINT PK_DANHSACHMUON PRIMARY KEY(MAPHIEUMUON, MATRUYEN)

-- RANG BUOC KHOA NGOAI
ALTER TABLE TRUYEN
ADD CONSTRAINT FK1_TRUYEN FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV)

ALTER TABLE TRUYEN
ADD CONSTRAINT FK2_TRUYEN FOREIGN KEY(MATG) REFERENCES TACGIA(MATG)

ALTER TABLE PHIEUMUON
ADD CONSTRAINT FK1_PHIEUMUON FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV)

ALTER TABLE PHIEUMUON
ADD CONSTRAINT FK2_PHIEUMUON FOREIGN KEY(MADG) REFERENCES DOCGIA(MADG)

ALTER TABLE DANHSACHMUON
ADD CONSTRAINT FK1_DANHSACHMUON FOREIGN KEY(MAPHIEUMUON) REFERENCES PHIEUMUON(MAPHIEUMUON)

ALTER TABLE DANHSACHMUON
ADD CONSTRAINT FK2_DANHSACHMUON FOREIGN KEY(MATRUYEN) REFERENCES TRUYEN(MATRUYEN)

-- RANG BUOC TOAN VEN
ALTER TABLE TRUYEN
ADD CONSTRAINT RBTV_SOLUONG_TRUYEN CHECK (SOLUONG >=0)

ALTER TABLE DANHSACHMUON
ADD CONSTRAINT RBTV_SOLUONG_DANHSACHMUON CHECK (SOLUONG >0)

GO

-- INSERT
INSERT INTO NHANVIEN 
VALUES
	('BV001', N'Nguyễn Hưng Thịnh',      N'Nguyenhungthinh@gmail.com',     'Nam', '0362126144', '1970-03-18', N'1 đường số 8, phường Tăng Nhơn Phú B, tp.Thủ Đức',                       N'Bảo vệ'),
	('BV002', N'Nguyễn Đình Hoàng Tuấn', N'Nguyendinhhoangtuan@gmail.com', 'Nam', '0358953825', '1975-10-08', N'Đường số 9 Hẻm 96/1- Linh Tây- TP Thủ Đức',					             N'Bảo vệ'),
	('GS001', N'Phạm Thị Ly',			 N'Phamthily@gmail.com',		   'Nữ',  '0394721924', '1997-09-12', N'Số 28, đường 449, phường Tăng Nhơn Phú A, TP. Thủ Đức',		             N'Nhân viên giám sát'),
	('GS002', N'Văn Công Hào',			 N'VanCongHao@gmail.com',		   'Nam', '0397841034', '1995-02-09', N'Đường 385, tăng nhơn phú A, thành phố Thủ Đức',				             N'Giám sát kho'),
	('K001',  N'Nguyễn Thị Vân Khánh',   N'Nguyenthivankhanh@gmail.com',   'Nữ',  '0375650646', '2000-09-02', N'131/10 KP. Tân Hiệp, P. Tân Bình, TP. Dĩ An, tỉnh Bình Dương',           N'Nhân viên kho'),
	('K002',  N'Trần Trọng Nhân',        N'Trantrongnhan@gmail.com',       'Nam', '0359381132', '2000-11-13', N'Số 28, đường 449, phường Tăng Nhơn Phú A, TP. Thủ Đức',		             N'Nhân viên kho'),
	('KP001', N'Trần Tấn Quốc',          N'Trantanquoc@gmail.com',         'Nam', '0332814102', '1999-01-28', N'Đường số 10, nguyễn văn tăng, tăng nhơn phú B, tp Thủ Đức',              N'Nhân viên kiểm phiếu'),
	('NV001', N'Kiều Thị Mộng Hiền',     N'Kieuthimonghien@gmail.com',     'Nữ',  '0348772541', '1999-12-17', N'61/7, đường số 12, phường Tăng Nhơn Phú B, TP Thủ Đức',                  N'Nhân viên trực quầy'),
	('NV002', N'Nguyễn Thị Phương Nga',  N'Nguyenthiphuongnga@gmail.com',  'Nữ',  '0353279583', '1997-11-09', N'30 Nguyễn Trung Nguyệt , Bình Trưng Đông , TP.Thủ Đức',                  N'Nhân viên trực quầy'),
	('NV003', N'Phạm Nguyễn Thùy Dung',  N'Phamnguyenthuydung@gmail.com',  'Nữ',  '0774757976', '1993-08-25', N'110/15/12 Lò Lu Ích Thạnh Trường Thạnh Thành Phố Thủ Đức',               N'Nhân viên trực quầy'),
	('PL001', N'Lê Vũ Long',			 N'Levulong@gmail.com',			   'Nam', '0987029203', '1990-10-04', N'23/23/3 Làng Tăng Phú, Tổ 6, Khu Phố 4, P. Tăng Nhơn Phú A, TP Thủ Đức', N'Phó quản lý'),
	('QL001', N'Trần Đức Anh',			 N'Tranducanh@gmail.com',		   'Nam', '0354855613', '1983-08-14', N'Số 36/17, đường 160, phường Tăng Nhơn Phú A, TP. Thủ Đức',               N'Quản lý'),
	('PT001', N'Nguyễn Hoàng Nam Kha',   N'Nguyenhoangnamkha@gmail.com',   'Nam', '0862624027', '2001-12-07', N'28B đường 106, phường Tăng Nhơn Phú A, TP. Thủ Đức',                     N'Nhân viên Part time'),
	('PT002', N'Mai Danh Dũng',          N'Maidanhdung@gmail.com',         'Nam', '0328657868', '2001-01-19', N'416 Lã Xuân Oai, phường Long Trường, TP.Thủ Đức',                        N'Nhân viên Part time');
GO

INSERT INTO TACGIA 
VALUES
	('TPTG', N'Trần Phan Trúc Giang',	'1964-06-13'), 
	('DN',	 N'Dao Ninh',				'1959-09-10'), 
	('NM',   N'Ngọc My',				'1989-01-24'), 
	('MTS',  N'Mạc Thiên Song',			'1988-11-20'),
	('LTS',  N'Lý Thái Sơn',			'1933-12-01'),
	('M',    N'Mây',					'2001-10-08'),
	('NVA',  N'Nguyễn Vân An',			'2001-05-12'),
	('GA',   N'Gosho Aoyama',			'1964-06-13'),
	('TH',   N'Tô Hoài',				'1920-09-27'),
	('FF',   N'Fujiko Fujio',			'1933-12-01'),
	('NC',   N'Nam Cao',				'1917-10-29'),
	('NQS',  N'Nguyễn Quang Sáng',		'1932-01-12'),
	('DC',   N'Dale Carnegie',			'1988-11-24');
GO

INSERT INTO TRUYEN 
VALUES
	('KUCMT',	'TPTG',	'NV001', N'Khế ước của mợ tư',					24, N'Ngôn tình'),
	('GCCN',	'DN',	'NV001', N'Giá của cái nghèo',					50, N'Ngôn tình'),
	('MM',		'NM',	'NV001', N'Mợ mận',								50, N'Cung đấu'),
	('CTTGMNX',	'MTS',	'NV001', N'Chàng trai trong giấc mơ năm xưa',	59, N'Ngôn tình'),
	('NDAB',	'MTS',	'NV001', N'Nhân duyên an bài',					59, N'Ngôn tình'),
	('KCNN',	'MTS',	'NV001', N'Khoảng cách ngàn năm',				59, N'Xuyên không'),
	('CGDC',	'LTS',	'NV001', N'Con gái địa chủ',					59, N'Hài hước'),
	('CN001',	'GA',	'NV003', N'Thám tử lừng danh Conan tập 1',		27, N'Huyền bí'),
	('CN002',	'GA',	'NV003', N'Thám tử lừng danh Conan tập 2',		39, N'Huyền bí'),
	('CN003',	'GA',	'NV001', N'Thám tử lừng danh Conan tập 3',		25, N'Huyền bí'),
	('CN004',	'GA',	'NV002', N'Thám tử lừng danh Conan tập 4',		24, N'Huyền bí'),
	('CN005',	'GA',	'NV003', N'Thám tử lừng danh Conan tập 5',		35, N'Huyền bí'),
	('CN006',	'GA',	'NV001', N'Thám tử lừng danh Conan tập 6',		44, N'Huyền bí'),
	('CN007',	'GA',	'NV003', N'Thám tử lừng danh Conan tập 7',		49, N'Huyền bí'),
	('CN008',	'GA',	'NV003', N'Thám tử lừng danh Conan tập 8',		35, N'Huyền bí'),
	('CN009',	'GA',	'NV002', N'Thám tử lừng danh Conan tập 9',		23, N'Huyền bí'),
	('CN010',	'GA',	'NV003', N'Thám tử lừng danh Conan tập 10',		24, N'Huyền bí'),
	('CN011',	'GA',	'NV002', N'Thám tử lừng danh Conan tập 11',		39, N'Huyền bí'),
	('CN012',	'GA',	'NV003', N'Thám tử lừng danh Conan tập 12',		25, N'Huyền bí'),
	('CN013',	'GA',	'NV001', N'Thám tử lừng danh Conan tập 13',		33, N'Huyền bí'),
	('CN014',	'GA',	'NV002', N'Thám tử lừng danh Conan tập 14',		34, N'Huyền bí'),
	('NKUKC',	'TH',	'NV001', N'Những ký ức không chịu ngủ yên',		40, N'Tiểu thuyết'),
	('NN',		'TH',	'NV002', N'Nhà nghèo',							23, N'Truyện ngắn'),
	('D',		'FF',	'NV002', N'Doraemon tập 1',						40, N'Kim Đồng'),
	('DD001',	'FF',	'NV003', N'Doraemon truyện dài tập 1',			32, N'Truyện dài'),
	('DN001',	'FF',	'NV002', N'Doraemon truyện ngắn tập 1',			39, N'Truyện ngắn'),
	('DN002',	'FF',	'NV003', N'Doraemon truyện ngắn tập 2',			43, N'Truyện ngắn'),
	('CP',		'NC',	'NV002', N'Chí Phèo',							28, N'Truyện ngắn'),
	('DMPLK',	'NC',	'NV001', N'Dế Mèn Phiêu Lưu Ký',				37, N'Văn xuôi'),
	('LH',		'NC',	'NV001', N'Lão Hạc',							38, N'Truyện ngắn'),
	('DDXC',	'NC',	'NV003', N'Đầu đường xó chợ',					35, N'Truyện ngắn'),
	('BCT',		'NQS',	'NV002', N'Bông cẩm thạch',						19, N'Truyện ngắn'),
	('NVVL',	'NQS',	'NV002', N'Nhà văn về làng',					25, N'Bút ký'),
	('ĐNT',		'DC',	'NV003', N'Đắc Nhân Tâm',						29, N'Tự lực');
GO

INSERT INTO DOCGIA 
VALUES
	('HTKL',	N'Hồ Thị Kiều Linh ',	'2002-01-20', 'Nữ',	 '0987632849', 'Hothikieulinh@gmail.com',	N'Số 28, đường 449, phường Tăng Nhơn Phú A,TP. Thủ Đức'),
	('NHP',		N'Nguyễn Hoàng Phát ',	'2002-09-21', 'Nam', '0817937865', 'Nguyenhoangphat@gmail.com', N'Chung cư SKY9, phường phú hữu, TP. Thủ Đức'),
	('VMT',		N'Vạn Minh Ty  ',		'2000-03-24', 'Nam', '0379020715', 'Vanminhty@gmail.com',		N'Chợ nhỏ nông lâm, TP. Thủ Đức'),
	('TNS',		N'Trần Ngọc Sang  ',	'2001-07-12', 'Nam', '0905102884', 'Tranngocsang@gmail.com',	N'87/6 đường 104,p.tăng nhơn phú A,Tp.Thủ Đức'),
	('LBKT',	N'Lê Bá Khánh Trình  ', '2000-01-02', 'Nam', '0337880587', 'Lebakhanhtrinh@gmail.com',	N'C24/9 đường 449, phường Tăng Nhơn Phú A, TP. Thủ Đức'),
	('TQT',		N'Trần Quang Thắng ',	'1997-01-19', 'Nam', '0342925377', 'Tranquangthang@gmail.com',	N'Hẻm 146 Lã Xuân Oai,P.Tăng Nhơn Phú A,TP.Thủ Đức'),
	('THT',		N'Trần Hoàng Triều ',	'1990-12-05', 'Nam', '0916341320', 'Tranhoangtrieu@gmail.com',	N'87/22/41, Bành Văn Trân,  Phường 7, Tân Bình, TP.HCM.'),
	
	('NCA',		N'Nguyễn Cao An ',		'2003-11-10', 'Nam', '0915579872', 'NguyenCaoAn@gmail.com',		N'7/8 Đường 385, Hiệp Phú, Quận 9, Tp Thủ Đức'),
	('HTM',		N'Huỳnh Tuấn Minh ',	'2005-03-12', 'Nam', '0932047892', 'Huynhtuanminh@gmail.com',	N'7/50 Đường 182, Phường Tăng Nhơn Phú A, TP. Thủ Đức'),
	('NNL',		N'Nguyễn Ngọc Lễ  ',	'2004-07-07', 'Nam', '0337378867', 'Nguyenngocle@gmail.com',	N'64/1 Tân Hòa 2, phường Hiệp Phú, Tp. Thủ Đức'),
	('NTL',		N'Nguyễn Thành Liêm ',	'1999-06-05', 'Nam', '0327780481', 'Nguyenthanhliem@gmail.com', N'65/1 Tân Hòa 2, phường Hiệp Phú, Tp. Thủ Đức'),
	('TTD',		N'Trần Thanh Dương  ',	'2003-08-04', 'Nam', '0901497506', 'Tranthanhduong@gmail.com',	N'107/13/07,đường 11, phường 11, quận Gò Vấp, TPHCM'),
	('CQN',		N'Châu Quế Nhơn',		'2012-10-12', 'Nam', '0848611127', 'Chauquenhon@gmail.com',		N'210/7/7 đường 11, phường Trường Thọ, Tp. Thủ Đức'),
	('LNT',		N'Lưu Nhật Thành',		'2006-11-10', 'Nam', '0393247391', 'Luunhatthanh@gmail.com',	N'25a đường 24, phường Linh Đông, Tp. Thủ Đức');
GO

INSERT INTO PHIEUMUON 
VALUES
	('PM00001','NV001', 'HTKL', '2022- 08- 26',	'2022-10-26', 7),
	('PM00002','NV002', 'NHP',	'2022- 08- 29', '2022-10-29', 5),
	('PM00003','NV003', 'VMT',	'2022- 08- 20', '2022-10-20', 4),
	('PM00004','NV001', 'TNS',	'2022- 08- 19', '2022-10-19', 4),
	('PM00005','NV003', 'LBKT', '2022- 08- 23', '2022-10-23', 6),
	('PM00006','NV001', 'TQT',	'2022- 08- 25', '2022-10-25', 8),
	('PM00007','NV002', 'THT',	'2022- 08- 29', '2022-10-29', 9),
	('PM00008','NV001', 'NCA',	'2022- 08- 26', '2022-10-26', 8),
	('PM00009','NV001', 'HTM',	'2022- 08- 21',' 2022-10-21', 6),
	('PM00010','NV003', 'NNL',	'2022- 08- 20', '2022-10-20', 6),
	('PM00011','NV003', 'NTL',	'2022- 08- 18', '2022-10-18', 10),
	('PM00012','NV002', 'TTD',	'2022- 08- 18', '2022-10-18', 4),
	('PM00013','NV003', 'CQN',	'2022- 08- 29', '2022-10-29', 4),
	('PM00014','NV003', 'LNT',	'2022- 08- 27', '2022-10-27', 6),
	('PM00015','NV002', 'VMT',	'2022- 08- 24', '2022-10-24', 7),
	('PM00016','NV003', 'NTL',	'2022- 08- 24', '2022-10-24', 6);
GO

INSERT INTO DANHSACHMUON 
VALUES
	('PM00001', 'CN005',	2),
	('PM00001', 'D',		1),
	('PM00001', 'DDXC',		3),
	('PM00001', 'NN',		1),

	('PM00002', 'KUCMT',	3),
	('PM00002', 'GCCN',		1),
	('PM00002', 'MM',		1),

	('PM00003', 'CTTGMNX',	1),
	('PM00003', 'NDAB',		1),
	('PM00003', 'KCNN',		1),
	('PM00003', 'CGDC',		1),

	('PM00004', 'CN001',	2),
	('PM00004', 'CN002',	1),
	('PM00004', 'CN003',	1),

	('PM00005', 'CN004',	1),
	('PM00005', 'CN002',	2),
	('PM00005', 'CN006',	3),

	('PM00006', 'CN009',	2),
	('PM00006', 'CN007',	1),
	('PM00006', 'CN008',	3),
	('PM00006', 'NKUKCNY',	2),

	('PM00007', 'NN',		1),
	('PM00007', 'D',		2),
	('PM00007', 'CN001',	2),
	('PM00007', 'DD001',	4),

	('PM00008', 'DD001',	1),
	('PM00008', 'DN001',	2),
	('PM00008', 'DN002',	1),
	('PM00008', 'DDXC',		1),
	('PM00008', 'BCT',		2),
	('PM00008', 'LH',		1),

	('PM00009', 'LH',		2),
	('PM00009', 'CN009',	2),
	('PM00009', 'NVVL',		2),

	('PM00010', 'BCT',		2),
	('PM00010', 'DNT',		1),
	('PM00010', 'CN011',	1),
	('PM00010', 'LH',		2),

	('PM00011', 'CN012',	4),
	('PM00011', 'DNT',		3),
	('PM00011', 'NVVL',		3),

	('PM00012', 'CN010',	1),
	('PM00012', 'DDXC',		1),
	('PM00012', 'NN',		2),

	('PM00013', 'CN014',	1),
	('PM00013', 'CP',		1),
	('PM00013', 'LH',		1),
	('PM00013', 'D',		1),

	('PM00014', 'CN011',	2),
	('PM00014', 'DDXC',		1),	
	('PM00014', 'D',		2),
	('PM00014', 'KUCMT',	1),

	('PM00015', 'LH001',	2),
	('PM00015', 'GCCN',		1),
	('PM00015', 'ĐNT',		2),
	('PM00015', 'MM',		2),

	('PM00016', 'BCT',		1),
	('PM00016', 'KCNN',		3),
	('PM00016', 'NDAB',		2);
GO
 
