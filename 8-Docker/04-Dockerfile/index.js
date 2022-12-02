const express = require("express");
const http = require("http");
const app = express();

app.get('/',(req,res)=>{
    res.send("Bonjour depuis mon serveur nodejs conteneurisé!");
    http.request('http://'+process.env.ADRESS_APACHE4);
})

app.listen(80,()=>{
    console.log("App is running...");
})

