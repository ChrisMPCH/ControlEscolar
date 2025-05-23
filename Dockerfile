# Etapa de construcción
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copia todo
COPY . ./

# Publica la solución (ajusta el nombre si tu .sln es diferente)
RUN dotnet publish ControlEscolar.sln -c Release -o /app/out

# Etapa final
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .
EXPOSE 80
EXPOSE 443

# Busca el DLL principal de la API
RUN find . -name "*.dll" | grep -i api

# Entrypoint dinámico
ENTRYPOINT ["sh", "-c", "dotnet $(find . -name \"*API.dll\" | head -1)"]