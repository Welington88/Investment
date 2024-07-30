PROJECT_NAME = InvestmentApp

install:
	@echo "Instalando dependências em .net"
	cd src/Investment.View/ClientApp && npm install

start-backend:
	@echo "Iniciando a aplicação Investment.API BackEnd"
	cd ./ && dotnet run --project ./src/Investment.API  --launch-profile "https" 

start-frontend:
	@echo "Iniciando a aplicação Investment.API Frontend"
	cd ./ && dotnet run --project ./src/Investment.View	

test:
	@echo "Executando projeto de tests"
	dotnet test ./tests/Investment.Tests

build:
	@echo "Construindo a aplicação"
	dotnet build

clean:
	@echo "Limpando arquivos de build"
	dotnet clean