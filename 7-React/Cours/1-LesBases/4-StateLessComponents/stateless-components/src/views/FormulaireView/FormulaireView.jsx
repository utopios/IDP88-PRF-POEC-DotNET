import React, { useState } from 'react';
import './FormulaireView.css';

const FormulaireView = () => {

    const [nom, setNom] = useState('');
    const [prenom, setPrenom] = useState('');
    const [email, setEmail] = useState('');
    const [type, setType] = useState();
    const [text, setText] = useState();

    function handleSumit(e){
        e.preventDefault();
        alert(e.target['email'].value)
    }


    return (
        <div>
            <h2>Les Formulaires en React</h2>
            <div className="card">
                <form onSubmit={handleSumit}>
                    <div className="form-control">
                        <h3>SetStates</h3>
                        <div className="mb-3">
                            <label htmlFor="nom">Nom : </label>
                            <input type="text" name="nom" id="nom" className='form-control' onChange={(e) => setNom(e.target.value)} />
                        </div>
                        <div className="mb-3">
                            <label htmlFor="nom">Prénom : </label>
                            <input type="text" name="prenom" id="prenom" className='form-control' onChange={(e) => setPrenom(e.target.value)} />
                        </div>
                        <div className="mb-3">
                            <label htmlFor="nom">Email : </label>
                            <input type="text" name="email" id="email" className='form-control' onChange={(e) => setEmail(e.target.value)} />
                        </div>
                        <select name="typeDemande" id="typeDemande" onChange={(e) => setType(e.target.value)} className='form-control'>
                            <option selected disabled>Choississez le type de demande</option>
                            <option value="1">Renseignements au sujet de la formation</option>
                            <option value="2">Demande de rendz-vous</option>
                            <option value="3">Autres demandes...</option>
                        </select>
                        <div className="mb-3">
                            <label htmlFor="nom">Rédigez votre demande : </label>
                            <textarea name="textarea" id="textarea" className='form-control' onChange={(e) => setText(e.target.value)} />
                        </div>
                    </div>
                    <button type="submit" className='btn btn-secondary form-control'>Valider</button>
                </form>
            </div>
            <div className="card">
                <div className="form-control">
                    <h3>Affichage des States</h3>
                    <div className="mb-3">
                        <label htmlFor="nom">Nom : </label>
                        <input type="text" name="nomRes" id="nomRes" className='form-control' placeholder={nom} />
                    </div>
                    <div className="mb-3">
                        <label htmlFor="nom">Prénom : </label>
                        <input type="text" name="prenomRes" id="prenomRes" className='form-control' placeholder={prenom} />
                    </div>
                    <div className="mb-3">
                        <label htmlFor="nom">Email : </label>
                        <input type="text" name="emailRes" id="emailRes" className='form-control' placeholder={email} />
                    </div>
                    <select name="typeDemandeRes" id="typeDemandeRes" value={type} className="form-control">
                        <option selected disabled>Choississez le type de demande</option>
                        <option value="1">Renseignements au sujet de la formation</option>
                        <option value="2">Demande de rendz-vous</option>
                        <option value="3">Autres demandes...</option>
                    </select>
                    <div className="mb-3">
                        <label htmlFor="nom">Rédigez votre demande : </label>
                        <textarea name="textareaRes" id="textareaREs" className='form-control' value={text} />
                    </div>
                </div>
            </div>
        </div>
    );
}

export default FormulaireView;
