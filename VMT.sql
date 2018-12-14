CREATE TABLE Xe(
Id int primary key not null identity(1,1),
Ref nvarchar(100),
BienSoXe nvarchar(10) unique not null,
HangXe nvarchar(250),
GhiChu nvarchar(250)
)

CREATE TABLE HangHoa(
Id int primary key identity(1,1) not null,
Ref nvarchar(100),
Ten nvarchar(250),
Gia decimal,
GhiChu nvarchar(250)
)
CREATE TABLE VanChuyen(
Id decimal primary key not null identity(1,1),
Ref nvarchar(100),
HangHoaId int foreign key references HangHoa(Id),
HangHoaRef nvarchar(100),
XeId int foreign key references Xe(Id),
XeRef nvarchar(100),
BienSoXe nvarchar(10) not null,
SoChuyen int not null,
NgayVanChuyen DateTime CONSTRAINT DF_NgayVanChuyen DEFAULT GETDATE(),
GhiChu nvarchar(250)
)

