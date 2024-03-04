--PROJE GRUBUNDAK�LER: ASUMAN ULUSOY 21040101010, EFSA SEZER 21040101008, ZEYNEP DEM�REL 21040101014

use [SEZA TEKN�K SERV�Si]

--M��teri tablosu olu�turur
CREATE TABLE Musteri (
    musteri_id INT PRIMARY KEY IDENTITY(1,1),
    m_ad VARCHAR(20) NOT NULL,
    m_soyad VARCHAR(20) NOT NULL,
    adres VARCHAR(50) NOT NULL,
    telefon_numarasi BIGINT 
);

--M��teri tablosuna email s�tunu ekler
ALTER TABLE Musteri ADD email VARCHAR(100);

--M��teri tablosuna veriler eklenir
INSERT INTO Musteri (m_ad, m_soyad, adres, telefon_numarasi, email) VALUES
    ('�mit', 'cengiz', 'pamukkale-denizli', 5356789876, 'umitcengiz@gmail.com'),
    ('deniz', 'kara', 'esenler-istanbul', 5345674565, 'denizkara@gmail.com'),
    ('murat', 'kaba', 'bak�rk�y-istanbul', 5323454333, 'muratkara@gmail.com'),
    ('devin', 'da�veren', 'sultangazi-istanbul', 5312344389, 'delindagveren@gmail.com'),
    ('cenk', 'do�ru', 'ere�li-zonguldak', 5356789809, 'cenkdogru@gmail.com'),
    ('meryem', 'mutlu', 'ere�li-zonguldak', 5334563344, 'meryemmutlu@gmail.com'),
    ('ahmet', 'cengiz', 'be�ikta�-istanbul', 535678890, 'ahmetcengiz@gmail.com'),
    ('ozan', 'efe', 'ke�i�ren-ankara', 5343455211, 'ozanefe@gmail.com'),
    ('efe', 'y�ld�r�m', 'levent-istanbul', 5354533456, 'efeyildirim@gmail.com'),
    ('ilayda', 'y�ld�r�m', 'levent-istanbul', 5323452343, 'ilaydayildirim@gmail.com'),
    ('onur', 'ba�veren', 'tortum-erzurum', 5456546677, 'onurbagveren@gmail.com'),
    ('zehra', '�zkal', 'ar�cak-elaz��', 5458998011, 'zehraozkal@gmail.com'),
    ('kemal', 'k�rdar', 'eflani-karab�k', 5351234566, 'kemalkirdar@gmail.com'),
    ('ferhat', 'durdu', 'bebek-istanbul', 5323456788, 'ferhatdurdu@gmail.com'),
    ('serhat', 'karanfil', 'buca-izmir', 5358976532, 'serhatkaranfil@gmail.com'),
	('z�lal', 'demirel', 'esenler-istanbul', 5342564754, 'z�laldemirel@gmail.com');

--M��teri tablosundaki ad� Efe, soyad� Y�ld�r�m ve emaili efeyildirim@gmail.com olan m��terinin adres bilgisini Bayburt-Demir�z� olarak g�nceller
UPDATE Musteri SET adres = 'demir�z�-bayburt' WHERE m_ad = 'efe' AND m_soyad = 'y�ld�r�m' AND email = 'efeyildirim@gmail.com';

--Musteri tablosundaki ilk 3 sat�rdaki adlar�n b�y�k harfli versiyonunu getirir.
SELECT TOP 3 UPPER(m_ad) FROM Musteri;

