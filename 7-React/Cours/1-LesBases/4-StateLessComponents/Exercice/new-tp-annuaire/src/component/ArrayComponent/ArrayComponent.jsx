import React from 'react';
import './ArrayComponent.css';

const ArrayComponent = ({ personList, updatePersonList }) => {
    return (
        <div>

            <table className="table table-striped">
                <thead>
                    <tr>
                        <th scope='col'>#</th>
                        <th scope='col'>Nom</th>
                        <th scope='col'>Prénom</th>
                        <th scope='col'>Email</th>
                        <th scope='col'>Téléphone</th>
                        <th scope='col'>Action</th>
                    </tr>
                </thead>
                <tbody>
                    {
                        personList.map((person, index) => (
                            <React.Fragment key={index}>
                                <tr >
                                    <th scope='col'>{index + 1}</th>
                                    <td>{person.nom}</td>
                                    <td>{person.prenom}</td>
                                    <td>{person.email}</td>
                                    <td>{person.telephone}</td>
                                    <td><button className='btn btn-secondary'>Supprimer</button></td>
                                </tr>
                            </React.Fragment>
                        ))
                    }
                </tbody>
            </table >

        </div >
    );
}

export default ArrayComponent;
