import fs from 'fs';
import readline from 'readline';
let data = "";
// La lecture d'un fichier .txt avec la méthode readFile()
// fs.readFile("fichier1.txt", (err, data) =>{
//     if(err == null){
//         console.log(data.toString())
//     } else {
//         console.log(err)
//     }
// })

// // Lecture d'un fichier en Sync
// data = fs.readFileSync("fichier1.txt");
// console.log(data.toString());

// data += "\nContenu Ajouté";
// // Ecriture dans un fichier .txt
// fs.writeFile("fichier1.txt", data, (err) =>{
//     console.log(err);
// })

// data += "\nContenu Ajouté";
// // Ecriture dans un fichier .txt
// fs.writeFileSync("fichier1.txt", data )

// // Re-lecture d'un fichier en Sync
// data = fs.readFileSync("fichier1.txt");
// console.log(data.toString());


// // Ajouter du contenu dans un fichier SANS PERDRE SON CONTENU EN ASYNC
// fs.appendFile("fichier1.txt", "\nJ'ajoute du nouveau contenu Async", (err) => {
//     console.log(err)
// });

// // Ajouter du contenu dans un fichier SANS PERDRE SON CONTENU EN SYNC
// fs.appendFileSync("fichier1.txt", "\nJ'ajoute du nouveau contenu Sync", (err) => {
//     console.log(err)
// });

// // Re-lecture d'un fichier en Sync
// data = fs.readFileSync("fichier1.txt");
// console.log(data.toString());


// // Ecoute d'un fichier
// fs.watchFile("fichier1.txt", (cur , prev) =>{
//     console.log(cur);
//     console.log(fs.readFileSync("fichier1.txt").toString());
//     console.log(prev);
// });

// // Exemple d'écriture dans un fichier .csv
// let nom = "Di Persio";
// let prenom = "Anthony";

// // Ecriture
// fs.appendFileSync("data.csv", `${nom},${prenom}\n`);

// nom = "Abadi";
// prenom = "Ihab";

// // Ecriture
// fs.appendFileSync("data.csv", `${nom},${prenom}\n`)

// const lectureLigneFichier = (fichier) => {
//     const readlLineInterface = readline.createInterface({
//         input : fs.createReadStream(fichier)
//     })
//     return readlLineInterface;
// }

// lectureLigneFichier("data.csv").on('line' , (line)=>{
//     console.log(line);
// })

// const jsObject =
//     [
//         { cle: "valeur", autreCle: 123, encoreUneCle: true },
//         { cle: "valeur", autreCle: 123, encoreUneCle: true }
//     ];

    
// // Convertion en json
// const objectToJson = JSON.stringify(jsObject);
// console.log(objectToJson);
// // // Retourne
// // [
// //     {"cle":"valeur","autreCle":123,"encoreUneCle":true},
// //     {"cle":"valeur","autreCle":123,"encoreUneCle":true}
// // ]

// // Reconstruire des objet JS depuis une chaine JSON
// const objectFromJsonString = JSON.parse(objectToJson);
// console.table(objectFromJsonString);


/**
 * EXERCICES 
 * 1) Récupérer le contenu du fichier data.json
 * 2) reconstruire les objets JS
 * 3) Ajouter un objet js 
 * 4) Update du fichier JSon
 */


 // 1) Récupérer le contenu du fichier data.json
let myListJson = fs.readFileSync("Data.json", (err,data )=>{
    if(err ==null){
        return data
    } else {
        console.log(err)
    }
})

console.table(myListJson.toString());

 // 2) reconstruire les objets JS
const mylist = JSON.parse(myListJson);
console.table(mylist);

 // 3) Ajouter un objet js 
 let myNewObjectJs = {
    title:"Mr",firstname:"Abadi",lastname:"Ihab"
 };

 mylist.push(myNewObjectJs)
 console.table(mylist);

 // 4) Update du fichier JSon
 myListJson = JSON.stringify(mylist, "utf-8");
 fs.writeFileSync("data.json" , myListJson);