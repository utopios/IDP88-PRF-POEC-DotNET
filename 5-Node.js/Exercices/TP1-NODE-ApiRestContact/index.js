import cors from 'cors';
import ip from 'ip';
import express from 'express';
import morgan from 'morgan';
import multer from 'multer';
import bodyParser from 'body-parser';
import path from 'path';
import { M2iFunction, success, getUniqueId } from './helpers.js';
import { readFileSync, writeFileSync } from 'fs';
import { fileURLToPath } from 'url';
import Contact from './classes/contact.js';

let contactList = new Array();
// remplir la list depuis le fichier JSON
loadList();
console.log(contactList);

// CONFIG IP
const ipAddress = ip.address();

/// Express
const app = express();
const port = 7777;

// __DirName
const __filename = fileURLToPath(import.meta.url);
const __dirname = path.dirname(__filename);
console.log('directory-name	\ud83d\udc49 ', __dirname);


// SERVICES
app
    .use(morgan('dev'))
    .use(cors())
    .use((req, res, next) => {
        res.header('Access-Control-Allow-Origin', '*')
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
    })
    .use(express.static(path.join(__dirname, 'public')))
    .use('/static', express.static(path.join(__dirname, 'public')))
    .use(bodyParser.json())


/**
 * UPLOAD CONFIG
 */

let storage = multer.diskStorage({
    // La limite en taille du fichier
    limits: {
        fileSize: 500000, //500ko
        //fileSize: 1000000, //1Mo
    },
    // La destination, ici ce sera à la racine dans le dossier img
    destination: (req, file, cb) => {
        cb(null, './public/img')
    },
    // Gestion des erreurs
    fileFilter(req, file, cb) {
        if (!file.originalname.match(/\.(jpg|jpeg|png)$/)) {
            return cb(new Error('Le fichier doit etre un JPG ou PNG'))
        }
        cb(undefined, true)
    },
    // Fonction qui renomme l'image
    filename: function (req, file, cb) {
        // Genère un nom aléatoire et récupère l'ancienne extension
        cb(
            null,
            Math.random().toString(36).substring(7) +
            '.' +
            file.originalname.split('.')[1],
        )
    },
})

const upload = multer({
    storage: storage,
})

/**
 * FUNCTION()
 */

function loadList() {
    let datas = JSON.parse(readFileSync('./datas/savedList.json', 'utf-8'));
    //console.log(datas);
    if (datas) {
        for (let contact of datas) {
            let tmp = new Contact(contact.id, contact.title, contact.firstname, contact.lastname, contact.dateOfBirth, contact.urlImg, contact.phone, contact.email, contact.created, contact.updated);
            //console.log(tmp);
            contactList.push(tmp);
        }
    }
}

function saveList() {
    const objectToJson = JSON.stringify(contactList);
    writeFileSync('./datas/savedList.json', objectToJson);
    console.log("Données sauvegardées...");
}

/**
 * END POINT
 */

app.get('/', (req, res) => res.send("Hello from NodeJs!"));

// GET => http://localhost:7777/api/contact/:id
app.get('/api/contact/:id', (req, res) => {
    const id = parseInt(req.params.id);

    let contact = contactList.find(contact => contact.id == id)
    if (contact != undefined) {
        let message = "Un contact a été trouvé"
        res.json(success(message, contact));
    }
    else
        res.send("Ce contact n'existe pas...")
});

// GET => http://localhost:7777/api/contacts
app.get('/api/contacts', (req, res) => {
    let message = `Il y a ${contactList.length} contact dans notre catalogue...`
    res.json(success(message, contactList));
});


// POST => http://localhost:7777/api/cours
app.post('/api/contact', (req, res) => {
    const nextId = getUniqueId(contactList);
    //console.log(req.body);
    console.log(nextId);
    //const contactCreated = { ...req.body, ...{ id: nextId, created: new Date() } };
    const contactCreated = new Contact(nextId, req.body.title, req.body.firstname, req.body.lastname, new Date(req.body.dateOfBirth), req.body.urlImg, req.body.phone, req.body.email);
    console.log(contactCreated);
    contactList.push(contactCreated);
    saveList();
    let message = `Le contact n°${nextId} a été ajouté`;
    res.json(success(message, contactCreated));
});

// PUT => http://localhost:7777/api/cours/:id
app.put('/api/contact/:id', (req, res) => {
    const Id = parseInt(req.params.id);
    const contactUpdated = new Contact(req.body.id, req.body.title, req.body.firstname, req.body.lastname, new Date(req.body.dateOfBirth), req.body.urlImg, req.body.phone, req.body.email, req.body.created, new Date());
    contactList = contactList.map(contact => {
        return contact.id === Id ? contactUpdated : contact
    });
    saveList();
    let message = `Le contact n° ${Id} a été modifié`
    res.json(success(message, contactUpdated));
});

// DELETE => http://localhost:7777/api/cours/:id
app.delete('/api/contact/:id', (req, res) => {
    const Id = parseInt(req.params.id);
    const contactDeleted = contactList.find(contact => contact.id === Id);
    contactList = contactList.filter(contact => contact.id != Id);
    saveList();
    let message = `Le contact n° ${Id} a été supprimé`
    res.json(success(message, contactDeleted));
});

// UPLOAD IMG
app.post('/upload', upload.single('img'), async (req, res) => {
    // console.log(req);
    console.log(`UPLOAD : ${req.file.originalname} => ${req.file.filename} - Folder : ${req.file.destination} - Size = ${req.file.size}ko`)

    try {
        let filename = req.file.filename;
        let message = "Upload OK"
        res.json(success(message, filename))
    }
    catch (e) {
        res.send(400).send(e)
    }
})






app.listen(port, () => console.log(M2iFunction(port, ipAddress)));