FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

# Copy only the .csproj file first to optimize the build caching
COPY ["RGIS_WebApp/RGIS_WebApp.csproj", "./"]
RUN dotnet restore "RGIS_WebApp.csproj"

# Copy the entire project files
COPY . .

WORKDIR "/src"
RUN dotnet build -c Release -o /app/build

FROM build AS publish
RUN dotnet publish -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RGIS_WebApp.dll"]