#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["VODocker/APIRest_ASPNET5.csproj", "VODocker/"]
RUN dotnet restore "VODocker/APIRest_ASPNET5.csproj"
COPY . .
WORKDIR "/src/VODocker"
RUN dotnet build "APIRest_ASPNET5.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "APIRest_ASPNET5.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "APIRest_ASPNET5.dll"]
