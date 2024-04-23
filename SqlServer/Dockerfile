# Use a imagem base do SQL Server
FROM mcr.microsoft.com/mssql/server:2019-latest

# Define a variável de ambiente para a senha do sa
ENV ACCEPT_EULA=Y SA_PASSWORD=db@datacontext@2024

# Criar diretório de dados persistente
RUN mkdir -p /var/opt/mssql/data

# Definir o diretório de dados persistente
ENV MSSQL_DATA_DIR=/var/opt/mssql/data

# Definir o diretório de log persistente
ENV MSSQL_LOG_DIR=/var/opt/mssql/log

# Definir o diretório de backup persistente
ENV MSSQL_BACKUP_DIR=/var/opt/mssql/backup

# Copiar o script SQL para criar o banco de dados para o contêiner
COPY create_database.sql /tmp/

# Expor a porta padrão do SQL Server
EXPOSE 1433

# Comando para iniciar o SQL Server quando o contêiner for iniciado
CMD /bin/bash -c '/opt/mssql/bin/sqlservr & /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P $SA_PASSWORD -i /tmp/create_database.sql'


# Definir o diretório de trabalho padrão
WORKDIR /var/opt/mssql

# Comando para iniciar o SQL Server quando o contêiner for iniciado
CMD ["/opt/mssql/bin/sqlservr"]


#docker build -t sqlserver .
#docker run -d -p 1400:1433 -v C:/data/sqlserver/Identidade:/var/opt/mssql/data --name sqlserver-ID sqlserver
