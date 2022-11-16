//ES6
export function success(message, data){
    return { message, data }
}

// Rediger une fonction qui prend en params une liste et nous retourne le dernier Id

export function getUniqueId(list){
    // Recupération de l'ensemble des clé Id de mes objets et stockage dans un tableau
    const coursIds = list.map(cour => cour.id);
    // Utilisation de Reduce combiné à la Méthode max pour retourner la plus grande des valeur
    const maxId = coursIds.reduce((a, b) => Math.max(a, b));
    // Ajout de 1 au plus Id
    const uniqueId = maxId + 1;
    // Retourne la uniqueId
    return uniqueId;

}


export function M2iFunction(port, ipAddress){
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