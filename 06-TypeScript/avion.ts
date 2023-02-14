import { IVolant } from "./ivolant";

export class Avion implements IVolant {

    name: string
    constructor() {

    }

    voler(): void {
        console.log("Je vole a l'aide de réacteur");
    }
}