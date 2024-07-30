# Nome do projeto
PROJECT_NAME = InvestmentApp

# Comandos
install:
    @echo "Instalando dependências em .net"
    dotnet restore

start:
    @echo "Iniciando a aplicação Investment.API BackEnd"
    dotnet run --project ./src/Investment.API  --launch-profile "https" 

start:
    @echo "Executando a aplicação Investment.View FrontEnd"
    dotnet run --project ./src/Investment.View

test:
    @echo "Executando projeto de tests"
    dotnet test ./tests/Investment.Tests

build:
    @echo "Construindo a aplicação"
    dotnet build

clean:
    @echo "Limpando arquivos de build"
    dotnet clean

.DEFAULT_GOAL := help