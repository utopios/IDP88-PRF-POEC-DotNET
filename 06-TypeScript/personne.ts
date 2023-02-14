export class Personne {
    //Attributs
    _nom: String
    _prenom: String

    constructor(n: String, p: String) {
        this.Nom = n
        this.Prenom = p
    }

    // Proprièté
    get Nom() { return this._nom };
    get Prenom() { return this._nom };

    set Nom(value) {
        if (value.length < 1)
            this._nom = value;
    };
    set Prenom(value) {
        if (value.length < 1)
            this._prenom = value
    };

    afficher(): void {
        console.log(this._nom + " " + this._prenom)
    }

    nomComplet(): String {
        return this._nom + " " + this._prenom
    }

}