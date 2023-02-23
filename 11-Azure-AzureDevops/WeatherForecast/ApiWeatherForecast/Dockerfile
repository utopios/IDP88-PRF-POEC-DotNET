# microsoft a séparé le sdk du runtime (compilation et exécution) 
# donc on devra utiliser 2 images différentes (multi-stage)

# Image du build
FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine AS build 
# AS build renome l'image (qui sera gardee en cache plus tard)
WORKDIR /app 
# on se déplace dans un dossier /app
COPY . . 
# on vient y copier les fichiers du projet
RUN dotnet restore 
# on restore les dépendances
RUN dotnet publish -c Release -o bin 
# publish permet de publier le projet, ici dans le dossier bin 
# cela génère les dll comme si on allait déployer le projet => port 80

# image du runtime
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app

COPY --from=build /app/bin . 
# on copie le dll du build vers le runtime pour pouvoir l'éxécuter
CMD ["dotnet", "ApiWeatherForecast.dll"] 
# on exécute le dll

# commande à utiliser pour build l'image :
# on devra se déplacer dans le dossier du dokerfile avant d'éxécuter la commande suivante
# docker build -t apiweatherforecast-image .

# commande à utiliser pour lancer le conteneur depuis l'image :
# docker run -d -p 4242:80 --name api apiweatherforecast-image