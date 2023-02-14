import { stdin, stdout } from 'process';
import readline from 'readline';

export const askQuestion = async (message) => {
    console.log(message);
    const readlineInterface = readline.createInterface({
        input: stdin,
        output: stdout
    })
    
    const result = await (await readlineInterface[Symbol.asyncIterator]().next()).value
    readlineInterface.close();
    return result;
}
