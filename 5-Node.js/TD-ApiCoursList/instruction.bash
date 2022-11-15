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

# Création d'une fonction pour la mise en forme des res (helper.js)
exports.success = (message, data) => {
    return { message, data }
}

# import de la fonction success dans note index.js
const helpers = require('./helper.js')

# Modification du END POINT /api/cours
let message = `Il y a ${coursList.length} cours dans notre catalogue...`
res.json(helpers.success(message, coursList));

# Création d'un service injectable dans le middleware
const logger = (req, res, next) => {
    console.log(`URL : ${req.url}`);
    next();
}

# Injection du service logger
app.use(logger)

# Installation d'un middleware deja existant
$ npm install morgan --save-dev

# Import de Morgan (logger)
const morgan = require('morgan')

# injection du service
app.use(morgan('dev'))

# Import de la librairie Serve-favicon
$ npm install serve-favicon --save

# Import de la librairie Serve-favicon dan index.js
const favicon = require('serve-favicon');

# Injection du service
.use(favicon(__dirname+"/favicon.ico"))

# Importer un .ico a la racine du projet"
favicon.ico

# Création d'un END POINT pour poster un new cours
## POST => http://localhost:7777/api/cours
app.post('/api/cours', (req, res) => {
    const id = coursList.length + 1;
    const coursCreated ={...req.body, {id:id,created = new Date()}}
});

# Import de la librairie body-parser
$ npm install body-parser --save

# Import de body-parser dans index.js
const bodyParser = require('body-parser');

# Rédaction des END POINT

###
# GET 
###

## GET => http://localhost:7777/api/cours
app.get('/api/cours', (req, res) => {
    // let maVar = coursList.length
    //res.json({ message: `Il y a ${coursList.length} cours dans notre catalogue...`, data: coursList })
    let message = `Il y a ${coursList.length} cours dans notre catalogue...`
    res.json(success(message, coursList));
});

###
# POST 
###

## POST => http://localhost:7777/api/cours
app.post('/api/cours', (req, res) => {
    const nextId = getUniqueId(coursList);
    //console.log(nextId);
    const coursCreated = { ...req.body, ...{ id: nextId, created: new Date() } }
    coursList.push(coursCreated);
    let message = `Le cours n°${nextId} a été ajouté`;
    res.json(success(message, coursCreated));
});

###
# UPDATE 
###

// PUT => http://localhost:7777/api/cours/:id
app.put('/api/cours/:id', (req, res) => {
    const Id = parseInt(req.params.id);
    const coursUpdated = { ...req.body, Updated: new Date() }
    coursList = coursList.map(cours => {
        return cours.id === Id ? coursUpdated : cours
    })
    let message = `Le cours n° ${Id} a été modifié`
    res.json(success(message, coursUpdated));
});

###
# DELETE 
###

## DELETE => http://localhost:7777/api/cours/:id
app.delete('/api/cours/:id', (req, res) => {
    const Id = parseInt(req.params.id);
    const coursDeleted = coursList.find(cours => cours.id === Id)
    coursList = coursList.filter(cours => cours.id != Id)
    let message = `Le cours n° ${Id} a été supprimé`
    res.json(success(message, coursDeleted));
});

###
# CORS (Cross Origin)
###

# Installation du package
$ npm install cors

# Import de la librairie CORS
const cors = require('cors');

# Injection dans le middleware
.use(cors())

# Redaction d'une fonction pour configurer notre corsPolicy
const corsPolicy = (req, res, next) => {
    res.header('Access-Control-Allow-Origin', '*')
    // authorized headers for preflight requests
    // https://developer.mozilla.org/en-US/docs/Glossary/preflight_request
    res.header(
        'Access-Control-Allow-Headers',
        'Origin, X-Requested-With, Content-Type, Accept',
    )
    next()
    app.options('*', (req, res) => {
        // allowed XHR methods
        res.header(
            'Access-Control-Allow-Methods',
            'GET, PATCH, PUT, POST, DELETE, OPTIONS',
        )
        res.send()
    })
}



# Injection dans le middleware
.use(cors())
.use(corsPolicy)

# Installation du package IP 
npm install ip --save