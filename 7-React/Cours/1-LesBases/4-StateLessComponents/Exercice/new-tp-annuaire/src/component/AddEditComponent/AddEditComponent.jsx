import React, { useState } from 'react';

const AddEditComponent = ({ personList, updatePersonList, AddPerson }) => {

    /**
    * States
    */
    const [nom, setNom] = useState('');
    const [prenom, setPrenom] = useState('');
    const [email, setEmail] = useState('');
    const [telephone, setTelephone] = useState('');



    return (
        <>
            <h1>Add Person</h1>
            <div className="card">
                <form>
                    <div className="form-control formulaire">
                        <div className="mb-2">
                            <label htmlFor="nom">Nom : </label>
                            <input type="text" name="nom" id="nom" onChange={(e) => setNom(e.target.value)} className="form-control" value={nom} />
                        </div>
                        <div className="mb-2">
                            <label htmlFor="prenom">Prénom : </label>
                            <input type="text" name="prenom" id="prenom" onChange={(e) => setPrenom(e.target.value)} className="form-control" value={prenom} />
                        </div>
                        <div className="mb-2">
                            <label htmlFor="email">Email : </label>
                            <input type="email" name="email" id="email" onChange={(e) => setEmail(e.target.value)} className="form-control" value={email} />
                        </div>
                        <div className="mb-2">
                            <label htmlFor="telephone">Téléphone : </label>
                            <input type="text" name="telephone" id="telephone" onChange={(e) => setTelephone(e.target.value)} className="form-control" value={telephone} />
                        </div>

                        <button className='btn btn-secondary form-contol' onClick={() => AddPerson(nom,prenom,email,telephone)}>Ajouter</button>
                    </div>
                </form>
            </div>

        </>
    );
}

export default AddEditComponent;
