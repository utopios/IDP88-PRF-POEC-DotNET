# Création du projet node.js
$ npm init

# Configuration de la commande de lancement
=> Dans package.json ajouter le script "start"
"scripts": {
    "start": "node index.js",
    "test": "echo \"Error: no test specified\" && exit 1"
  },

# Pour lancer notre application node.js executer
$ npm run start
$ npm start

# Installation de express
$ npm install express ejs --save

# Définition du fonctionnement modulaire de notre application
=> Dans package.json ajouter
"type" : "module"

# Dans le fichier index.js, définition d'un route pour notre API
app.get('', (req , res) => {
    res.end("<h1>Hello from our first nodejs app!</h1>");
})

# Configurer notre application afin d'écouter le port 7777
app.listen(port, () => {
    console.log("Application node.js démarée...");
})

# GET => http://localhost:7777/data
app.get('/data', (req , res) => {
    res.json(data);
})

# POST => http://localhost:7777/data
app.post('/data', (req , res) => {
    let tmp = {...req.body,created : new Date()}
    data.push(tmp);
    console.table(data);
    res.json({message :"Formation ajoutée", data : tmp});
})

# PUT => http://localhost:7777/update/5
app.put('/update/:id',(req,res) =>{
    const id = parseInt(req.params.id);
    let tmp = {...req.body};
    res.json({message :`Formation n°${id} modifiée`, data : tmp});
})

# DELETE => http://localhost:7777/delete/9
app.delete('/delete/:id',(req,res) =>{
    const id = parseInt(req.params.id);
    res.json({message :`Formation n°${id} supprimée`});
})


# Installation de la librairie IP
npm install ip