--PROJE GRUBUNDAKÝLER: ASUMAN ULUSOY 21040101010, EFSA SEZER 21040101008, ZEYNEP DEMÝREL 21040101014

use [SEZA TEKNÝK SERVÝSi]

--Müþteri tablosu oluþturur
CREATE TABLE Musteri (
    musteri_id INT PRIMARY KEY IDENTITY(1,1),
    m_ad VARCHAR(20) NOT NULL,
    m_soyad VARCHAR(20) NOT NULL,
    adres VARCHAR(50) NOT NULL,
    telefon_numarasi BIGINT 
);

--Müþteri tablosuna email sütunu ekler
ALTER TABLE Musteri ADD email VARCHAR(100);

--Müþteri tablosuna veriler eklenir
INSERT INTO Musteri (m_ad, m_soyad, adres, telefon_numarasi, email) VALUES
    ('ümit', 'cengiz', 'pamukkale-denizli', 5356789876, 'umitcengiz@gmail.com'),
    ('deniz', 'kara', 'esenler-istanbul', 5345674565, 'denizkara@gmail.com'),
    ('murat', 'kaba', 'bakýrköy-istanbul', 5323454333, 'muratkara@gmail.com'),
    ('devin', 'daðveren', 'sultangazi-istanbul', 5312344389, 'delindagveren@gmail.com'),
    ('cenk', 'doðru', 'ereðli-zonguldak', 5356789809, 'cenkdogru@gmail.com'),
    ('meryem', 'mutlu', 'ereðli-zonguldak', 5334563344, 'meryemmutlu@gmail.com'),
    ('ahmet', 'cengiz', 'beþiktaþ-istanbul', 535678890, 'ahmetcengiz@gmail.com'),
    ('ozan', 'efe', 'keçiören-ankara', 5343455211, 'ozanefe@gmail.com'),
    ('efe', 'yýldýrým', 'levent-istanbul', 5354533456, 'efeyildirim@gmail.com'),
    ('ilayda', 'yýldýrým', 'levent-istanbul', 5323452343, 'ilaydayildirim@gmail.com'),
    ('onur', 'baðveren', 'tortum-erzurum', 5456546677, 'onurbagveren@gmail.com'),
    ('zehra', 'özkal', 'arýcak-elazýð', 5458998011, 'zehraozkal@gmail.com'),
    ('kemal', 'kýrdar', 'eflani-karabük', 5351234566, 'kemalkirdar@gmail.com'),
    ('ferhat', 'durdu', 'bebek-istanbul', 5323456788, 'ferhatdurdu@gmail.com'),
    ('serhat', 'karanfil', 'buca-izmir', 5358976532, 'serhatkaranfil@gmail.com'),
	('zülal', 'demirel', 'esenler-istanbul', 5342564754, 'zülaldemirel@gmail.com');

--Müþteri tablosundaki adý Efe, soyadý Yýldýrým ve emaili efeyildirim@gmail.com olan müþterinin adres bilgisini Bayburt-Demirözü olarak günceller
UPDATE Musteri SET adres = 'demirözü-bayburt' WHERE m_ad = 'efe' AND m_soyad = 'yýldýrým' AND email = 'efeyildirim@gmail.com';

--Musteri tablosundaki ilk 3 satýrdaki adlarýn büyük harfli versiyonunu getirir.
SELECT TOP 3 UPPER(m_ad) FROM Musteri;

