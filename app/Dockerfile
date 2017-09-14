FROM microsoft/aspnetcore-build:2.0 AS build-env
WORKDIR /app

COPY *.csproj ./
COPY *.sh ./
RUN dotnet restore

COPY . ./
RUN dotnet publish -c Release -o out

FROM microsoft/aspnetcore:2.0
ENV ConnectionStrings:Sqlite="Data Source=smitten.db" # for local db
ENV ConnectionStrings:DefaultConnection="Server=db;Database=smittendb;User=sa;Password=Abc12345" # for mssql-linux container
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "Smitten.Api.dll"]
