FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["RGIS_WebApp.csproj", "./"]
RUN dotnet restore "RGIS_WebApp.csproj"
COPY . .
RUN dotnet build "RGIS_WebApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RGIS_WebApp.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RGIS_WebApp.dll"]