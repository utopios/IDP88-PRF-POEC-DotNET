let message : string;
message = "world";


export function hello(name:string = message): string {
    return `Hello ${name}`;
}

console.log(hello());
console.log(hello("Anthony"));