DECLARE @i INT = 1; -- M��teri tablosunda dola�mak i�in bir saya� de�i�keni tan�mlad�k.
WHILE @i <= (SELECT COUNT(*) FROM Musteri) -- M��teri tablosunda kay�tlar oldu�u s�rece d�ng�y� �al��t�r�n.
BEGIN
  DECLARE @musteri_id INT; -- Teknisyen ID'si i�in bir de�i�ken tan�mlay�n.
  SELECT @musteri_id = musteri_id FROM (SELECT ROW_NUMBER() OVER (ORDER BY musteri_id ASC) AS row_num, musteri_id FROM Musteri) AS T WHERE row_num = @i; -- M��teri tablosundan s�radaki m��terinin ID'sini al�n.

 
  DECLARE  @m_ad VARCHAR(50), @m_soyad VARCHAR(50);
  SELECT @m_ad = m_ad, @m_soyad = m_soyad FROM Musteri WHERE musteri_id = @musteri_id;
  PRINT CAST(@i AS VARCHAR(10)) + '. m��teri ad�: ' + @m_ad + ', soyad�: ' + @m_soyad;

  SET @i = @i + 1; -- Saya� de�i�kenini bir artt�r�n ve d�ng�n�n bir sonraki ad�ma ge�mesini sa�lay�n.
END


--Cihaz tablosu olu�turur
CREATE TABLE Cihaz (
	seri_no INT,
	cihaz_id INT PRIMARY KEY IDENTITY(1,1), 
	cihaz_tipi VARCHAR(50),
	marka VARCHAR(50),
	garanti_tarihi DATE,
	musteri_id INT,
	FOREIGN KEY (musteri_id) REFERENCES Musteri(musteri_id)
);

--Cihaz tablosuna veriler eklenir
INSERT INTO Cihaz(seri_no, cihaz_tipi ,marka ,garanti_tarihi, musteri_id) VALUES

    (4435, 'telefon', 'samsung', '2021-06-20', 1 ),
    (5463, 'yaz�c�', 'hp', '2022-09-04', 2 ),
    (3534, 'televizyon', 'lg','2020-09-12', 3 ),
    (3457, 'telefon', 'iPhone', '2011-12-12', 4 ),
    (8787, 'kulakl�k', 'iPhone','2022-11-04', 2 ),
    (8678, 'bilgisayar', 'dell', '2027-09-11', 5 ),
    (9809, 'bilgisayar', 'huawei', '2029-09-23', 6 ),
    (4570, 'tablet', 'iPad', '2024-08-03', 3 ),
    (8734, 'telefon', 'asus', '2019-04-09', 7 ),
    (9246, 'ak�ll� saat', 'Xiaomi', '2020-07-23', 8 ),
    (3253, 'sanal g�zl�k', 'zore', '2020-08-09', 1 ),
    (8453, 'kulakl�k', 'airpods', '2030-11-11', 2 ),
    (9762, 'projeksiyon', 'philips', '2009-04-23' , 9 ),
    (5432, 'modem', 'tenda', '2011-03-11' , 10 ),
    (7867, 'bilgisayar', 'casper', '2024-12-12', 11 ),
	(9684, 'bilgisayar', 'MacBook', '2028-01-01' , 12 ),
    (2543, 'kulakl�k', 'huawei', '2030-04-23', 12 ),
    (9543, 'telefon', 'iPhone', '2012-03-03' , 13 ),
    (4213, 'kulakl�k', 'polosmart', '2014-12-12' , 14 ),
	(1234, 'telefon', 'samsung', '2021-03-12' , 15 );


--Cihaz tablosundaki cihaz tipi "k" harfi ile biten cihazlar�n say�s� 3'ten b�y�k ise �art sa�lan�r ve i�indeki komut �al���r.
	IF((SELECT COUNT( * ) FROM Cihaz WHERE cihaz_tipi LIKE '%k') > 3)
 begin
  print ' K harfi ile biten cihaz say�s� 3 ten fazla!'
 end


--Cihaz tablosundaki garanti tarihi '2020-09-11' ve '2024-11-23' aras�nda olan cihazlar� g�sterir
SELECT * FROM Cihaz WHERE garanti_tarihi BETWEEN '2020-09-11' AND '2024-11-23';

--Cihaz tablosundaki verileri alfabetik olarak cihaz tipine g�re s�ralama yapar
SELECT * FROM Cihaz ORDER BY cihaz_tipi

