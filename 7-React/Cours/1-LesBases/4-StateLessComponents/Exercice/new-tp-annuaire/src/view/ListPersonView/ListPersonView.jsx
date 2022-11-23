import React from 'react';
import ArrayComponent from '../../component/ArrayComponent/ArrayComponent';

import './ListPersonView.css'

const ListPersonView = ({personList,updatePersonList}) => {


    /**
     * FUNCTION()
     */
    function deletePerson(tabIndex){
        if(window.confirm(`Etes-vous sur de vouloir supprimer la personne n°${tabIndex+1}`)){
            let newList = personList.filter((person,index)=> index !==tabIndex);
            console.log(newList)
            updatePersonList(newList);
            alert(`Le contact n0${tabIndex+1} a été supprimé!`);
        }
    }

    return (
        <div className='container'>
            <h1 className='title'>Liste de contact</h1>
            <ArrayComponent personList={personList} updatePersonList={updatePersonList} deletePerson={deletePerson} />
        </div>
    );
}

export default ListPersonView;
