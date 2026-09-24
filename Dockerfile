# Imagen base de ejecución
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
WORKDIR /app
EXPOSE 10000
ENV ASPNETCORE_URLS=http://+:10000

# Imagen del SDK para compilar y restaurar
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
COPY ["ApiApp.csproj", "./"]
RUN dotnet restore "ApiApp.csproj"
COPY . .
RUN dotnet build "ApiApp.csproj" -c Release -o /app/build

# Publicación de la aplicación
FROM build AS publish
RUN dotnet publish "ApiApp.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Imagen final de ejecución
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ApiApp.dll"]
