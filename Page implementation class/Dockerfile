FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Page implementation class/Page implementation class.csproj", "Page implementation class/"]
RUN dotnet restore "Page implementation class/Page implementation class.csproj"
COPY . .
WORKDIR "/src/Page implementation class"
RUN dotnet build "Page implementation class.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Page implementation class.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Page implementation class.dll"]
