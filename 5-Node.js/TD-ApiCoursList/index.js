// Création d'une constante pour les lib express
const express = require('express');
const { readFileSync, writeFileSync } = require('fs');

// Import de la liste de cours
// let coursList = require('./data/CoursList');
let coursList = JSON.parse(readFileSync('./data/savedList.json', 'utf-8'))
console.table(coursList);

// Instanciation d'express
const app = express();
const port = 7777;

// Import de Morgan (middleware)
const morgan = require('morgan')

// Import de Serve Favicon
const favicon = require('serve-favicon');

// Import de Body-Parser
const bodyParser = require('body-parser');

// Import de CORS
const cors = require('cors');

// Import Ip
let ip = require('ip');

// Import de helpers.js
const { success, getUniqueId, M2iFunction } = require('./helper.js');
const { json } = require('body-parser');

// // Création du service Logger
// const logger = (req, res, next) => {
//     console.log(`URL : ${req.url}`);
//     next();
// }



// Injection des service (ATTENTION A L'ORDRE)
app
    // .use(logger)
    .use(cors())
    .use(favicon(__dirname + "/favicon.ico"))
    .use(morgan('dev'))
    .use(bodyParser.json())
    .use(express.static(path.join(__dirName, 'public')))
    .use('/static', express.static(path.join(__dirName, 'public')));

/**
 * FUNCTION()
 */

function saveList() {
    const objectToJson = JSON.stringify(coursList);
    writeFileSync('./data/savedList.json', objectToJson);
    console.log('Données sauvegardées...');
}

/**
 * END POINT 
 */

// GET => http://localhost:7777/
app.get('/', (req, res) => res.send('Hello from my node JS'));

// GET => http://localhost:7777/api/cours/:id
// app.get('/api/cours/1',(req,res) => res.send('Welcome to my CoursList API'));
app.get('/api/cours/:id', (req, res) => {
    const id = parseInt(req.params.id);
    // res.send(`Welcome to my cours n°${id}`);

    let cours = coursList.find(cour => cour.id == id)
    if (cours != undefined)
        res.json(cours);
    else
        res.send("Ce cours n'existe pas...")
});

// GET => http://localhost:7777/api/cours
app.get('/api/cours', (req, res) => {
    // let maVar = coursList.length
    //res.json({ message: `Il y a ${coursList.length} cours dans notre catalogue...`, data: coursList })
    let message = `Il y a ${coursList.length} cours dans notre catalogue...`
    res.json(success(message, coursList));
});

// POST => http://localhost:7777/api/cours
app.post('/api/cours', (req, res) => {
    const nextId = getUniqueId(coursList);
    //console.log(nextId);
    const coursCreated = { ...req.body, ...{ id: nextId, created: new Date() } };
    coursList.push(coursCreated);
    saveList();
    let message = `Le cours n°${nextId} a été ajouté`;
    res.json(success(message, coursCreated));
});

// PUT => http://localhost:7777/api/cours/:id
app.put('/api/cours/:id', (req, res) => {
    const Id = parseInt(req.params.id);
    const coursUpdated = { ...req.body, Updated: new Date() }
    coursList = coursList.map(cours => {
        return cours.id === Id ? coursUpdated : cours
    });
    saveList();
    let message = `Le cours n° ${Id} a été modifié`
    res.json(success(message, coursUpdated));
});

// DELETE => http://localhost:7777/api/cours/:id
app.delete('/api/cours/:id', (req, res) => {
    const Id = parseInt(req.params.id);
    const coursDeleted = coursList.find(cours => cours.id === Id);
    coursList = coursList.filter(cours => cours.id != Id);
    saveList();
    let message = `Le cours n° ${Id} a été supprimé`
    res.json(success(message, coursDeleted));
});


/**
 * Ecoute d'un port
 */
app.listen(port, () => console.log(M2iFunction(port, ip.address())));
