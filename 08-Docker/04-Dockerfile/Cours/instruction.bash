# Création d'une image depuis une conteneur existant
$ docker commit <container_id ou container_name> <image_name>

# Pour lancer la création de l'image
$ docker build -t <nom_image> .  

# Pour executer le container
$ docker run --name=node_server_container -dp 8080:80 node_server 