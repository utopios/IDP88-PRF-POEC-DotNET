import React, { Component } from 'react';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faTrash, faPen, faCheck } from '@fortawesome/free-solid-svg-icons';
import DisplayImageComponent from '../DisplayImageComponent/DisplayImageComponent';
import './ArrayLineComponent.css';

class ArrayLineComponent extends Component {

    constructor(props) {
        super(props);
        this.state = {
            editContact: false
        };
    }

    toggleEdit = () => {
        this.setState({ editContact: !this.state.editContact });
    }

    validEdit = (e) => {
        e.preventDefault();
        if (window.confirm("Etes-vous sur de vouloir modifier le contact N°" + this.props.contact.id)) {
            let id = this.props.contact.id;
            let title = document.getElementById('title').value;
            let firstname = document.getElementById('firstname').value;
            let lastname = document.getElementById('lastname').value;
            let dateOfBirth = document.getElementById('dateOfBirth').value;
            let email = document.getElementById('email').value;
            let phone = document.getElementById('phone').value;
            let urlImg = this.props.contact.urlImg;
            let created = this.props.contact.created;
            const editContact = { id, title, firstname, lastname, dateOfBirth, urlImg, email, phone, created };
            this.props.EditContact(editContact)
            this.toggleEdit();
        }
    }

    render() {
        return this.state.editContact === false ? (
            <React.Fragment>
                <tr>
                    <th>{this.props.contact.id}</th>
                    <td>
                        <DisplayImageComponent
                            urlImg={"http://localhost:7777" + this.props.contact.urlImg}
                            id={this.props.contact.id}
                            PostImage={this.props.PostImage}
                        />
                    </td>
                    <td>{this.props.contact.title}</td>
                    <td>{this.props.contact.lastname}</td>
                    <td>{this.props.contact.firstname}</td>
                    <td>{new Date(this.props.contact.dateOfBirth).toLocaleDateString()}</td>
                    <td>{this.props.contact.email}</td>
                    <td>{this.props.contact.phone}</td>
                    <td>{new Date(this.props.contact.created).toLocaleDateString()}</td>
                    <td>{this.props.contact.updated !== " " ? new Date(this.props.contact.updated).toLocaleDateString() : "-"}</td>
                    <td>
                        <FontAwesomeIcon icon={faPen} onClick={() => this.toggleEdit()} className="fontIcon" />
                        <FontAwesomeIcon icon={faTrash} onClick={() => this.props.DeleteContact(this.props.contact.id)} className="fontIcon" />
                    </td>
                </tr>
            </React.Fragment>
        ) : (
            <React.Fragment>
                <tr>
                    <th>{this.props.contact.id}</th>
                    <td><img src={"http://localhost:7777" + this.props.contact.urlImg} alt="Contact Img" height="50px" /></td>
                    <td><input type="text" className="form-control" placeholder="Titre" name="title" id="title" defaultValue={this.props.contact.title} /></td>
                    <td><input type="text" className="form-control" placeholder="Nom" name="lastname" id="lastname" defaultValue={this.props.contact.lastname} /></td>
                    <td><input type="text" className="form-control" placeholder="Prénom" name="firstname" id="firstname" defaultValue={this.props.contact.firstname} /></td>
                    <td><input type="date" className="form-control" placeholder="Date Naissance" name="dateOfBirth" id="dateOfBirth" defaultValue={new Date(this.props.contact.dateOfBirth).toISOString().substring(0, 10)} /></td>
                    <td><input type="mail" className="form-control" placeholder="Email" name="email" id="email" defaultValue={this.props.contact.email} /></td>
                    <td><input type="text" className="form-control" placeholder="Téléphone" name="phone" id="phone" defaultValue={this.props.contact.phone} /></td>
                    <td><input className="form-control" name="created" id="created" defaultValue={new Date(this.props.contact.created).toLocaleDateString()} disabled={true} /></td>
                    <td><input className="form-control" name="updated" id="updated" defaultValue={this.props.contact.updated !== " " ? new Date(this.props.contact.updated).toLocaleDateString() : "-"} disabled={true} /></td>
                    <td>
                        <FontAwesomeIcon icon={faPen} onClick={() => this.toggleEdit(this.props.contact.id)} className="fontIcon" />
                        <FontAwesomeIcon icon={faCheck} onClick={(e) => this.validEdit(e)} className="fontIcon" color="green" />
                    </td>
                </tr>
            </React.Fragment>
        )
    }
}

export default ArrayLineComponent;
