# syntax=docker/dockerfile:1
FROM mcr.microsoft.com/dotnet/sdk:6.0 as build-env
WORKDIR /app
COPY . ./
RUN dotnet restore
RUN dotnet publish -c release -o out
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /App
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "Backend.System.dll"]
