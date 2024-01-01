FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
RUN ls -R
COPY . .
RUN ls -R
RUN dotnet restore "./src/Mangarr.Backend/Mangarr.Backend.csproj"
COPY . .
RUN dotnet build "./src/Mangarr.Backend/Mangarr.Backend.csproj" -c Release -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./src/Mangarr.Backend/Mangarr.Backend.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Mangarr.Backend.dll"]
