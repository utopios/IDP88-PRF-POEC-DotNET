import express from 'express';
import multer from 'multer';
import cors from 'cors';
import path from 'path';
import { M2iFunction, success } from './helper.js';
import { fileURLToPath } from 'url';
import ip from 'ip';
import Contact from '../../Exercices/TP1-NODE-ApiRestContact/classes/contact.js';

const app = express();
const port = 7777;
const ipAddress = ip.address();

// __DirName
const __filename = fileURLToPath(import.meta.url);
const __dirName = path.dirname(__filename);
console.log(`Directory-Name : ${__dirName}`)



/**
 * CONFIFG EXPRESS
 */
app
    .use(cors())
    .use((req, res, next) => {
        res.header('Access-Control-Allow-Origin', '*')
        res.header(
            'Access-Control-Allow-Headers',
            'Origin, X-requested-with, Content-Type, Accept'
        )
        next()
        app.options('*', (req, res) => {
            res.header(
                'Access-Control-Allow-Methods',
                'GET, POST ,PUT, DELETE, PATCH, OPTIONS'
            )
            res.send()
        })
    })
    .use(express.static(path.join(__dirName, 'public')))
    .use('/static', express.static(path.join(__dirName, 'public')));

/**
 * CONFIG MULTER
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
// Création de l'objet multer
const upload = multer({
    storage: storage,
})

/**
 * END POINTS
 */

app.get('/', (req, res) => {
    console.log("/ : Api Fonctionelle");
    res.json({ message: "Ca marche" });
})

app.post('/upload', upload.single('img'), async (req, res) => {
    // console.log(req);
    console.log(`UPLOAD : ${req.file.originalname} => ${req.file.filename} - Folder : ${req.file.destination} - Size = ${req.file.size}ko`)

    try {
        let filename = req.file.filename;
        let message ="Upload OK"
        res.json(success(message,filename))
        let tmp = new Contact()
    }
    catch (e) {
        res.send(400).send(e)
    }
})


app.listen(port, () => console.log(M2iFunction(port, ipAddress)))