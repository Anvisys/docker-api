#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["docker-api/docker-api.csproj", "docker-api/"]
RUN dotnet restore "docker-api/docker-api.csproj"

WORKDIR "/src/docker-api"
COPY . .
RUN dotnet build "docker-api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "docker-api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "docker-api.dll"]