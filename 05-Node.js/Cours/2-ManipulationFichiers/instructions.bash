# Initialisation du projet Node.js
$ npm init

# Dans le package.json => Ajouter
{
    "type":"module",
}

# Ajouter un script pour le démarrage de l'app
"scripts": {
    "start":"node index.js", # Ajouter cette ligne
    "test": "echo \"Error: no test specified\" && exit 1"
  }
