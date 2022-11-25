import React, { PureComponent } from "react";
import "./ListComponent.css";
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { faTrash, faPen, faCheck } from '@fortawesome/free-solid-svg-icons'

class ListComponent extends PureComponent {
  constructor(props) {
    super(props);
    this.state = {
        contact : props.contacts,
      activeEdit: false
    };
  }

setToActiveEdit = () => {
    this.setState({activeEdit : true});
}

createEditPerson = (e) => {
    e.preventDefault();
    let firstname =  document.getElementById('firstname').value;
    let lastname =document.getElementById('lastname').value;
    let Email = document.getElementById('Phone').value;
    let Phone = document.getElementById('Email').value;
    const editPerson = {firstname, lastname, Email, Phone};
    this.props.editContact(this.props.contact.id, editPerson)
    this.setState({activeEdit : false})
}

  render() {
    return this.state.activeEdit === false ? (
        <React.Fragment>
          <tr>
             <th>{this.props.contact.id}</th>
             <td>{this.props.contact.firstname}</td>
             <td>{this.props.contact.lastname}</td>
             <td>{this.props.contact.Email}</td>
             <td>{this.props.contact.Phone}</td>
             <td>
              <FontAwesomeIcon icon = {faPen} onClick={() => this.setToActiveEdit(this.props.contact.id)} />
              <FontAwesomeIcon icon={faTrash}  onClick={() => this.props.deleteContact(this.props.contact.id)} />
              </td>
           </tr> 
        </React.Fragment>
    ) : (
        <React.Fragment>
          <tr>
             <th>{this.props.contact.id}</th>
             <td><input className="form-control mb-3" type="text" placeholder='nom' name="firstname" id="firstname" defaultValue={this.props.contact.firstname}/></td>
             <td> <input type="text" className="form-control mb-3" placeholder='prenom' name="lastname" id="lastname" defaultValue={this.props.contact.lastname}/></td>
             <td> <input type="text" className="form-control mb-3" placeholder='téléphone' name="Phone" id="Phone" defaultValue={this.props.contact.Email} /></td>
             <td> <input type="mail" className="form-control mb-3" placeholder='adresse mail' name="Email" id="Email" defaultValue={this.props.contact.Phone}/></td>
             <td> <FontAwesomeIcon icon = {faCheck} onClick={(e) => this.createEditPerson(e)} /> </td>
           </tr> 
        </React.Fragment>
    )
  }
}

export default ListComponent;
