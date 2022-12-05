###
# BACK
###

# Build de notre image docker
$ docker build -t back-api-node .

# Création du container issu de notre image
$ docker run --name=back-api-container -dp 7777:7777 back-api-node

# Vérification de la présence du conteneur actif
$ docker ps

# Connection a notre conteneur en bash
$ docker exec -it back-api-container bash

# Sortir du bash du conteneur
$ exit



###
# FRONT
###