DECLARE @i INT = 1; -- Müþteri tablosunda dolaþmak için bir sayaç deðiþkeni tanýmladýk.
WHILE @i <= (SELECT COUNT(*) FROM Musteri) -- Müþteri tablosunda kayýtlar olduðu sürece döngüyü çalýþtýrýn.
BEGIN
  DECLARE @musteri_id INT; -- Teknisyen ID'si için bir deðiþken tanýmlayýn.
  SELECT @musteri_id = musteri_id FROM (SELECT ROW_NUMBER() OVER (ORDER BY musteri_id ASC) AS row_num, musteri_id FROM Musteri) AS T WHERE row_num = @i; -- Mðþteri tablosundan sýradaki müþterinin ID'sini alýn.

 
  DECLARE  @m_ad VARCHAR(50), @m_soyad VARCHAR(50);
  SELECT @m_ad = m_ad, @m_soyad = m_soyad FROM Musteri WHERE musteri_id = @musteri_id;
  PRINT CAST(@i AS VARCHAR(10)) + '. müþteri adý: ' + @m_ad + ', soyadý: ' + @m_soyad;

  SET @i = @i + 1; -- Sayaç deðiþkenini bir arttýrýn ve döngünün bir sonraki adýma geçmesini saðlayýn.
END


--Cihaz tablosu oluþturur
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
    (5463, 'yazýcý', 'hp', '2022-09-04', 2 ),
    (3534, 'televizyon', 'lg','2020-09-12', 3 ),
    (3457, 'telefon', 'iPhone', '2011-12-12', 4 ),
    (8787, 'kulaklýk', 'iPhone','2022-11-04', 2 ),
    (8678, 'bilgisayar', 'dell', '2027-09-11', 5 ),
    (9809, 'bilgisayar', 'huawei', '2029-09-23', 6 ),
    (4570, 'tablet', 'iPad', '2024-08-03', 3 ),
    (8734, 'telefon', 'asus', '2019-04-09', 7 ),
    (9246, 'akýllý saat', 'Xiaomi', '2020-07-23', 8 ),
    (3253, 'sanal gözlük', 'zore', '2020-08-09', 1 ),
    (8453, 'kulaklýk', 'airpods', '2030-11-11', 2 ),
    (9762, 'projeksiyon', 'philips', '2009-04-23' , 9 ),
    (5432, 'modem', 'tenda', '2011-03-11' , 10 ),
    (7867, 'bilgisayar', 'casper', '2024-12-12', 11 ),
	(9684, 'bilgisayar', 'MacBook', '2028-01-01' , 12 ),
    (2543, 'kulaklýk', 'huawei', '2030-04-23', 12 ),
    (9543, 'telefon', 'iPhone', '2012-03-03' , 13 ),
    (4213, 'kulaklýk', 'polosmart', '2014-12-12' , 14 ),
	(1234, 'telefon', 'samsung', '2021-03-12' , 15 );


--Cihaz tablosundaki cihaz tipi "k" harfi ile biten cihazlarýn sayýsý 3'ten büyük ise þart saðlanýr ve içindeki komut çalýþýr.
	IF((SELECT COUNT( * ) FROM Cihaz WHERE cihaz_tipi LIKE '%k') > 3)
 begin
  print ' K harfi ile biten cihaz sayýsý 3 ten fazla!'
 end


--Cihaz tablosundaki garanti tarihi '2020-09-11' ve '2024-11-23' arasýnda olan cihazlarý gösterir
SELECT * FROM Cihaz WHERE garanti_tarihi BETWEEN '2020-09-11' AND '2024-11-23';

--Cihaz tablosundaki verileri alfabetik olarak cihaz tipine göre sýralama yapar
SELECT * FROM Cihaz ORDER BY cihaz_tipi

--Müþteriler tablosundaki müþteri soyadlarýný kontrol ederek soyadýnýn içinde "a" harfi bulunan müþterilerin adres bilgisini verir
SELECT adres FROM Musteri WHERE m_soyad Like ('%a%');

--Müþterilerin ad ve soyad bilgilerini tek bir sütunda görmemizi saðlar
SELECT DISTINCT (m_ad+' '+m_soyad) AS Müþteriler FROM Musteri ;

-- Kaç çeþit cihaz olduðunu gösterir
SELECT   COUNT (DISTINCT cihaz_tipi )  AS cihaz_çeþitleri  FROM Cihaz ; 

--Cihaz seri no ile cihaz tipi sütunlarýný birleþtirerek verir
SELECT CONCAT(seri_no, '       ' , cihaz_tipi) AS Cihazlar FROM Cihaz;


