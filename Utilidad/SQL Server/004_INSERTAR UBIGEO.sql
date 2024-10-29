
GO
USE DB_CARRITO


go


INSERT INTO DEPARTAMENTO(IdDepartamento, Descripcion) VALUES
('01', 'Amazonas'),
('02', 'Antioquia'),
('03', 'Arauca'),
('04', 'Atl�ntico'),
('05', 'Bol�var'),
('06', 'Boyac�'),
('07', 'Caldas'),
('08', 'Caquet�'),
('09', 'Casanare'),
('10', 'Cauca'),
('11', 'Cesar'),
('12', 'Choc�'),
('13', 'C�rdoba'),
('14', 'Cundinamarca'),
('15', 'Guain�a'),
('16', 'Guaviare'),
('17', 'Huila'),
('18', 'La Guajira'),
('19', 'Magdalena'),
('20', 'Meta'),
('21', 'Nari�o'),
('22', 'Norte de Santander'),
('23', 'Putumayo'),
('24', 'Quind�o'),
('25', 'Risaralda'),
('26', 'San Andr�s, Providencia y Santa Catalina'),
('27', 'Santander'),
('28', 'Sucre'),
('29', 'Tolima'),
('30', 'Valle del Cauca'),
('31', 'Vaup�s'),
('32', 'Vichada');


go


INSERT INTO PROVINCIA(IdProvincia, Descripcion, IdDepartamento) VALUES
-- Amazonas
('0101', 'Leticia', '01'),
-- Antioquia
('0201', 'Medell�n', '02'),
('0202', 'Bello', '02'),
('0203', 'Itag��', '02'),
('0204', 'Envigado', '02'),
('0205', 'Rionegro', '02'),
('0206', 'Sabaneta', '02'),
-- Arauca
('0301', 'Arauca', '03'),
-- Atl�ntico
('0401', 'Barranquilla', '04'),
('0402', 'Soledad', '04'),
('0403', 'Malambo', '04'),
('0404', 'Sabanalarga', '04'),
('0405', 'Puerto Colombia', '04'),
-- Bol�var
('0501', 'Cartagena', '05'),
('0502', 'Magangu�', '05'),
-- Boyac�
('0601', 'Tunja', '06'),
('0602', 'Duitama', '06'),
('0603', 'Sogamoso', '06'),
-- Caldas
('0701', 'Manizales', '07'),
('0702', 'La Dorada', '07'),
-- Caquet�
('0801', 'Florencia', '08'),
-- Casanare
('0901', 'Yopal', '09'),
-- Cauca
('1001', 'Popay�n', '10'),
('1002', 'Santander de Quilichao', '10'),
-- Cesar
('1101', 'Valledupar', '11'),
('1102', 'Aguachica', '11'),
-- Choc�
('1201', 'Quibd�', '12'),
-- C�rdoba
('1301', 'Monter�a', '13'),
('1302', 'Ceret�', '13'),
('1303', 'Sahag�n', '13'),
-- Cundinamarca
('1401', 'Bogot�', '14'),
('1402', 'Soacha', '14'),
('1403', 'Zipaquir�', '14'),
('1404', 'Facatativ�', '14'),
-- Guain�a
('1501', 'In�rida', '15'),
-- Guaviare
('1601', 'San Jos� del Guaviare', '16'),
-- Huila
('1701', 'Neiva', '17'),
('1702', 'Pitalito', '17'),
-- La Guajira
('1801', 'Riohacha', '18'),
('1802', 'Maicao', '18'),
-- Magdalena
('1901', 'Santa Marta', '19'),
('1902', 'Ci�naga', '19'),
-- Meta
('2001', 'Villavicencio', '20'),
('2002', 'Acac�as', '20'),
-- Nari�o
('2101', 'Pasto', '21'),
('2102', 'Ipiales', '21'),
-- Norte de Santander
('2201', 'C�cuta', '22'),
('2202', 'Oca�a', '22'),
-- Putumayo
('2301', 'Mocoa', '23'),
-- Quind�o
('2401', 'Armenia', '24'),
('2402', 'Montenegro', '24'),
-- Risaralda
('2501', 'Pereira', '25'),
('2502', 'Dosquebradas', '25'),
-- San Andr�s y Providencia
('2601', 'San Andr�s', '26'),
-- Santander
('2701', 'Bucaramanga', '27'),
('2702', 'Floridablanca', '27'),
('2703', 'Gir�n', '27'),
-- Sucre
('2801', 'Sincelejo', '28'),
('2802', 'Corozal', '28'),
-- Tolima
('2901', 'Ibagu�', '29'),
('2902', 'Espinal', '29'),
-- Valle del Cauca
('3001', 'Cali', '30'),
('3002', 'Palmira', '30'),
-- Vaup�s
('3101', 'Mit�', '31'),
-- Vichada
('3201', 'Puerto Carre�o', '32');