--M��teriler tablosundaki m��teri soyadlar�n� kontrol ederek soyad�n�n i�inde "a" harfi bulunan m��terilerin adres bilgisini verir
SELECT adres FROM Musteri WHERE m_soyad Like ('%a%');

--M��terilerin ad ve soyad bilgilerini tek bir s�tunda g�rmemizi sa�lar
SELECT DISTINCT (m_ad+' '+m_soyad) AS M��teriler FROM Musteri ;

-- Ka� �e�it cihaz oldu�unu g�sterir
SELECT   COUNT (DISTINCT cihaz_tipi )  AS cihaz_�e�itleri  FROM Cihaz ; 

--Cihaz seri no ile cihaz tipi s�tunlar�n� birle�tirerek verir
SELECT CONCAT(seri_no, '       ' , cihaz_tipi) AS Cihazlar FROM Cihaz;


SELECT SUBSTRING ((problem_tanimi) , 8,6) AS Substring_Ornegi FROM ServisSorgu;
SELECT UPPER(m_ad) AS Musteri_Adlari FROM Musteri;
SELECT LTRIM('         Teknik Servis');
SELECT REPLACE('Teknik Servis', 'Teknik', 'SEZA');
SELECT REVERSE(m_soyad) AS Soyadlar FROM Musteri;
SELECT RTRIM('Teknik Servis                 ');
SELECT LEN(problem_tanimi) AS sutun_ad�n�n_uzunlu�u FROM ServisSorgu;

--Teknisyen tablosu olu�turur
CREATE TABLE Teknisyen (
  teknisyen_id INT PRIMARY KEY IDENTITY(1,1),
  t_ad VARCHAR(50) NOT NULL,
  t_soyad VARCHAR(50) NOT NULL,
  t_cinsiyet CHAR(1),
  t_yas INT, CHECK (t_yas>18),
  uzmanlik VARCHAR(50) NOT NULL,
  t_maas INT
);

--Teknisyen tablosuna �al��ma saati s�tunu ekleyecek �ekilde de�i�iklik yapar
ALTER TABLE Teknisyen ADD calisma_saati TINYINT NOT NULL;

--Teknisyen tablosuna veriler eklenir
INSERT INTO Teknisyen VALUES
    ('serhan', 'ak', 'E', 19, 'elektrik-elektronik', 17250, 30 ),
    ('eslem', 'ko�', 'K', 22, 'bilgisayar ve a�',18500, 35 ),
    ('murat', 'karaman', 'E', 32,  'end�striyel ekipmanlar', 22400, 37 ),
    ('derya', 'berkan', 'K', 34, 'bilgisayar ve a�', 23520, 40 ),
	('onur', 'y�lmaz', 'E', 35, 'elektrik-elektronik', 21520, 38 );
	


--Teknisyenlerin maa� bilgisinden en y�ksek maa� bilgisini getirir
SELECT MAX (t_maas) AS max_maas FROM Teknisyen;

--Teknisyenlerin maa� ortalamas�n� verir
SELECT AVG (t_maas) AS ortalama_maas FROM Teknisyen;

--Ortalama maa�tan y�ksek olan maa�lar� listeler
SELECT t_ad, t_soyad, t_maas
FROM Teknisyen
WHERE t_maas > (SELECT AVG(t_maas) FROM Teknisyen);

--Teknisyen tablosundaki teknisyenleri maa� bilgilerine g�re s�ralay�p ad, soyad ve uzmanl�k bilgilerini getirir
SELECT  t_ad, t_soyad, t_yas, uzmanlik FROM Teknisyen ORDER BY t_maas DESC;

--M��teri tablosundaki istenilenleri ve cihaz tablosundakilerle ortak olanlar� getirir
SELECT M.musteri_id, M.m_ad, M.m_soyad, C.cihaz_id, C.cihaz_tipi
FROM Musteri M
LEFT JOIN Cihaz C ON M.musteri_id = C.cihaz_id;

--Cihaz tablosundaki cihaz tiplerine g�re gruplar ve her bir tipteki cihazlar�n toplam say�s�n� g�r�nt�ler
SELECT cihaz_tipi, COUNT(*) AS toplam_cihaz
FROM Cihaz
GROUP BY cihaz_tipi;


