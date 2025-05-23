# Etapa de construcción
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY . ./

# Cambia el directorio de trabajo a la raíz del repo (donde está el .sln)
WORKDIR /src

RUN dotnet restore ControlEscolar.sln
RUN dotnet publish ControlEscolar.sln -c Release -o /app/out

# Etapa final
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .
EXPOSE 80
EXPOSE 443

# Busca el DLL principal de la API
RUN find . -name "*.dll" | grep -i api

ENTRYPOINT ["sh", "-c", "dotnet $(find . -name \"*API.dll\" | head -1)"]