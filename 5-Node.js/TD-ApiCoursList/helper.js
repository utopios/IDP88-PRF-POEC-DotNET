// // Syntaxe ES5
// const success = (message, data) => {
//     return {
//         message:message,
//         data:data
//     }
// }

// exports.success;

//ES6
exports.success = (message, data) => {
    return { message, data }
}

// Rediger une fonction qui prend en params une liste et nous retourne le dernier Id

exports.getUniqueId = (list) => {
    // Recupération de l'ensemble des clé Id de mes objets et stockage dans un tableau
    const coursIds = list.map(cour => cour.id);
    // Utilisation de Reduce combiné à la Méthode max pour retourner la plus grande des valeur
    const maxId = coursIds.reduce((a, b) => Math.max(a, b));
    // Ajout de 1 au plus Id
    const uniqueId = maxId + 1;
    // Retourne la uniqueId
    return uniqueId;

}

//Solution de Nicolas le grand génie de NodeJS
// exports.getUniqueID = (coursList) => {
//     let maxID = 0;
//     for (const id of coursList) {
//         if (maxID < id.id) {
//             maxID = id.id;
//         }
//     }
//     return maxID + 1;
// }

// Solution de Allison
// exports.getUniqueId = (list) => {
//     let lastId = 0;
//     let uniqueId = 0

//     list.forEach((cours) => {
//         if (lastId < cours.id) {
//             lastId = cours.id;
//         }
//     });

//     uniqueId = lastId + 1;
//     return uniqueId;
// }

exports.M2iFunction = (port, ipAddress) => {
    return `\n\n\n                             __  __ ____  _                    
                            |  \\/  |___ \\(_)                   
                            | |\\/| | __) | |                   
                            | |  | |/ __/| |                   
                 _____      |_|  |_|_____|_|    _   _             
                |  ___|__  _ __ _ __ ___   __ _| |_(_) ___  _ __  
                | |_ / _ \\| '__| '_ ' _ \\ / _' | __| |/ _ \\| '_ \\ 
                |  _| (_) | |  | | | | | | (_| | |_| | (_) | | | |
                |_|  \\___/|_|  |_| |_| |_|\\__,_|\\__|_|\\___/|_| |_|
                                       \n
                 
                 \n\t\t\tL'application node est démarée\n
                ***************************************************
                 Local\t\t:\thttp://localhost:${port}     
                 on Network\t:\thttp://${ipAddress}:${port}  
                ***************************************************`;
}