# Etapa build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copiar archivo de proyecto y restaurar dependencias
COPY ControlEscolar.csproj ./
RUN dotnet restore

# Copiar todo el código fuente y publicar en modo Release en /app/out
COPY . ./
RUN dotnet publish ControlEscolar.csproj -c Release -o /app/out

# Etapa runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

# Copiar los archivos publicados desde la etapa build
COPY --from=build /app/out .

# Exponer puertos HTTP y HTTPS
EXPOSE 80
EXPOSE 443

# Comando para iniciar la aplicación
ENTRYPOINT ["dotnet", "ControlEscolar.dll"]
