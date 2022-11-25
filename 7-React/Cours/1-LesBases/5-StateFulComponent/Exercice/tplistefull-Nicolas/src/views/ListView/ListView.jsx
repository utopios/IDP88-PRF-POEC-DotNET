import React, { PureComponent } from 'react'
import "./ListView.css"
import ListComponent from '../../components/ListComponent/ListComponent'

export default class ListView extends PureComponent {
 
  constructor(props){
    super(props)
    this.state = {
      contacts : props.contacts
  }
  }

  render() {
    return (
      <div>

      <h1>Voici votre liste de contacts</h1>
      <table className="table table-striped">
                     <thead>
    <tr>
      <th>ID</th>
      <th>Prenom</th>
      <th>Nom</th>
      <th>Mail</th>
      <th>Téléphone</th>
      <th>Action</th>
    </tr>
  </thead>
  <tbody>
        {
        this.props.contacts.map((contact, index) => {
      return (
     
        <ListComponent 
        key= {index}
        contact = {contact}
        deleteContact={this.props.deleteContact}
        editContact={this.props.editContact}
        />
      )
        })
        }
        </tbody>
        </table>
      </div>
    )
  }
}
