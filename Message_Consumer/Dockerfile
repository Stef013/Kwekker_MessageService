#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Message_Consumer/Message_Consumer.csproj", "Message_Consumer/"]
RUN dotnet restore "Message_Consumer/Message_Consumer.csproj"
COPY . .
WORKDIR "/src/Message_Consumer"
RUN dotnet build "Message_Consumer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Message_Consumer.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Message_Consumer.dll"]