FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app
COPY . ./

# Solo necesario si no puedes modificar el .csproj:
# RUN dotnet publish "ControlEscolar.csproj" -c Release -o out -p:EnableWindowsTargeting=true

# Idealmente después de modificar el .csproj:
RUN dotnet publish "ControlEscolar.csproj" -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .
EXPOSE 80
EXPOSE 443
ENTRYPOINT ["dotnet", "ControlEscolar.dll"]