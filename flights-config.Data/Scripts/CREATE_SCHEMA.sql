CREATE TABLE Airports
(
     AirportId uuid not null,
     IATACode varchar(5) not null,
     Name varchar(255) not null,
     City varchar(255) not null,
     Country varchar(3) not null,
     Constraint PK_Airports primary key (AirportId)
)

insert into Airports(AirportId, name, iataCode, city, country) values('b4b90d8f-26f9-456b-bafb-751c040cf9f6', 'Aeroporto Internacional de Guarulhos', 'GRU', 'São Paulo', 'BR')
select * from Airports