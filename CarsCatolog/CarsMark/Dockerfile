#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 71
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["CarsMark/CarsMark.csproj", "CarsMark/"]
RUN dotnet restore "CarsMark/CarsMark.csproj"
COPY . .
WORKDIR "/src/CarsMark"
RUN dotnet build "CarsMark.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CarsMark.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CarsMark.dll"]