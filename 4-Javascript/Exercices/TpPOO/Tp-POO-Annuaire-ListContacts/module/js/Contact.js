export default class Contact {
    constructor(titre, nom, prenom, dateNaissance, telephone, email) {
        this._titre = titre;
        this._nom = nom;
        this._prenom = prenom;
        this._dateNaissance = dateNaissance;
        this._telephone = telephone;
        this._email = email;
    }

    get titre() { return this._titre }
    set titre(value) { this._titre = value }

    get nom() { return this._nom }
    set nom(value) { this._nom = value }

    get prenom() { return this._prenom }
    set prenom(value) { this._prenom = value }

    get dateNaissance() { return this._dateNaissance }
    set dateNaissance(value) { this._dateNaissance = value }

    get telephone() { return this._telephone }
    set telephone(value) { this._telephone = value }

    get email() { return this._email }
    set email(value) { this._email = value }

    ContactToString(){
        return `Titre : ${this._titre} - Nom : ${this._nom} - Prénom : ${this._prenom}`;
    }
}