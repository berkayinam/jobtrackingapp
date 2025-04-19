# .NET SDK ile uygulamayı build et
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Önce sadece proje dosyasını kopyala ve bağımlılıkları yükle
COPY ./src/JobTracking/JobTracking.csproj ./
RUN dotnet restore JobTracking.csproj

# Şimdi tüm kodları kopyala ve yayınla
COPY ./src/JobTracking/ ./
RUN dotnet publish JobTracking.csproj -c Release -o /out

# ASP.NET Core runtime ile uygulamayı çalıştır
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /out ./

EXPOSE 80
ENV ASPNETCORE_URLS=http://+:80
ENTRYPOINT ["dotnet", "JobTracking.dll"]
