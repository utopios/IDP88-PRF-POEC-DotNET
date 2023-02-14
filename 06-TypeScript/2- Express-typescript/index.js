import express from "express";
const app = express();
app.get('/:id', (req, res) => {
    const id = parseInt(req.params.id);
    res.json({ message: "response", id: id });
});
app.post('data', (req, res) => {
    const p = req.body;
    res.json({ nom: "", prenom: "" });
});
app.listen(3000, () => console.log("http://localhost:3000"));
