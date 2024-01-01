FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Mangarr.Backend/Mangarr.Backend.csproj", "Mangarr.Backend/"]
COPY ["Mangarr.Shared/Mangarr.Shared.csproj", "Mangarr.Shared/"]
RUN dotnet restore "Mangarr.Backend/Mangarr.Backend.csproj"
COPY . .
WORKDIR "/src/Mangarr.Backend"
RUN dotnet build "Mangarr.Backend.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Mangarr.Backend.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Mangarr.Backend.dll"]
