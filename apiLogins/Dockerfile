FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["apiLogins.csproj", "apiLogins/"]
RUN dotnet restore "apiLogins/apiLogins.csproj"
COPY . .
WORKDIR "/src"
RUN dotnet build "apiLogins.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "apiLogins.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "apiLogins.dll"]