import React, { Component } from 'react';
import AddContactComponent from '../../component/AddContactComponent/AddContactComponent';
import ArrayContactComponent from '../../component/ArrayContactComponent/ArrayContactComponent';
import { getContactApi, postContactApi, updateContactApi, deleteContactApi, postImage } from '../../ContactApiService'
import './AnnnuaireView.css';

class AnnuaireView extends Component {

    constructor(props) {
        super(props)
        this.state = {
            contacts: [],
            newContact: null,
            toggleForm: false
        }
    }

    ChangeToggleForm = () => {
        this.setState({
            toggleForm: !this.state.toggleForm
        })
    }

    // Methode locale pour récuprer la reponse de l'api et set le state local contact
    FetchContact = async () => {
        let response = await getContactApi();
        this.setState({
            contacts: response.data.data
        })
    }

    AddContact = async (newContact) => {
        //console.table(newContact);
        let response = await postContactApi(newContact);
        alert(response.data.message);
        //console.table(response.data.data);
        this.FetchContact();
    }

    EditContact = async (editContact) => {
        let response = await updateContactApi(editContact);
        alert(response.data.message);
        this.FetchContact();
    }

    DeleteContact = async (id) => {
        if (window.confirm("Etes-vous sur de vouloir supprimer le contact N°" + id + " ?")) {
            let response = await deleteContactApi(id);
            alert(response.data.message)
        }
        this.FetchContact();
    }

    
    PostImage = async(id,image)=>{
        let response = await postImage(id,image)
        console.log(response.data.message);
        alert(response.data.message)
        this.FetchContact();
    }

    async componentDidMount() {
        this.FetchContact();
    }


    render() {
        return (
            <div className='container-fluid'>
                <h1>Tp Annuaire Node-Js =&gt; React</h1>

                <div className="position-absolute placement">
                    <AddContactComponent
                        newContact={this.state.newContact}
                        AddContact={this.AddContact}
                        toggleForm={this.state.toggleForm}
                        ChangeToggleForm={this.ChangeToggleForm}
                    />
                </div>

                <div className="contactList">
                    <ArrayContactComponent
                        contacts={this.state.contacts}
                        EditContact={this.EditContact}
                        DeleteContact={this.DeleteContact}
                        PostImage={this.PostImage}                        
                    />
                </div>
            </div>
        );
    }
}

export default AnnuaireView;