--Servis Sorgu tablosu olu�turulur
CREATE TABLE ServisSorgu (
  sorgu_id INT PRIMARY KEY IDENTITY(1,1),
  musteri_id INT,
  cihaz_id INT,
  teknisyen_id INT,
  problem_tanimi VARCHAR(500),
  gelis_tarihi DATETIME,
  tamamlanma_tarihi DATETIME,
  islem_tanimi VARCHAR(200),
  FOREIGN KEY (musteri_id) REFERENCES Musteri(musteri_id),
  FOREIGN KEY (cihaz_id) REFERENCES Cihaz(cihaz_id),
  FOREIGN KEY (teknisyen_id) REFERENCES Teknisyen(teknisyen_id)
);

--ServisSorgu tablosuna veriler eklenir
INSERT INTO ServisSorgu (musteri_id, cihaz_id, teknisyen_id, problem_tanimi, gelis_tarihi, tamamlanma_tarihi, islem_tanimi ) VALUES
	(1,1,1, 'y�ksekten d��t�', '2021-04-12', '2021-04-28', 'ekran kart� de�i�imi' ),
	(1,9,1, 'y�ksekten d��t�', '2021-03-12', '2021-04-12', 'anakart de�i�ti'),
	(2,2,1, 'ar�za ����� yan�yor', '2023-03-28', '2023-04-12' , 'silindir temizlendi' ),
	(2,5,1, 'sol kulakl�ktan ses gelmiyor', '2022-05-18', '2022-06-02', 'sol kulakl�k bataryas� de�i�tirildi' ),
	(2,12,1, 'sa� kulakl�ktan ses k�s�k geliyor', '2023-04-11', '2023-04-19', '�r�n yenisi ile de�i�tirildi' ),
	(3,3,2, 'ekran hasarl�', '2023-03-09', NULL , NULL  ), --i�lem hen�z tamamlanmad��� i�in tamamlanma tarihi ve yap�lan i�lem k�s�mlar�na NULL yazd�k.
	(3,8,2, 'donma problemi', '2022-11-12', '2021-11-25', 'yaz�l�m g�ncellemeleri yap�ld�' ),
	(4,4,2, '�arj�n h�zl� bitmesi', '2022-08-11', '2021-08-22', 'batarya de�i�tirildi'),
	(5,6,2, 'fandan kaynakl� y�ksek ses', '2023-01-09', '2021-01-25', 'ekran kart� de�i�tirildi'),
	(6,7,2, 'performans� yava�', '2022-12-14', '2022-12-27', 'RAM y�kseltildi'),
	(7,11,3, 'kamera cam� k�r�k', '2023-04-10', NULL , NULL  ),
	(8,10,3, 'telefona ba�lant� sorunu', '2022-05-16', '2022-06-03', 'kablo de�i�imi'),
	(9,13,3, 'bulan�k g�r�nt� problemi', '2022-07-24', '2021-08-05', 'mercek de�i�imi' ),
	(10,14,3, 'ba�lant� problemi', '2023-05-02', NULL , NULL  ),
	(11,15,3, 'performans� yava�', '2023-02-12', '2021-02-19', 'CPU de�i�imi' ),
	(12,16,4, 'ekrana g�r�nt� gelmiyor', '2022-04-07', '2021-04-25', 'ekran kart� de�i�tirildi'),
	(12,17,4, 'telefona ba�lanma sorunu', '2023-03-02', '2021-03-22', 'yaz�l�m g�ncellemeleri yap�ld�' ),
	(13,18,4, 'SIM kart�n� tan�m�yor', '2023-04-06', NULL , NULL ),
	(14,19,4, 'sa� kulakl�ktan ses gelmiyor', '2023-01-15', '2023-01-23',  'sa� kulakl�k bataryas� de�i�tirildi' ),
	(15,20,4, 'ana ekran tu�u �al��m�yor', '2023-03-29', NULL , NULL );

