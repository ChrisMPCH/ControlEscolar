# Etapa de build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY . .

WORKDIR /src/ControlEscolar/Api_estudiantes_test

RUN dotnet restore
RUN dotnet publish -c Release -o /app/out

# Etapa final
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .
EXPOSE 80
EXPOSE 443

ENTRYPOINT ["dotnet", "Api_estudiantes_test.dll"]