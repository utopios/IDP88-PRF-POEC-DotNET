import React from 'react';
import ArrayComponent from '../../component/ArrayComponent/ArrayComponent';
import './ListPersonView.css'

const ListPersonView = ({personList,updatePersonList}) => {
    return (
        <div className='container'>
            <h1 className='title'>Liste de contact</h1>
            <ArrayComponent personList={personList} updatePersonList={updatePersonList}/>
        </div>
    );
}

export default ListPersonView;
