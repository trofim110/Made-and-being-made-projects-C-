FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Counting method of the class/Counting method of the class.csproj", "Counting method of the class/"]
RUN dotnet restore "Counting method of the class/Counting method of the class.csproj"
COPY . .
WORKDIR "/src/Counting method of the class"
RUN dotnet build "Counting method of the class.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Counting method of the class.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Counting method of the class.dll"]
