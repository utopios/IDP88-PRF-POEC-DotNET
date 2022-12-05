######################################################################
#				Tp2 - Conteneur Web
######################################################################

## => Démarer un conteneur nommé "My_httpd" en tache de fond à partir de l'image httpd:latest (ne pas oublier le mapping des ports)
## => Se connecter au bash du conteneur (bash)
## => mise à jour de ce conteneur
## => Vérifier sur "http://localhost:8080/" que le message s'affiche bien
## => Changez le message retourné par le serveur web: /usr/local/apache2/htdocs/index.html
## => Vérifier sur "http://localhost:8080/" que le nouveau message s'affiche bien
## => Proceder à l'installation de git
## => Vérifier son installation avec la commande git --version

################################## CORRECTION ####################################

## Recherche l'image httpd:latest
$ docker search httpd:latest

##  Telechargement de l'image
$ docker pull httpd:latest

## Création d'un conteneur basé sur l'image httpd:latest
$ docker run --name=my_httpd -dp 8080:80 httpd:latest

## Se connecter au bash du conteneur (bash)
$ docker exec -ti my_httpd bash

## Mise à jour de ce conteneur et install de nano
$ apt update && apt upgrade -y && apt install nano -y

## Vérifier sur "http://localhost:8080/" que le message s'affiche bien
http://localhost:8080/

## Changez le message retourné par le serveur web: /usr/local/apache2/htdocs/index.html (Solution 1)
$ echo "<h1>J'ai modifie le message</h1>" > /usr/local/apache2/htdocs/index.html

## Changez le message retourné par le serveur web: /usr/local/apache2/htdocs/index.html (Solution 2)
$ cd /usr/local/apache2/htdocs/
$ nano index.html

## Vérifier sur "http://localhost:8080/" que le message s'affiche bien
http://localhost:8080/

## Proceder à l'installation de git
$ apt install git -y

## Vérifier son installation avec la commande git --version
$ git --version
