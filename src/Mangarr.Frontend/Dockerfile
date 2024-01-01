FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Mangarr.Frontend/Mangarr.Frontend.csproj", "Mangarr.Frontend/"]
COPY ["Mangarr.Shared/Mangarr.Shared.csproj", "Mangarr.Shared/"]
RUN dotnet restore "Mangarr.Frontend/Mangarr.Frontend.csproj"
COPY . .
WORKDIR "/src/Mangarr.Frontend"
RUN dotnet build "Mangarr.Frontend.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Mangarr.Frontend.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Mangarr.Frontend.dll"]
