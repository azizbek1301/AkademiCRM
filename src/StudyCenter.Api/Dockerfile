#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/StudyCenter.Api/StudyCenter.Api.csproj", "src/StudyCenter.Api/"]
COPY ["src/Authorizatsiya.Api/Authorizatsiya.Api.csproj", "src/Authorizatsiya.Api/"]
COPY ["src/StudyCenter.Domain/StudyCenter.Domain.csproj", "src/StudyCenter.Domain/"]
COPY ["src/StudyCenter.Infrastructure/StudyCenter.Infrastructure.csproj", "src/StudyCenter.Infrastructure/"]
COPY ["src/StudyCenter.Service/StudyCenter.Service.csproj", "src/StudyCenter.Service/"]
RUN dotnet restore "./src/StudyCenter.Api/./StudyCenter.Api.csproj"
COPY . .
WORKDIR "/src/src/StudyCenter.Api"
RUN dotnet build "./StudyCenter.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./StudyCenter.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "StudyCenter.Api.dll"]