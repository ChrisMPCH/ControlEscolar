# Etapa de construcción
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copia solo los archivos necesarios (mejor práctica)
COPY *.csproj ./
RUN dotnet restore

# Copia el resto y publica
COPY . ./
RUN dotnet publish -c Release -o out --no-restore

# Etapa final
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .
EXPOSE 80
EXPOSE 443
ENTRYPOINT ["dotnet", "ControlEscolar.dll"]