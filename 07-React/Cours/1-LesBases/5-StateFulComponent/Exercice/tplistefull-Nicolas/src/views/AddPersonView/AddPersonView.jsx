import React, { PureComponent } from 'react';
// import { MyContactList } from '../../datas/ListContact';
import './AddPersonView.css'

class AddPersonView extends PureComponent {
  
  constructor(props){
    super(props)
    this.states = {
      contacts: props.contacts
  }
  this.handleSubmit =this.handleSubmit.bind(this)
  }
  



getUniqueID(arr) {
  let maxID = 0;
  for(const id of arr){
      console.log(id.id)
      if(maxID < id.id){
          maxID = id.id;
      }
  }
  
  return maxID + 1;
}

handleSubmit(e){
  e.preventDefault();
  let firstname = e.target['firstname'].value;
  let lastname = e.target['lastname'].value;
  let Email = e.target['Email'].value;
  let Phone = e.target['Phone'].value;
  const newPerson = {firstname , lastname, Email, Phone};
  this.props.addContact(newPerson);
  alert("Le contact a bien été ajouté.");
  let f = document.getElementById('addForm');
  f.reset();
  }


  render() {
    return (
      <div>
          <h1>Ajouter un contact</h1>

<form onSubmit={this.handleSubmit} id="addForm">
    <div className="cadreForm">
    <input className="form-control mb-3" type="text" placeholder='nom' name="firstname" id="firstname"/>
    <input type="text" className="form-control mb-3" placeholder='prenom' name="lastname" id="lastname" />
    <input type="text" className="form-control mb-3" placeholder='téléphone' name="Phone" id="Phone" />
    <input type="mail" className="form-control mb-3" placeholder='adresse mail' name="Email" id="Email"/>
    <button type="submit" className="btn btn-success">Valider</button> 
    </div>
</form>
      </div>
    )
  }
}

export default AddPersonView;