SELECT SUBSTRING ((problem_tanimi) , 8,6) AS Substring_Ornegi FROM ServisSorgu;
SELECT UPPER(m_ad) AS Musteri_Adlari FROM Musteri;
SELECT LTRIM('         Teknik Servis');
SELECT REPLACE('Teknik Servis', 'Teknik', 'SEZA');
SELECT REVERSE(m_soyad) AS Soyadlar FROM Musteri;
SELECT RTRIM('Teknik Servis                 ');
SELECT LEN(problem_tanimi) AS sutun_adýnýn_uzunluðu FROM ServisSorgu;

--Teknisyen tablosu oluþturur
CREATE TABLE Teknisyen (
  teknisyen_id INT PRIMARY KEY IDENTITY(1,1),
  t_ad VARCHAR(50) NOT NULL,
  t_soyad VARCHAR(50) NOT NULL,
  t_cinsiyet CHAR(1),
  t_yas INT, CHECK (t_yas>18),
  uzmanlik VARCHAR(50) NOT NULL,
  t_maas INT
);

--Teknisyen tablosuna çalýþma saati sütunu ekleyecek þekilde deðiþiklik yapar
ALTER TABLE Teknisyen ADD calisma_saati TINYINT NOT NULL;

--Teknisyen tablosuna veriler eklenir
INSERT INTO Teknisyen VALUES
    ('serhan', 'ak', 'E', 19, 'elektrik-elektronik', 17250, 30 ),
    ('eslem', 'koç', 'K', 22, 'bilgisayar ve að',18500, 35 ),
    ('murat', 'karaman', 'E', 32,  'endüstriyel ekipmanlar', 22400, 37 ),
    ('derya', 'berkan', 'K', 34, 'bilgisayar ve að', 23520, 40 ),
	('onur', 'yýlmaz', 'E', 35, 'elektrik-elektronik', 21520, 38 );
	


--Teknisyenlerin maaþ bilgisinden en yüksek maaþ bilgisini getirir
SELECT MAX (t_maas) AS max_maas FROM Teknisyen;

--Teknisyenlerin maaþ ortalamasýný verir
SELECT AVG (t_maas) AS ortalama_maas FROM Teknisyen;

--Ortalama maaþtan yüksek olan maaþlarý listeler
SELECT t_ad, t_soyad, t_maas
FROM Teknisyen
WHERE t_maas > (SELECT AVG(t_maas) FROM Teknisyen);

--Teknisyen tablosundaki teknisyenleri maaþ bilgilerine göre sýralayýp ad, soyad ve uzmanlýk bilgilerini getirir
SELECT  t_ad, t_soyad, t_yas, uzmanlik FROM Teknisyen ORDER BY t_maas DESC;

--Müþteri tablosundaki istenilenleri ve cihaz tablosundakilerle ortak olanlarý getirir
SELECT M.musteri_id, M.m_ad, M.m_soyad, C.cihaz_id, C.cihaz_tipi
FROM Musteri M
LEFT JOIN Cihaz C ON M.musteri_id = C.cihaz_id;

--Cihaz tablosundaki cihaz tiplerine göre gruplar ve her bir tipteki cihazlarýn toplam sayýsýný görüntüler
SELECT cihaz_tipi, COUNT(*) AS toplam_cihaz
FROM Cihaz
GROUP BY cihaz_tipi;


