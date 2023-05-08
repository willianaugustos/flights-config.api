
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

insert into "Airports"("AirportId", "Name", "IATACode", "City", "State", "Country") values('4e4afdd0-6a18-435e-bfa3-bd94f90faa3b', 'Aeroporto Internacional John F. Kennedy', 'JFK', 'Nova York', 'NY', 'USA');

create table "Airlines"
(
     "AirlineId" uuid not null,
     "Name" varchar(100) not null,
     constraint "PK_Airlines" primary key("AirlineId")
)

insert into "Airlines"("AirlineId","Name") values('7b32c667-727b-47a8-9162-f51441755297', 'Latam');
insert into "Airlines"("AirlineId","Name") values('ba6209ef-5e26-4df7-95c0-c6e98da8f06a', 'GOL');
insert into "Airlines"("AirlineId","Name") values('647e9fcb-0d7b-4611-b598-1665f39ab386', 'Azul');
insert into "Airlines"("AirlineId","Name") values('ca884284-c644-4191-a4a6-bd94d3c60b2f', 'KLM');
insert into "Airlines"("AirlineId","Name") values('4e560065-a5b7-4e8f-80e1-b74b5cd48570', 'Airfrance');
insert into "Airlines"("AirlineId","Name") values('ce61a17a-db15-4aee-9c88-06cf0c69caf8', 'Aircanada');
insert into "Airlines"("AirlineId","Name") values('dcad677f-5e52-4ed3-9731-1eaf5f1e777d', 'TAP');
insert into "Airlines"("AirlineId","Name") values('e01ae4c6-4ebe-4de9-a136-873e41204e1c', 'Delta');

create index ix_name on "Airlines" ("Name")
--select * from "Airlines"

create table "Flights"
(
     "FlightId" uuid not null,
     "AirportOrigin" varchar(3) not null,
     "AirportDestination" varchar(3) not null,
     "AirlineId" uuid not null,
     "Stops" int not null,
     "Price" decimal(15,2),
     "PriceType" int not null,
     "CurrencySign" varchar(15) not null,
     "SearchDate" timestamp not null,
     "SourceUrl" varchar(1000) null,
     "SourceName" varchar(100) not null,
     "LoyaltyProgram" varchar(100) null,
     "DepartureDate" date not null,
     "DepartureTime" varchar(8) not null,
     "ArrivalTime" varchar(8) not null,
     "ArrivalDateRelative" varchar(10) null,
     "Duration" varchar(20) not null,
     "AdditionalInfo" varchar(100) null,
     "LinkedFlightId"uuid null,
     Constraint PK_Flights primary key ("FlightId")
)

create table "FlightSegments"
(
     "FlightId" uuid not null,
     "SegmentNumber" int not null,
     "Airline" uuid not null,
     "FlightNumber" varchar(50) null,
     "AirportOrigin" varchar(3) not null,
     "AirportDestination" varchar(3) not null,
     "CabinClass" varchar(10) null,
     "DepartureDate" date not null,
     "DepartureTime" varchar(8) not null,
     "ArrivalTime" varchar(8) not null,
     "ArrivalDateRelative" varchar(10) null,
     "Duration" varchar(20) not null,
     "AdditionalInfo" varchar(100) null,
     Constraint PK_FlightSegments primary key ("FlightId", "SegmentNumber"),
     Constraint FK_FlightSegments_Flights foreign key ("FlightId") references "Flights"
)
SELECT * FROM "Flights"
insert into "Flights"(
     "FlightId", "AirportOrigin", "AirportDestination", "Stops", "Price", "PriceType", "CurrencySign", "SearchDate", "SourceUrl", "SourceName",
     "LoyaltyProgram", "DepartureDate", "DepartureTime", "ArrivalTime", "ArrivalDateRelative", "Duration", "AdditionalInfo")
 values('a551ec31-45b1-4346-aad0-fc3b354245dd', 'GRU', 'MIA', 1, 1520.88, 1, 'BRL', '2023-01-19 21:57', null, 'Latam',
     null, '2023-05-02', '10:15', '17:30', '', '8 h 15 min.', 'Light');
SELECT * FROM  "FlightSegments"
insert into "FlightSegments"
    ( "FlightId", "SegmentNumber", "Airline", "FlightNumber", "AirportOrigin", "AirportDestination", "CabinClass",
     "DepartureDate",  "DepartureTime", "ArrivalTime", "ArrivalDateRelative", "Duration", "AdditionalInfo")
values('a551ec31-45b1-4346-aad0-fc3b354245dd', 1, 'Latam', 'LA8194', 'GRU', 'MIA', 'Economy', 
     '2023-05-02', '10:15', '17:30', '', '8 h 15 min.', 'Light');


insert into "Flights"(
     "FlightId", "AirportOrigin", "AirportDestination", "AirlineId", "Stops", "Price", "PriceType", "CurrencySign", "SearchDate", "SourceUrl", "SourceName",
     "LoyaltyProgram", "DepartureDate", "DepartureTime", "ArrivalTime", "ArrivalDateRelative", "Duration", "AdditionalInfo",
     "LinkedFlightId")
 values('80d10df9-f6cd-4294-acf3-39daf98e9417', 'MIA', 'GRU', '7b32c667-727b-47a8-9162-f51441755297', 1, 1680.98, 1, 'BRL', '2023-01-19 21:57', null, 'Latam',
     null, '2023-05-16', '13:17', '07:00', '+1', '16 h 43 min.', 'Light', 'a551ec31-45b1-4346-aad0-fc3b354245dd');



insert into "FlightSegments"
    ( "FlightId", "SegmentNumber", "Airline", "FlightNumber", "AirportOrigin", "AirportDestination", "CabinClass",
     "DepartureDate",  "DepartureTime", "ArrivalTime", "ArrivalDateRelative", "Duration", "AdditionalInfo")
values('80d10df9-f6cd-4294-acf3-39daf98e9417', 1, '7b32c667-727b-47a8-9162-f51441755297', 'LA4401*', 'MIA', 'BOG', 'Economy', 
     '2023-05-16', '13:17', '15:59', '', '3 h 42 min.', 'Light')


insert into "FlightSegments"
    ( "FlightId", "SegmentNumber", "Airline", "FlightNumber", "AirportOrigin", "AirportDestination", "CabinClass",
     "DepartureDate",  "DepartureTime", "ArrivalTime", "ArrivalDateRelative", "Duration", "AdditionalInfo")
values('80d10df9-f6cd-4294-acf3-39daf98e9417', 2, '7b32c667-727b-47a8-9162-f51441755297', 'LA2387*', 'BOG', 'LIM', 'Economy', 
     '2023-05-16', '18:30', '21:30', '', '3 h', '7b32c667-727b-47a8-9162-f51441755297')


insert into "FlightSegments"
    ( "FlightId", "SegmentNumber", "Airline", "FlightNumber", "AirportOrigin", "AirportDestination", "CabinClass",
     "DepartureDate",  "DepartureTime", "ArrivalTime", "ArrivalDateRelative", "Duration", "AdditionalInfo")
values('80d10df9-f6cd-4294-acf3-39daf98e9417', 3, '7b32c667-727b-47a8-9162-f51441755297', 'LA8005*', 'LIM', 'GRU', 'Economy', 
     '2023-05-16', '0:05', '7:00', '', '4 h 55 min.', 'Light')