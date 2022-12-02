# Pour lancer la création de l'image
$ docker build -t <nom_image> .  

# Pour executer le container
$ docker run --name=node_server_container -dp 8080:80 node_server 