FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["OrderService/OrderService.csproj", "OrderService/"]
RUN dotnet restore "OrderService/OrderService.csproj"
COPY . .
WORKDIR "/src/OrderService"
RUN dotnet build "OrderService.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "OrderService.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "OrderService.dll"]
#
#FROM microsoft/dotnet:2.2-aspnetcore-runtime
#WORKDIR /app
#
## copy csproj and restore as distinct layers
#COPY *.csproj ./
#RUN dotnet restore
#
## copy and build everything else
#COPY . ./
#RUN dotnet publish -c Release -o out
#ENTRYPOINT ["dotnet", "OrderService.dll"]