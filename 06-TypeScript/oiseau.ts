import { IVolant } from "./ivolant";

export class Oiseau implements IVolant {
    name:string

    voler() : void {
        console.log("Je vole a l'aide de réacteur");
    }
}