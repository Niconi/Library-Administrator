create database PROJECT;
use PROJECT;

Create table DataBuku(
Id_Buku VARCHAR (50) PRIMARY KEY NOT NULL,
Judul_Buku VARCHAR (50) NOT NULL,
Kuantitas INT NOT NULL,
Kategori VARCHAR (50) NOT NULL,
Penerbit VARCHAR (50) NOT NULL,
)

CREATE TABLE Staff(
Id_Staff int PRIMARY KEY NOT NULL,
Nama_Staff VARCHAR (50) NOT NULL,
Gender_Staff CHAR (1) NOT NULL,
Username VARCHAR (50) NOT NULL,
Password_staff VARCHAR (50) NOT NULL
)

CREATE TABLE Peminjaman(
No_Pinjam int PRIMARY KEY NOT NULL,
Id_Buku VARCHAR (50) NOT NULL,
Tanggal_Pinjam DATE NOT NULL,
Id_Staff int NOT NULL,
FOREIGN KEY (Id_Buku) REFERENCES DataBuku ,
FOREIGN KEY (Id_Staff) REFERENCES Staff ,
)

CREATE TABLE Pengembalian(
No_Kembali INT PRIMARY KEY NOT NULL,
Id_Buku VARCHAR (50) NOT NULL,
Id_Staff int NOT NULL,
Tanggal_Kembali DATE NOT NULL,
Jumlah_Denda INT NOT NULL,
FOREIGN KEY (Id_Buku) REFERENCES DataBuku ,
FOREIGN KEY (Id_Staff) REFERENCES Staff,
)

CREATE TABLE Student(
id_Student int PRIMARY KEY NOT NULL,
Nama_Student VARCHAR (50) NOT NULL,
Alamat_Student VARCHAR (50) NOT NULL,
No_Hp BIGINT NOT NULL,
No_Kembali INT NOT NULL,
No_Pinjam INT NOT NULL,
FOREIGN KEY (No_Kembali) REFERENCES Pengembalian ,
FOREIGN KEY (No_Pinjam) REFERENCES Peminjaman ,
)

-- DataBuku
INSERT INTO DataBuku VALUES ('00432','Ensiklopedia Nusantara I','2','Ensiklopedia','Erlangga')
INSERT INTO DataBuku VALUES ('00744','Laskar Pelangi','1','Novel Ringan','Gramedia')
INSERT INTO DataBuku VALUES ('00124','Ilmu Pengetahuan Sosial Kelas -11','1','Buku Pelajaran','DimasBook')

-- Staff
INSERT INTO Staff VALUES ('10001','Angel','P','AngelFly','Fly842')
INSERT INTO Staff VALUES ('10002','Agim','L','Larith','Coklat30')
INSERT INTO Staff VALUES ('10003','Alvin','L','veen444','Vin444')

-- Pengembalian
INSERT INTO Pengembalian VALUES ('7001','00432','10001','2022/03/31','20000')
INSERT INTO Pengembalian VALUES ('7002','00744','10002','2022/03/27','-')
INSERT INTO Pengembalian VALUES ('7003','00124','10003','2022/03/18','-')

-- Peminjaman
INSERT INTO Peminjaman VALUES ('0001','00432','2/1/2022','10001')
INSERT INTO Peminjaman VALUES ('0002','00744','3/20/2022','10002')
INSERT INTO Peminjaman VALUES ('0003','00124','3/17/2022','10003')

-- Student
INSERT INTO Student VALUES ('801','Anton','Jl. Boulevard Raya 1 Blok CA No.1','08123456789','7001','0001')
INSERT INTO Student VALUES ('802','Budil','Jl. Kampung Rambutan No.9','08165895574','7002','0002')
INSERT INTO Student VALUES ('803','Budul','Jl. Kursi Goyang No 2','08187659884','7003','0003')

SELECT * FROM DataBuku;
SELECT * FROM Peminjaman;
SELECT * FROM Staff;
SELECT * FROM Student;
SELECT * FROM Pengembalian;

DELETE FROM DataBuku;
DELETE FROM Staff;
DELETE FROM Student;
DELETE FROM Peminjaman;
DELETE FROM Pengembalian;

DROP TABLE Student;
DROP TABLE Pengembalian;
DROP TABLE Peminjaman;
DROP TABLE Staff;
DROP TABLE DataBuku;


CREATE TRIGGER KurangStock on MsInvoiceDetail
FOR INSERT AS
UPDATE stok SET stok.ItemStock = stok.ItemStock - krg.Quantity
from MsItem stok join inserted krg on stok.ItemID = krg.ItemID

CREATE TRIGGER KurangStock on DataBuku
FOR INSERT AS
UPDATE Kuantitas SET Kuantitas = stok.Kuantitas - 1
from Peminjaman stok join inserted krg on Kuantitas = Kuantitas

