# Etapa de construcción
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copia todos los archivos del proyecto
COPY . ./

# Publica el proyecto principal (ajusta el nombre si es diferente)
RUN dotnet publish "ControlEscolar.csproj" -c Release -o out

# Etapa final
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

# Copia los archivos publicados desde la etapa de construcción
COPY --from=build /app/out .

# Expone los puertos
EXPOSE 80
EXPOSE 443

# Comando de inicio
ENTRYPOINT ["dotnet", "ControlEscolar.dll"]