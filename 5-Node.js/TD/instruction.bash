##Création du point dentrée de notre app
index.js

# initialisation d'un projet Node.js
$ npm init

# Mise ne place d'une commande de démarrage du projet
"scripts": {
    "start": "node index.js",
    "test": "echo \"Error: no test specified\" && exit 1"
  }

# Démarrer le projet avec
$ npm start

# Pour arreter 
ctrl + C

# Installation de Epress
$ npm install express  

# Création des END POINT
app.get('/',(req,res) => res.send('Hello from my node JS'));

# Ecoute du port
# app.listen(port , ()=> console.log(`L'application node.js est démarée \n \thttp://localhost:${port}`));

# Execute 
$ npm start

# Pour arreter 
ctrl + C

# Installation du package nodemon
$ npm install nodemon --save-dev

# Création d'un script de démarrage en mod "Dev"
"scripts": {
    "start": "node index.js",
    "dev": "nodemon index.js",
    "test": "echo \"Error: no test specified\" && exit 1"
  }

# Pour lancer le projet en mode dev
$ npm run dev

# Import de la liste de cours CoursList.js
CoursList.js

# Création d'un new END POINT
app.get('/api/cours/1',(req,res) => res.send('Welcome to my CoursList API'));

# Visiter la route depuis votre navigateur
GET => http://localhost:7777/api/cours/1

# Modification d'un new END POINT
app.get('/api/cours/:id',(req,res) => {
    const id = parseInt(req.params.id);
    res.send(`Welcome to my cours n°${id}`);
});



