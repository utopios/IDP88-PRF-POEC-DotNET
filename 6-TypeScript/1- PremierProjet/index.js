"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.hello = void 0;
const message = "world";
function hello(name = message) {
    return `Hello ${name}`;
}
exports.hello = hello;
console.log(hello());
console.log(hello("Anthony"));