go



INSERT INTO DISTRITO(IdDistrito, Descripcion, IdProvincia, IdDepartamento) VALUES
-- Amazonas (01)
('010101', 'Leticia', '0101', '01'),
-- Antioquia (02)
('020101', 'Medell�n', '0201', '02'),
('020102', 'Bello', '0202', '02'),
('020103', 'Itag��', '0203', '02'),
('020104', 'Envigado', '0204', '02'),
('020105', 'Rionegro', '0205', '02'),
('020106', 'Sabaneta', '0206', '02'),
-- Arauca (03)
('030101', 'Arauca', '0301', '03'),
-- Atl�ntico (04)
('040101', 'Barranquilla', '0401', '04'),
('040102', 'Soledad', '0402', '04'),
('040103', 'Malambo', '0403', '04'),
-- Bol�var (05)
('050101', 'Cartagena', '0501', '05'),
('050102', 'Magangu�', '0502', '05'),
-- Boyac� (06)
('060101', 'Tunja', '0601', '06'),
('060102', 'Duitama', '0602', '06'),
('060103', 'Sogamoso', '0603', '06'),
-- Caldas (07)
('070101', 'Manizales', '0701', '07'),
('070102', 'La Dorada', '0702', '07'),
-- Caquet� (08)
('080101', 'Florencia', '0801', '08'),
-- Casanare (09)
('090101', 'Yopal', '0901', '09'),
-- Cauca (10)
('100101', 'Popay�n', '1001', '10'),
('100102', 'Santander de Quilichao', '1002', '10'),
-- Cesar (11)
('110101', 'Valledupar', '1101', '11'),
('110102', 'Aguachica', '1102', '11'),
-- Choc� (12)
('120101', 'Quibd�', '1201', '12'),
-- C�rdoba (13)
('130101', 'Monter�a', '1301', '13'),
('130102', 'Ceret�', '1302', '13'),
('130103', 'Sahag�n', '1303', '13'),
-- Cundinamarca (14)
('140101', 'Bogot�', '1401', '14'),
('140102', 'Soacha', '1402', '14'),
('140103', 'Zipaquir�', '1403', '14'),
-- Guain�a (15)
('150101', 'In�rida', '1501', '15'),
-- Guaviare (16)
('160101', 'San Jos� del Guaviare', '1601', '16'),
-- Huila (17)
('170101', 'Neiva', '1701', '17'),
('170102', 'Pitalito', '1702', '17'),
-- La Guajira (18)
('180101', 'Riohacha', '1801', '18'),
('180102', 'Maicao', '1802', '18'),
-- Magdalena (19)
('190101', 'Santa Marta', '1901', '19'),
('190102', 'Ci�naga', '1902', '19'),
-- Meta (20)
('200101', 'Villavicencio', '2001', '20'),
('200102', 'Acac�as', '2002', '20'),
-- Nari�o (21)
('210101', 'Pasto', '2101', '21'),
('210102', 'Ipiales', '2102', '21'),
-- Norte de Santander (22)
('220101', 'C�cuta', '2201', '22'),
('220102', 'Oca�a', '2202', '22'),
-- Putumayo (23)
('230101', 'Mocoa', '2301', '23'),
-- Quind�o (24)
('240101', 'Armenia', '2401', '24'),
('240102', 'Montenegro', '2402', '24'),
-- Risaralda (25)
('250101', 'Pereira', '2501', '25'),
('250102', 'Dosquebradas', '2502', '25'),
-- San Andr�s y Providencia (26)
('260101', 'San Andr�s', '2601', '26'),
-- Santander (27)
('270101', 'Bucaramanga', '2701', '27'),
('270102', 'Floridablanca', '2702', '27'),
('270103', 'Gir�n', '2703', '27'),
-- Sucre (28)
('280101', 'Sincelejo', '2801', '28'),
('280102', 'Corozal', '2802', '28'),
-- Tolima (29)
('290101', 'Ibagu�', '2901', '29'),
('290102', 'Espinal', '2902', '29'),
-- Valle del Cauca (30)
('300101', 'Cali', '3001', '30'),
('300102', 'Palmira', '3002', '30'),
-- Vaup�s (31)
('310101', 'Mit�', '3101', '31'),
-- Vichada (32)
('320101', 'Puerto Carre�o', '3201', '32');
