######################################################################
#				Tp1 - Premier conteneur Debian
######################################################################

## => Démarer un conteneur à partir d'une image debian:latest
## => Se connecter au bash du conteneur
## => mise à jour de ce conteneur
## => Installer l'editeur nano (vim)
## => Ecrire un fichier texte contenant du texte nommé text.txt
## => Afficher le contenu du fichier texte.txt (cat)

###################### Correction ###################################

## Rechercher l'image debian
$ docker search debian:latest

## Télécharger cette image 
$ docker pull debian:latest

## Instancier un conteneur à partir de l'image debian:latest (1 commande)
$ docker run -ti --name=container_debian debian:latest bash

## Création du conteneur
$ docker run -tid --name=container_debian debian:latest

## Connection au terminal virtuel
$ docker exec -ti container_debian bash

## Mise a jour + install de nano
$ apt update && apt upgrade -y && apt install nano -y

## Créer un fichier text text.txt
$ nano text.txt

## Afficher le contenu du fichier text 
$ cat text.txt

## Quitter le bash
$ exit
