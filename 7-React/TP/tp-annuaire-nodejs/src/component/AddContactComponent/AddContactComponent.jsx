import React, { Component } from 'react';
import './AddContactComponent.css';

class AddContactComponent extends Component {

    constructor(props) {
        super(props)
        this.states = {
            contacts: props.contacts
        }
        this.handleSubmit = this.handleSubmit.bind(this)
    }

    handleSubmit(e) {
        e.preventDefault();
        let title = e.target['Mr'].checked ? "Mr" : e.target['Mme'].checked ? "Mme" : "Undefined"
        let lastname = e.target['lastname'].value;
        let firstname = e.target['firstname'].value;
        let dateOfBirth = e.target['dateOfBirth'].value;
        let email = e.target['email'].value;
        let phone = e.target['phone'].value;
        let img = e.target['img'].files[0];
        if (title !== "" && lastname !== "" && firstname !== "" && dateOfBirth !== new Date() && email !== "" && phone !== "") {
            const newPerson = { title, lastname, firstname, dateOfBirth, img, email, phone };
            //console.table(newPerson);
            this.props.AddContact(newPerson);
            // alert("Le contact a bien été ajouté.");
            this.props.ChangeToggleForm();
            let formulaire = document.getElementById('addForm');
            formulaire.reset();

        } else {
            alert("Veuillez remplir tous les champs!");
        }
    }

    render() {
       return !this.props.toggleForm ?
            (
                <button className='btn btn-primary' onClick={() => this.props.ChangeToggleForm()}>Ajouter un contact</button>
            )

            :

            (
                <div className="relative">
                    <div className='card formulaire'>

                        <h2>Ajouter un contact</h2>

                        <form onSubmit={this.handleSubmit} id="addForm">
                            <div className="inputForm">
                                <div className="form-check form-check-inline m-1">
                                    <input type="radio" name="title" id="Mr" className='form-check-inline' defaultChecked/>
                                    <label htmlFor="Mr" className='labelRadio'>Mr</label>
                                    <input type="radio" name="title" id="Mme" className='form-check-inline' />
                                    <label htmlFor="Mme" className='labelRadio'>Mme</label>
                                    <input type="radio" name="title" id="Undefined" className='form-check-inline' />
                                    <label htmlFor="Undefined" className='labelRadio'>Non Binaire</label>
                                </div>
                                <input type="text" className="form-control m-1" placeholder='Nom' name="lastname" id="lastname" />
                                <input type="text" className="form-control m-1" placeholder='Prénom' name="firstname" id="firstname" />
                                <input type="date" className="form-control m-1" name="dateOfBirth" id="dateOfBirth" defaultValue={new Date().toISOString().substring(0,10)}/>
                                <input type="text" className="form-control m-1" placeholder='Téléphone' name="phone" id="phone" />
                                <input type="mail" className="form-control m-1" placeholder='Email' name="email" id="email" />
                                <input type="file" className="form-control m-1" name="img" id="img" />
                                <button type="submit" className="btn btn-success form-control m-1">Valider</button>
                            </div>
                        </form>
                        <button className='btn btn-secondary' onClick={() => this.props.ChangeToggleForm()}>Fermer</button>
                    </div >
                </div>
            )
    }
}

export default AddContactComponent;
