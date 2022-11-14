// Création d'une constante pour les lib express
const express = require('express');
// Import de la liste de cours
const coursList = require('./data/CoursList');
console.table(coursList);

// Instanciation d'express
const app = express();
const port = 7777;





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
    res.json({ message: `Il y a ${coursList.length} cours dans notre catalogue...`, error: false, data: coursList })
});



/**
 * Ecoute d'un port
 */
app.listen(port, () => console.log(`L'application node.js est démarée \n
\thttp://localhost:${port}`));
