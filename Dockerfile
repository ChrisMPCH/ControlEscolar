# Etapa build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copiar la solución y los proyectos
COPY ControlEscolar/ControlEscolar.sln .
COPY CORE/CORE.csproj ./CORE/
COPY API_Estudiantes_Test/API_Estudiantes_Test.csproj ./API_Estudiantes_Test/

# Restaurar dependencias
RUN dotnet restore

# Copiar el resto del código fuente
COPY CORE/ ./CORE/
COPY API_Estudiantes_Test/ ./API_Estudiantes_Test/

# Publicar la aplicación
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
