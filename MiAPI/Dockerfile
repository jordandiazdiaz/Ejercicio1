FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MiAPI/MiAPI.csproj", "MiAPI/"]
RUN dotnet restore "MiAPI/MiAPI.csproj"
COPY . .
WORKDIR "/src/MiAPI"
RUN dotnet build "MiAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MiAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MiAPI.dll"]
