## Créer un dossier
$ mkdir <nom du dossier>

## Se rendre dans un dossier
$ cd /path/<nom dossier>

# Se rendre dans le dossier parent 
$ cd ..

# Ecrire dans un ficher 
$ echo "Chose à ecrire" > path/vers/dossier/contenant/fichier.ext

# Aficher le contenu texte d'un fichier dans le terminal
$ cat path/vers/fichier.ext

# Télécharger la liste des paquet sur le repos
$ apt update

# Installer la derniere version des paquets depuis le repos
$ apt upgrade -y

# installer un package depuis le repos
$ apt install <nomPackage>

# Rechercher un fichier depuis la racine
find / -iname "nomdefichier"

# Rechercher un dossier depuis la racine
find / -type d -iname "nomdedossier"

# Rechercher un fichier depuis le curent folder et ses enfants
find . -iname "nomdefichier"

# Rechercher un dossier depuis le curent folder et ses enfants
find . -type d -iname "nomdedossier"