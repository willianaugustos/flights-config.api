®
d/Users/willian/Projetos/Flights/flights-config.api/flights-config.Domain/Flights/Entities/Airline.cs
	namespace 	
flights_config
 
. 
Domain 
.  
Entities  (
;( )
public 
class 
Airline 
{ 
public 

string 
Name 
{ 
get 
; 
set !
;! "
}# $
=% &
string' -
.- .
Empty. 3
;3 4
} ¹
d/Users/willian/Projetos/Flights/flights-config.api/flights-config.Domain/Flights/Entities/Airport.cs
	namespace 	
flights_config
 
. 
Domain 
.  
Entities  (
;( )
public 
class 
Airport 
{ 
public 

String 
? 
IATACode 
{ 
get  
;  !
set! $
;$ %
}% &
public 

string 
? 
Name 
{ 
get 
; 
set "
;" #
}$ %
public 

City 
? 
City 
{ 
get 
; 
set  
;  !
}" #
} …
a/Users/willian/Projetos/Flights/flights-config.api/flights-config.Domain/Flights/Entities/City.cs
	namespace 	
flights_config
 
. 
Domain 
.  
Entities  (
;( )
public 
class 
City 
{ 
public 

string 
Name 
{ 
get 
; 
set 
;  
}  !
=" #
string$ *
.* +
Empty+ 0
;0 1
public 

string 
Country 
{ 
get 
; 
set "
;" #
}# $
=% &
string' -
.- .
Empty. 3
;3 4
public 

string 
Region 
{ 
get 
; 
set !
;! "
}" #
=$ %
string& ,
., -
Empty- 2
;2 3
} Ý
j/Users/willian/Projetos/Flights/flights-config.api/flights-config.Domain/Flights/Entities/ECabinClasses.cs
	namespace 	
flights_config
 
. 
Domain 
.  
Entities  (
;( )
public 
enum 
ECabinClasses 
{ 
Economy 
= 
$num 
, 
PremiumEconomy 
= 
$num 
, 
Business 
= 
$num 
, 

FirstClass 
= 
$num 
} Á
g/Users/willian/Projetos/Flights/flights-config.api/flights-config.Domain/Flights/Entities/EPriceType.cs
	namespace 	
flights_config
 
. 
Domain 
.  
Entities  (
;( )
public 
enum 

EPriceType 
{ 
Currency 
= 
$num 
, 
Miles 	
=
 
$num 
} ù
c/Users/willian/Projetos/Flights/flights-config.api/flights-config.Domain/Flights/Entities/Flight.cs
	namespace 	
flights_config
 
. 
Domain 
.  
Entities  (
;( )
public 
class 
Flight 
{ 
public 

Airport 
? 
Origin 
{ 
get 
;  
set  #
;# $
}$ %
public 

Airport 
? 
Destination 
{  !
get! $
;$ %
set% (
;( )
}) *
public 

int 
Stops 
{ 
get 
; 
set 
; 
} 
public 

IList 
< 
Segment 
> 
Segments "
{# $
get$ '
;' (
set( +
;+ ,
}, -
=. /
new0 3
List4 8
<8 9
Segment9 @
>@ A
(A B
)B C
;C D
public		 

Decimal		 
Price		 
{		 
get		 
;		 
set		 !
;		! "
}		" #
public

 


EPriceType

 
	PriceType

 
{

  !
get

! $
;

$ %
set

% (
;

( )
}

) *
public 

String 
? 
CurrencySign 
{  !
get! $
;$ %
set% (
;( )
}) *
} Å

d/Users/willian/Projetos/Flights/flights-config.api/flights-config.Domain/Flights/Entities/Segment.cs
	namespace 	
flights_config
 
. 
Domain 
.  
Entities  (
;( )
public 
class 
Segment 
{ 
public 

Airline 
? 
Airline 
{ 
get  
;  !
set! $
;$ %
}% &
public 

String 
? 
Number 
{ 
get 
; 
set "
;" #
}# $
public 

Airport 
? 
Origin 
{ 
get 
;  
set  #
;# $
}$ %
public 

Airport 
? 
Destination 
{  !
get! $
;$ %
set% (
;( )
}) *
public		 

ECabinClasses		 

CabinClass		 #
{		$ %
get		% (
;		( )
set		) ,
;		, -
}		- .
public

 

String

 
?

 
LoyaltyProgram

 !
{

" #
get

# &
;

& '
set

' *
;

* +
}

+ ,
} ã
p/Users/willian/Projetos/Flights/flights-config.api/flights-config.Domain/Flights/Services/SearchFlightHandler.cs
	namespace 	
flights_config
 
. 
Domain 
.  
Services  (
;( )
public 
class  
SearchFlightsHandler !
:" #
IRequestHandler$ 3
<3 4 
SearchFlightsRequest4 H
>H I
{ 
Task 
< 	
Unit	 
> 
IRequestHandler 
<  
SearchFlightsRequest 3
,3 4
Unit5 9
>9 :
.: ;
Handle; A
(A B 
SearchFlightsRequestB V
requestW ^
,^ _
CancellationToken` q
cancellationToken	r ƒ
)
ƒ „
{ 
throw		 
new		 #
NotImplementedException		 )
(		) *
)		* +
;		+ ,
}

 
} €
p/Users/willian/Projetos/Flights/flights-config.api/flights-config.Domain/Flights/Services/SearchFlightRequest.cs
	namespace 	
flights_config
 
. 
Domain 
.  
Services  (
;( )
public 
class  
SearchFlightsRequest !
:" #
IRequest$ ,
{ 
} Ý
q/Users/willian/Projetos/Flights/flights-config.api/flights-config.Domain/Flights/Services/SearchFlightResponse.cs
	namespace 	
flights_config
 
. 
Domain 
.  
Services  (
;( )
public 
class !
SearchFlightsResponse "
{ 
} 