#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["CarsCatolog/CarsCatolog.csproj", "CarsCatolog/"]
RUN dotnet restore "CarsCatolog/CarsCatolog.csproj"
COPY . .
WORKDIR "/src/CarsCatolog"
RUN dotnet build "CarsCatolog.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CarsCatolog.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CarsCatolog.dll"]