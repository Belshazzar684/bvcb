select * from sys.tables whereexists (select * from sys.tables where name = 'DIADIEM') and exists (select * from sys.tables where name = 'HANGHANGKHONG') and exists (select * from sys.tables where name = 'SANBAY') and exists (select * from sys.tables where name = 'TUYENBAY') and exists (select * from sys.tables where name = 'LICHCHUYENBAY') and exists (select * from sys.tables where name = 'CT_LICHCHUYENBAY') and exists (select * from sys.tables where name = 'HANGVE') and exists (select * from sys.tables where name = 'CT_GHE') and exists (select * from sys.tables where name = 'PHIEUDATCHO') and exists (select * from sys.tables where name = 'CT_PHIEUDATCHO') and exists (select * from sys.tables where name = 'THAMSO')and exists (select * from sys.tables where name = 'BAOCAODOANHTHUNAM')and exists (select * from sys.tables where name = 'BAOCAODOANHTHUTHANG')and exists (select * from sys.tables where name = 'BAOCAODOANHTHUCHUYENBAY')and exists (select * from sys.tables where name = 'NHANVIEN')and exists (select * from sys.tables where name = 'KHACHHANG')and exists (select * from sys.tables where name = 'CHITIETKHACHHANG')