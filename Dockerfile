# Etapa build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copiar todo el código fuente
COPY . .

# Restaurar dependencias y publicar
RUN dotnet restore
RUN dotnet publish API_Estudiantes_Test/API_Estudiantes_Test.csproj -c Release -o /app/out

# Etapa runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

# Copiar los archivos publicados desde la etapa build
COPY --from=build /app/out .

# Exponer puertos HTTP y HTTPS
EXPOSE 80
EXPOSE 443

# Comando para iniciar la aplicación
ENTRYPOINT ["dotnet", "API_Estudiantes_Test.dll"]
