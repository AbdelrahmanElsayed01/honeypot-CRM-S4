FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["HoneypotCRMS4/HoneypotCRMS4.csproj", "HoneypotCRMS4/"]
RUN dotnet restore "HoneypotCRMS4/HoneypotCRMS4.csproj"
COPY . .
WORKDIR "/src/HoneypotCRMS4"
RUN dotnet build "HoneypotCRMS4.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "HoneypotCRMS4.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HoneypotCRMS4.dll"]
