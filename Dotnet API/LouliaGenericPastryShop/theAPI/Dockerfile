
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
 
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["theAPI.csproj", "theAPI/"]
RUN dotnet restore "theAPI/theAPI.csproj"
WORKDIR "/src/theAPI"
COPY . .
RUN dotnet build "theAPI.csproj" -c Release -o /app/build
 
FROM build AS publish
RUN dotnet publish "theAPI.csproj" -c Release -o /app/publish
 
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
CMD ASPNETCORE_URLS=http://*:$PORT dotnet theAPI.dll
