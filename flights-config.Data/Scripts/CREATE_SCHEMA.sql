
CREATE TABLE "Airports"
(
     "AirportId" uuid not null,
     "IATACode" varchar(5) not null,
     "Name" varchar(255) not null,
     "City" varchar(255) not null,
     "State" varchar(10) not null,
     "Country" varchar(3) not null,
     Constraint PK_Airports primary key ("AirportId")
)
select * from "Airports"
insert into "Airports"("AirportId", "Name", "IATACode", "City", "State", "Country") values('b4b90d8f-26f9-456b-bafb-751c040cf9f6', 'Aeroporto Internacional de Guarulhos', 'GRU', 'São Paulo', 'SP', 'BR');
insert into "Airports"("AirportId", "Name", "IATACode", "City", "State", "Country") values('b91d4c7e-c016-4954-9cf8-32c5c36faf5d', 'Congonhas', 'CGH', 'São Paulo', 'SP', 'BR');
insert into "Airports"("AirportId", "Name", "IATACode", "City", "State", "Country") values('12e2119a-a596-4078-a258-a35b27a1020c', 'Aeroporto Internacional Afonso Pena', 'CWB', 'Curitiba', 'PR', 'BR');
insert into "Airports"("AirportId", "Name", "IATACode", "City", "State", "Country") values('69826460-8ffd-4fdb-8fa7-3ee51dbd12c4', 'Aeroporto Internacional Salgado Filho', 'POA', 'Porto Alegre', 'RS', 'BR');
insert into "Airports"("AirportId", "Name", "IATACode", "City", "State", "Country") values('7ec174c5-692b-4d17-9379-009fa58b307b', 'Aeroporto Governador José Richa', 'LDB', 'Londrina', 'PR', 'BR');
insert into "Airports"("AirportId", "Name", "IATACode", "City", "State", "Country") values('be795bd0-3fa1-4288-abde-19637e008b3a', 'Aeroporto Santos Dumont', 'SDU', 'Rio de Janeiro', 'RJ', 'BR');
insert into "Airports"("AirportId", "Name", "IATACode", "City", "State", "Country") values('6684c5f8-326c-4164-9973-f1e7b4df8555', 'Aeroporto Internacional Tom Jobim-Galeão', 'GIG', 'Rio de Janeiro', 'RJ', 'BR');
select * from Airports


alter user postgres with password  'mystrongpass'