--M��terilerin getirdi�i cihazlar� ve getirilen bu cihazlar� hangi teksnisyenin onaraca��n� g�steren join sorgusu
SELECT M.musteri_id, M.m_ad, M.m_soyad, C.cihaz_id, C.cihaz_tipi, T.teknisyen_id, T.t_ad, T.t_soyad,S.islem_tanimi
FROM ServisSorgu S
JOIN Cihaz C ON S.cihaz_id = C.cihaz_id
JOIN Musteri M ON S.musteri_id = M.musteri_id
JOIN Teknisyen T ON S.teknisyen_id = T.teknisyen_id ORDER BY musteri_id;

--Bir teknisyenin ka� cihazla ilgilendi�ini g�sterir
SELECT DISTINCT teknisyen_id , COUNT(*) AS ilgilendi�i_toplam_cihaz 
FROM ServisSorgu
GROUP BY teknisyen_id;

--cihaz_id ile sorgu_id'si ayn� olan verileri e�le�tirip sorgu id, problem tan�m�, cihaz id ve cihaz tipi bilgilerini getirir
SELECT S.sorgu_id, S.problem_tanimi, C.cihaz_id, C.cihaz_tipi,S.islem_tanimi
FROM ServisSorgu S
LEFT JOIN Cihaz C ON S.cihaz_id = C.cihaz_id
LEFT JOIN Teknisyen T ON S.teknisyen_id = T.teknisyen_id ;

--function �rne�i
CREATE FUNCTION Zamli_Maas(@t_maas INT)
RETURNS INT
AS
BEGIN
	DECLARE @zamli_maas INT 
	SET @zamli_maas = @t_maas + 3000
    RETURN @zamli_maas;
	
END

SELECT dbo.Zamli_Maas(t_maas) AS G�ncel_Maa�_Tablosu FROM Teknisyen WHERE uzmanlik='bilgisayar ve a�';

--subquery �rne�i
SELECT cihaz_id, problem_tanimi, musteri_id
FROM ServisSorgu
WHERE musteri_id IN (
  SELECT musteri_id
  FROM Musteri
  WHERE m_ad = 'Deniz'
);

--Ortalama maa�� 20000'den y�ksek olan teknisyenlerin ad ve soyad bilgilerini having yap�s� kullanarak bulduk
SELECT t_ad, t_soyad, AVG(t_maas) as avg_maas
FROM Teknisyen 
GROUP BY t_ad, t_soyad
HAVING AVG(t_maas) > 20000;


--Par�a tablosu olu�turur
CREATE TABLE Parca (
  parca_id INT PRIMARY KEY IDENTITY(1,1),
  cihaz_id INT,
  parca_adi VARCHAR(50),
  fiyat DECIMAL(10, 2),
  FOREIGN KEY (cihaz_id) REFERENCES Cihaz�(cihaz_id)
);

--Par�a tablosuna veriler eklenir
INSERT INTO Parca (cihaz_id,parca_adi,fiyat) VALUES
	   (1,'ekran cam�',1250),
	   (2,'anakart ',2500),
	   (4,'batarya',350),
	   (5,'sa� kulakl�k',500),
	   (8,'batarya',350),
	   (9,'ekran kart�',2000),
	   (10,'ram',500),
	   (12,'kablo',150),
	   (13,'mercek',800),
	   (15,'cpu',3000),
	   (16,'ekran kart�',2000),
	   (19,'batarya',350);
	  
--Garanti tarihinin ge�erlili�ine g�re �cret hesaplayan function kodu
CREATE FUNCTION ParcaUcretHesapla(@parca_id INT)
RETURNS DECIMAL(10,2)
AS
BEGIN
  DECLARE @fiyat DECIMAL(10,2);
  SELECT @fiyat = 
    CASE
      WHEN DATEDIFF(day, GETDATE(), (SELECT garanti_tarihi FROM Cihaz WHERE cihaz_id = (SELECT cihaz_id FROM Parca WHERE parca_id = @parca_id))) <= 0 THEN fiyat 
      ELSE 0
     END
  FROM Parca 
  WHERE parca_id = @parca_id;
  RETURN�@fiyat;
