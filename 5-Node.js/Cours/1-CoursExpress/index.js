//console.log('Je fonctionne depuis node.js');

// const express = require ('express');
import {M2iFunction} from './helpers.js';
import express from 'express';
import ip from 'ip';

// création d'une instance d'express
const app = new express();

// Définition du port d'écoute de notre serveur
const port = 7777;
const ipAddress = ip.address();

// Parametrege de express en json
app.use(express.json());

// Création d'un tableau pour stocker le données à retourner
let data = [{
    "category": "Reférencement",
    "name": "SEO Premium",
    "difficulte": 3,
    "price": 249,
    "id": 1,
    "created": "2019-06-16T16:54:46.308Z"
},
{
    "category": "Langage de programmation",
    "name": "C#",
    "difficulte": 4,
    "price": 299,
    "id": 2,
    "created": "2019-06-16T16:54:56.308Z"
},
{
    "category": "Langage de programmation",
    "name": "JavaScript",
    "difficulte": 3,
    "price": 199,
    "id": 3,
    "created": "2019-06-16T16:55:06.308Z"
},
{
    "category": "Langage de programmation",
    "name": "HTML/CSS",
    "difficulte": 2,
    "price": 149,
    "id": 4,
    "created": "2019-06-16T16:55:16.308Z"
},
{
    "category": "FrameWork",
    "name": "React",
    "difficulte": 3,
    "price": 299,
    "id": 5,
    "created": "2019-06-16T16:55:26.308Z"
},
{
    "category": "FrameWork",
    "name": "Vue.Js",
    "difficulte": 2,
    "price": 299,
    "id": 6,
    "created": "2019-06-16T16:55:36.308Z"
},
{
    "category": "FrameWork",
    "name": "Angular",
    "difficulte": 4,
    "price": 299,
    "id": 7,
    "created": "2019-06-16T16:55:46.308Z"
},
{
    "category": "Outils collaboratifs",
    "name": "Git",
    "difficulte": 3,
    "price": 199,
    "id": 8,
    "created": "2019-06-16T16:55:56.308Z"
},
{
    "category": "FrameWork",
    "name": "Sass",
    "difficulte": 3,
    "price": 149,
    "id": 9,
    "created": "2019-06-16T16:56:06.308Z"
}]

// GET => http://localhost:7777
// déclaration d'une route
app.get('', (req , res) => {
    res.end("<h1>Hello from our first nodejs app!</h1>");
})

// GET => http://localhost:7777/api/6
app.get('/api/:nomparams', (req , res) => {
    res.end(`Le parametre vaut : ${req.params.nomparams}`);
})

// GET => http://localhost:7777/data
app.get('/data', (req , res) => {
    res.json(data);
})

// POST => http://localhost:7777/data
app.post('/data', (req , res) => {
    let tmp = {...req.body,created : new Date()}
    data.push(tmp);
    console.table(data);
    res.json({message :"Formation ajoutée", data : tmp});
})

// PUT => http://localhost:7777/update/5
app.put('/update/:id',(req,res) =>{
    const id = parseInt(req.params.id);
    let tmp = {...req.body};
    res.json({message :`Formation n°${id} modifiée`, data : tmp});
})

// DELETE => http://localhost:7777/delete/9
app.delete('/delete/:id',(req,res) =>{
    const id = parseInt(req.params.id);
    res.json({message :`Formation n°${id} supprimée`});
})






app.listen(port, () => {
    console.log(M2iFunction(port, ipAddress));
})
// app.listen(port, () => {
//     console.log(`Application node.js démarée...\n
//     http://${ipAddress}:${port}
//     `);
// })
