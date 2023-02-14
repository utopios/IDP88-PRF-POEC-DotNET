import React, { Component } from 'react';
import ArrayLineComponent from '../../component/ArrayLineComponent/ArrayLineComponent'
import './ArrayContactComponent.css';

class ArrayContactComponent extends Component {
    render() {
        return (
            <div>
                <h1>Liste de Contact</h1>
                <table className="table table-striped">
                    <thead>
                        <tr>
                            <th scope='col'>ID</th>
                            <th scope='col'>Image</th>
                            <th scope='col'>Titre</th>
                            <th scope='col'>Nom</th>
                            <th scope='col'>Prenom</th>
                            <th scope='col'>Date Naissance</th>
                            <th scope='col'>Mail</th>
                            <th scope='col'>Téléphone</th>
                            <th scope='col'>Created</th>
                            <th scope='col'>Updated</th>
                            <th scope='col'>Action</th>
                        </tr>
                    </thead>
                    <tbody>
                        {
                            this.props.contacts.length === 0 ?
                                <img src="./img/loading.svg" alt="Loading" className='loadingImg' />
                                :
                                this.props.contacts.map((contact, index) => {
                                    return (
                                        <ArrayLineComponent
                                            key={index}
                                            contact={contact}
                                            EditContact={this.props.EditContact}
                                            DeleteContact={this.props.DeleteContact}
                                            PostImage={this.props.PostImage}
                                        />
                                    )
                                })

                        }
                    </tbody>
                </table>
            </div>
        );
    }
}

export default ArrayContactComponent;
