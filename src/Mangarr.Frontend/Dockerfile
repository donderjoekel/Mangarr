FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY . .
RUN dotnet restore "./src/Mangarr.Frontend/Mangarr.Frontend.csproj"
COPY . .
RUN dotnet build "./src/Mangarr.Frontend/Mangarr.Frontend.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "./src/Mangarr.Frontend/Mangarr.Frontend.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Mangarr.Frontend.dll"]
