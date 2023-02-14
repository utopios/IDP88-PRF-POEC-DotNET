# Crée notre dossier
$ mkdir PremierProjet

# Se rendre dans le dossier
$ cd PremierProjet

#Installation de Typescript
$ npm install typescript --save-dev

# Initialisation d'un projet Typescript
$ npx tsc --init

# Création du point d'entrée de notrez app
index.ts

# Création du code dans index.ys
const message = "world";

export function hello(name:string = message): string {
    return `Hello ${name}`;
}

console.log(hello());
console.log(hello("Anthony"));

# compiler la ressource
$ npx tsc

# Recompilation en temp réel 
$ npx tsc -w