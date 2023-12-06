#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["HR.Api/HR.Api.csproj", "HR.Api/"]
COPY ["HR.Application/HR.Application.csproj", "HR.Application/"]
COPY ["HR.Domain/HR.Domain.csproj", "HR.Domain/"]
COPY ["HR.CrossCutting/HR.CrossCutting.csproj", "HR.CrossCutting/"]
COPY ["HR.Infrastructure/HR.Infrastructure.csproj", "HR.Infrastructure/"]
COPY ["HR.CrossCutting.Ioc/HR.CrossCutting.Ioc.csproj", "HR.CrossCutting.Ioc/"]
COPY ["HR.Service/HR.Service.csproj", "HR.Service/"]
RUN dotnet restore "./HR.Api/./HR.Api.csproj"
COPY . .
WORKDIR "/src/HR.Api"
RUN dotnet build "./HR.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./HR.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HR.Api.dll"]