END;

SELECT dbo.ParcaUcretHesapla(parca_id) AS Toplam_Ucret FROM Parca ;



-- VIEW Kullan�m� ile ��lem Sorgusu
CREATE VIEW IslemSorgulama AS
SELECT M.m_ad, M.m_soyad, C.seri_no, C.cihaz_id, C.cihaz_tipi, S.problem_tanimi, S.islem_tanimi,
CASE
  WHEN S.islem_tanimi IS NULL  THEN 'Isleminiz hen�z tamamlanmam��t�r'
  ELSE 'Isleminiz tamamlanm��t�r'
END AS 'Islem'
FROM Musteri M 
JOIN ServisSorgu S ON M.musteri_id = S.musteri_id
JOIN Cihaz C ON S.cihaz_id = C.cihaz_id;

SELECT * FROM IslemSorgulama;



CREATE VIEW UcretSorgu AS
SELECT M.musteri_id, M.m_ad, M.m_soyad, P.fiyat
FROM Musteri M
JOIN ServisSorgu S ON M.musteri_id = S.musteri_id
JOIN Cihaz C ON S.cihaz_id = C.cihaz_id
JOIN Parca P ON C.cihaz_id = P.cihaz_id;

SELECT * FROM UcretSorgu;


CREATE VIEW Teknisyen_CihazSorgu AS
SELECT T.teknisyen_id, T.t_ad, T.t_soyad, C.cihaz_id, C.cihaz_tipi, C.marka
FROM Teknisyen T
JOIN ServisSorgu S ON T.teknisyen_id = S.teknisyen_id
JOIN Cihaz C ON S.cihaz_id = C.cihaz_id;


SELECT * FROM Teknisyen_CihazSorgu;




--Sakl� prosed�r (stored procedure) olu�turuldu. 
CREATE PROCEDURE MusteriSorgula
  @musteri_id INT
AS
BEGIN
  SELECT * FROM Musteri WHERE musteri_id = @musteri_id;
END

EXECUTE MusteriSorgula @musteri_id�=�8;



-- Except kullanarak cihaz� bulunmayan m��terinin bilgilerini g�r�nt�ledik.
SELECT m_ad, m_soyad, telefon_numarasi 
FROM Musteri
EXCEPT
SELECT m_ad, m_soyad, telefon_numarasi
FROM Musteri
JOIN Cihaz ON Musteri.musteri_id = Cihaz.musteri_id;



--MusteriLog tablosu olu�turuldu
CREATE TABLE MusteriLog (
    musteri_id INT PRIMARY KEY IDENTITY(1,1),
    m_ad VARCHAR(20) NOT NULL,
    m_soyad VARCHAR(20) NOT NULL,
    adres VARCHAR(50) NOT NULL,
    telefon_numarasi BIGINT,
	email VARCHAR(100),
	degistirilme_tarihi DATE
);


/*Trigger yap�s� kullan�ld�. Musteri tablosunda yap�lan herhangi bir de�i�iklik MusteriLog
tablosunda de��tirilme tarihiyle birlikte tutulur*/
CREATE TRIGGER log_trigger
ON Musteri
AFTER UPDATE 
AS
BEGIN
   INSERT INTO MusteriLog (m_ad, m_soyad, adres, telefon_numarasi, email, degistirilme_tarihi)
   SELECT i.m_ad, i.m_soyad, i.adres, i.telefon_numarasi, i.email, GETDATE()
   FROM INSERTED i
   INNER JOIN DELETED d ON i.musteri_id = d.musteri_id;
END;

--Trigger yap�s�n� test etmek amac�yla bir m��terinin bilgileri g�ncellenmi�tir.
UPDATE Musteri SET adres = 'nil�fer-bursa' WHERE m_ad = 'ilayda' AND m_soyad = 'y�ld�r�m' AND email = 'ilaydayildirim@gmail.com';
