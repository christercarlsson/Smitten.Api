FROM microsoft/aspnetcore-build:2.0 AS build-env
WORKDIR /app

COPY *.csproj ./
RUN dotnet restore

COPY . ./
RUN dotnet publish -c Release -o out

FROM microsoft/aspnetcore:2.0
ENV ConnectionStrings:Sqlite="Data Source=smitten.db"

WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "Smitten.Api.dll"]
