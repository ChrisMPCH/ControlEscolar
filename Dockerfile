<<<<<<< HEAD
# Etapa de construcción
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copiar todos los archivos del proyecto
COPY . ./

# Listar los archivos copiados para depuración
RUN ls -la /app

# Intentar restaurar dependencias
RUN dotnet restore "API_Estudiantes_Test/API_Estudiantes_Test.csproj" || \
    dotnet restore "*/API_Estudiantes_Test.csproj" || \
    echo "No se encontró el proyecto API_Estudiantes_Test.csproj"

# Publicar el proyecto
RUN dotnet publish "API_Estudiantes_Test/API_Estudiantes_Test.csproj" -c Release -o /app/out || \
    dotnet publish "*/API_Estudiantes_Test.csproj" -c Release -o /app/out || \
    echo "No se pudo publicar el proyecto API_Estudiantes_Test"

# Verificar que el directorio de salida exista
RUN ls -la /app/out

# Etapa final
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .

# Exponer puertos
EXPOSE 80
EXPOSE 443
EXPOSE 8080
EXPOSE 5000

# Configuración de variables de entorno para Render
ENV ASPNETCORE_URLS=http://+:8080

# Entrypoint dinámico que busca el archivo API.dll
ENTRYPOINT ["sh", "-c", "dotnet $(find . -name \"*API.dll\" | head -1)"]
=======
# Etapa build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copiar archivos de solución y proyecto
COPY *.sln .
COPY API_Estudiantes_Test/API_Estudiantes_Test.csproj ./API_Estudiantes_Test/
RUN dotnet restore

# Copiar todo el código fuente
COPY . ./

# Publicar la aplicación
WORKDIR /app/API_Estudiantes_Test
RUN dotnet publish -c Release -o /app/out

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
>>>>>>> Cambios preVane
