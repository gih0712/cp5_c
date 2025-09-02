FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["global.csproj", "."]
RUN dotnet restore "./global.csproj"
COPY . .
RUN dotnet build "./global.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "./global.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_ENVIRONMENT=Development
ENTRYPOINT ["dotnet", "global.dll"]
