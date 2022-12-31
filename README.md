# flights-config.api

[EN] ![United States](https://raw.githubusercontent.com/stevenrskelton/flag-icon/master/png/16/country-4x3/us.png "United States")
This project is part of my portfolio, learning, and development practice. I want to produce something usable and valuable, but my choice of technologies and the pace of my progress is primarily focused on my learning intents.

The project:
The goal is to have crawler agents inspect the airlines' websites and collect flight information. The search results will be stored in a database and exposed through a rest API. In the beginning, I think is a good idea to keep it open to the world freely, but I'm not sure what will be the future of this initiative.

I plan to contemplate both flights paid by money and by flight miles. 

[PT-BR] ![Brazil](https://raw.githubusercontent.com/stevenrskelton/flag-icon/master/png/16/country-4x3/br.png "Brazil")
## API de informações de vôos
### O objetivo é disponibilizar consultas relacionadas a vôos domésticos e internacionais, para pagamentos tanto com dinheiro como com milhas aéreas

Como esse projeto é um Portifólio e também meu aprendizado, pretendo incluir os seguintes itens:

Para a API:
- Linguagem C#
- Framework .Net Core
- Rest
- Mediatr
- FluentAssertions
- XUnit
- Entity Framework, Dapper
- Dependency Injection (Scoped, Transient, Singleton)
- Design Patterns (Singleton, Decorator, Builder, Strategy, Facade, Mediator, Adapter)
- OO, Solid (SRP, OCP, LSP, ISP, DIP)
- Filters, Attributes, Middleware
- Mapster / automapper
- Autofixture
- Moq
- Serilog ? NLog ? ELK Stack
- Polly
- Swagger

### Message Broker
- Rabbit MQ

### Banco de dados:
-Mysql para tabelas de parâmetros e configurações
-Mongodb (ou dynamo ou cosmosdb) para as informações de vôos
-Redis para Cache

### Autenticação
- OAuth ? AWS Cognito ? Firebase auth?
- JWT

### Robô de captura
-Python
-Scrapy

### Fron-End
-Angular ? React ? 
-Mobile Native ? Kotlin ? Swift ?

### Environment
-Gitflow
-Github
-Git Actions
-Kubernetes
-Docker, Docker-Compose
-IAC
-Terraform
-Oracle OCI, AWS, Azure
