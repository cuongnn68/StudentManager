# RM
# if in local test need create dev cert
# dotnet dev-certs https -ep ${HOME}/.aspnet/https/aspnetapp.pfx -p { password here }
# dotnet dev-certs https --trust

# add cert
# docker run --rm -it -p 8000:80 -p 8001:443 
#             -e ASPNETCORE_URLS="https://+;http://+" 
#             -e ASPNETCORE_HTTPS_PORT=8001 -e ASPNETCORE_Kestrel__Certificates__Default__Password="password" 
#             -e ASPNETCORE_Kestrel__Certificates__Default__Path=/https/aspnetapp.pfx 
#             -v ${HOME}/.aspnet/https:/https/ tes-app


# build -> out folder -------------------------------
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /app

# ENTRYPOINT ["dotnet", "dev-certs", "https", "-ep", "/app/cert/cert-aspnetcore.pfx", "-p", "password"]


COPY *.csproj ./
RUN  dotnet restore


COPY . .
RUN dotnet publish -c Release -o out
# -------------------------------------------------


# build image to public ---------------------------
FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build-env /app/out .
# COPY --from=build-env /app/cert .

# ENV Kestrel__Certificates__Default__Path=/app/cert-aspnetcore.pfx
# ENV Kestrel__Certificates__Default__Password=password

EXPOSE 8000
EXPOSE 8001
# ENV ASPNETCORE_URLS=https://[::]:443;http://[::]:80;

ENTRYPOINT ["dotnet", "StudentManager.dll"]