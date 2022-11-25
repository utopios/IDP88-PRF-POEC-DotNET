import React, { Component } from 'react';
import ArrayComponent from '../../component/ArrayComponent/ArrayComponent';

import './ListPersonView.css'


class ListPersonView extends Component {
    constructor(props) {
        super(props);
        //console.table(props.personList)
    }


    /**
     * FUNCTION()
     */
    deletePerson = (tabIndex) => {
        if (window.confirm(`Etes-vous sur de vouloir supprimer la personne n°${tabIndex + 1}`)) {
            let newList = this.props.personList.filter((person, index) => index !== tabIndex);
            console.log(newList)
            this.props.updatePersonList(newList);
            alert(`Le contact n0${tabIndex + 1} a été supprimé!`);
        }
    }

    render() {
        return (
            <div className='container'>
                <h1 className='title'>Liste de contact</h1>
                <ArrayComponent personList={this.props.personList} updatePersonList={this.props.updatePersonList} deletePerson={this.deletePerson} />
            </div>
        );
    }
}

export default ListPersonView;
