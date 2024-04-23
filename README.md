# MicroServiço - Servidor de Identidade

!['log'](https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQiPP0R_WzjKlBQK6VqAlub2zWNIH0FGp3vc2vE7nf5Qs1a8AydETXaszk9Uh0dN-RaaJs&usqp=CAU)

## Escopo 

Serviço Rest, cuja finalidade é prover endpoints de Servidor de Identidade: divididos nos seguintes grupos de serviços:


+ Gerenciamento de plataformas    
+ Gerenciamento de aplicações
+ Gerenciamento de organizações
+ Gerenciamento usuarios
+ Gerenciamento perfil
+ Gerenciamento seguranca


## Diagrama de Entidades e Relacionamentos 


### Tecnologias usadas no microservico

+ API Minimal # .net core 9
+ Banco Sql Server
+ Docker, Containers -> DockerFile



### Arquiteturas

+ CQRS
+ Event Source
+ Broken - Kafka

### Dependencias 




### Instruções para rodar o banco de dados sql sever 

- <a href="#-tec">Tecnologias ultilizadas<a/>

### funcionalidades do projeto

- [x] Cadastro


## Instruções para rodar o projeto 

### 1. Criar um container  de dados SQL Server

as instruções abaixo server para levantar os um container de banco de dados SQL server com para gerir os dados de 
```bash

 # build do docker file exsiteten na pasta sqlserver responsável com as configurações 
 # para criação do container SQL SERVER
 docker build -t sqlserver .

 # criar o container SQL SERVER , gerneciar os dados referente ao Servidor de Identidade exporto a porta 1400
 docker run -d -p 1400:1433 -v C:/data/sqlserver/Identidade:/var/opt/mssql/data --name sqlserver-ID sqlserver

```

 ### 2. Aplicar o Migration 


 ### 3. Aplicar o Seed 


 LinkED
 Foto

 Proximos passos