--Servis Sorgu tablosu oluþturulur
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
	(1,1,1, 'yüksekten düþtü', '2021-04-12', '2021-04-28', 'ekran kartý deðiþimi' ),
	(1,9,1, 'yüksekten düþtü', '2021-03-12', '2021-04-12', 'anakart deðiþti'),
	(2,2,1, 'arýza ýþýðý yanýyor', '2023-03-28', '2023-04-12' , 'silindir temizlendi' ),
	(2,5,1, 'sol kulaklýktan ses gelmiyor', '2022-05-18', '2022-06-02', 'sol kulaklýk bataryasý deðiþtirildi' ),
	(2,12,1, 'sað kulaklýktan ses kýsýk geliyor', '2023-04-11', '2023-04-19', 'ürün yenisi ile deðiþtirildi' ),
	(3,3,2, 'ekran hasarlý', '2023-03-09', NULL , NULL  ), --iþlem henüz tamamlanmadýðý için tamamlanma tarihi ve yapýlan iþlem kýsýmlarýna NULL yazdýk.
	(3,8,2, 'donma problemi', '2022-11-12', '2021-11-25', 'yazýlým güncellemeleri yapýldý' ),
	(4,4,2, 'þarjýn hýzlý bitmesi', '2022-08-11', '2021-08-22', 'batarya deðiþtirildi'),
	(5,6,2, 'fandan kaynaklý yüksek ses', '2023-01-09', '2021-01-25', 'ekran kartý deðiþtirildi'),
	(6,7,2, 'performansý yavaþ', '2022-12-14', '2022-12-27', 'RAM yükseltildi'),
	(7,11,3, 'kamera camý kýrýk', '2023-04-10', NULL , NULL  ),
	(8,10,3, 'telefona baðlantý sorunu', '2022-05-16', '2022-06-03', 'kablo deðiþimi'),
	(9,13,3, 'bulanýk görüntü problemi', '2022-07-24', '2021-08-05', 'mercek deðiþimi' ),
	(10,14,3, 'baðlantý problemi', '2023-05-02', NULL , NULL  ),
	(11,15,3, 'performansý yavaþ', '2023-02-12', '2021-02-19', 'CPU deðiþimi' ),
	(12,16,4, 'ekrana görüntü gelmiyor', '2022-04-07', '2021-04-25', 'ekran kartý deðiþtirildi'),
	(12,17,4, 'telefona baðlanma sorunu', '2023-03-02', '2021-03-22', 'yazýlým güncellemeleri yapýldý' ),
	(13,18,4, 'SIM kartýný tanýmýyor', '2023-04-06', NULL , NULL ),
	(14,19,4, 'sað kulaklýktan ses gelmiyor', '2023-01-15', '2023-01-23',  'sað kulaklýk bataryasý deðiþtirildi' ),
	(15,20,4, 'ana ekran tuþu çalýþmýyor', '2023-03-29', NULL , NULL );

--Müþterilerin getirdiði cihazlarý ve getirilen bu cihazlarý hangi teksnisyenin onaracaðýný gösteren join sorgusu
SELECT M.musteri_id, M.m_ad, M.m_soyad, C.cihaz_id, C.cihaz_tipi, T.teknisyen_id, T.t_ad, T.t_soyad,S.islem_tanimi
FROM ServisSorgu S
JOIN Cihaz C ON S.cihaz_id = C.cihaz_id
JOIN Musteri M ON S.musteri_id = M.musteri_id
JOIN Teknisyen T ON S.teknisyen_id = T.teknisyen_id ORDER BY musteri_id;

--Bir teknisyenin kaç cihazla ilgilendiðini gösterir
SELECT DISTINCT teknisyen_id , COUNT(*) AS ilgilendiði_toplam_cihaz 
FROM ServisSorgu
GROUP BY teknisyen_id;

--cihaz_id ile sorgu_id'si ayný olan verileri eþleþtirip sorgu id, problem tanýmý, cihaz id ve cihaz tipi bilgilerini getirir
SELECT S.sorgu_id, S.problem_tanimi, C.cihaz_id, C.cihaz_tipi,S.islem_tanimi
FROM ServisSorgu S
LEFT JOIN Cihaz C ON S.cihaz_id = C.cihaz_id
LEFT JOIN Teknisyen T ON S.teknisyen_id = T.teknisyen_id ;

--function örneði
CREATE FUNCTION Zamli_Maas(@t_maas INT)
RETURNS INT
AS
BEGIN
	DECLARE @zamli_maas INT 
	SET @zamli_maas = @t_maas + 3000
    RETURN @zamli_maas;
	
END

SELECT dbo.Zamli_Maas(t_maas) AS Güncel_Maaþ_Tablosu FROM Teknisyen WHERE uzmanlik='bilgisayar ve að';

--subquery örneði
SELECT cihaz_id, problem_tanimi, musteri_id
FROM ServisSorgu
WHERE musteri_id IN (
  SELECT musteri_id
  FROM Musteri
  WHERE m_ad = 'Deniz'
);

--Ortalama maaþý 20000'den yüksek olan teknisyenlerin ad ve soyad bilgilerini having yapýsý kullanarak bulduk
SELECT t_ad, t_soyad, AVG(t_maas) as avg_maas
FROM Teknisyen 
GROUP BY t_ad, t_soyad
HAVING AVG(t_maas) > 20000;


--Parça tablosu oluþturur
CREATE TABLE Parca (
  parca_id INT PRIMARY KEY IDENTITY(1,1),
  cihaz_id INT,
  parca_adi VARCHAR(50),
  fiyat DECIMAL(10, 2),
  FOREIGN KEY (cihaz_id) REFERENCES Cihaz (cihaz_id)
);

--Parça tablosuna veriler eklenir
INSERT INTO Parca (cihaz_id,parca_adi,fiyat) VALUES
	   (1,'ekran camý',1250),
	   (2,'anakart ',2500),
	   (4,'batarya',350),
	   (5,'sað kulaklýk',500),
	   (8,'batarya',350),
	   (9,'ekran kartý',2000),
	   (10,'ram',500),
	   (12,'kablo',150),
	   (13,'mercek',800),
	   (15,'cpu',3000),
	   (16,'ekran kartý',2000),
	   (19,'batarya',350);
	  
--Garanti tarihinin geçerliliðine göre ücret hesaplayan function kodu
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
  RETURN @fiyat;
END;

SELECT dbo.ParcaUcretHesapla(parca_id) AS Toplam_Ucret FROM Parca ;



-- VIEW Kullanýmý ile Ýþlem Sorgusu
CREATE VIEW IslemSorgulama AS
SELECT M.m_ad, M.m_soyad, C.seri_no, C.cihaz_id, C.cihaz_tipi, S.problem_tanimi, S.islem_tanimi,
CASE
  WHEN S.islem_tanimi IS NULL  THEN 'Isleminiz henüz tamamlanmamýþtýr'
  ELSE 'Isleminiz tamamlanmýþtýr'
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




--Saklý prosedür (stored procedure) oluþturuldu. 
CREATE PROCEDURE MusteriSorgula
  @musteri_id INT
AS
BEGIN
  SELECT * FROM Musteri WHERE musteri_id = @musteri_id;
END

EXECUTE MusteriSorgula @musteri_id = 8;



-- Except kullanarak cihazý bulunmayan müþterinin bilgilerini görüntüledik.
SELECT m_ad, m_soyad, telefon_numarasi 
FROM Musteri
EXCEPT
SELECT m_ad, m_soyad, telefon_numarasi
FROM Musteri
JOIN Cihaz ON Musteri.musteri_id = Cihaz.musteri_id;



--MusteriLog tablosu oluþturuldu
CREATE TABLE MusteriLog (
    musteri_id INT PRIMARY KEY IDENTITY(1,1),
    m_ad VARCHAR(20) NOT NULL,
    m_soyad VARCHAR(20) NOT NULL,
    adres VARCHAR(50) NOT NULL,
    telefon_numarasi BIGINT,
	email VARCHAR(100),
	degistirilme_tarihi DATE
);


/*Trigger yapýsý kullanýldý. Musteri tablosunda yapýlan herhangi bir deðiþiklik MusteriLog
tablosunda deðþtirilme tarihiyle birlikte tutulur*/
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

--Trigger yapýsýný test etmek amacýyla bir müþterinin bilgileri güncellenmiþtir.
UPDATE Musteri SET adres = 'nilüfer-bursa' WHERE m_ad = 'ilayda' AND m_soyad = 'yýldýrým' AND email = 'ilaydayildirim@gmail.com';
