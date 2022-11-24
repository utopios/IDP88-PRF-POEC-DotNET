import React, { Component } from 'react';
import ArrayComponent from '../../component/ArrayComponent/ArrayComponent';

import './ListPersonView.css'


class ListPersonView extends Component {
    constructor(props) {
        super(props);
        //console.table(props.personList)
        this.state = {

        }
    }
    render() {
        return (
            <div>
                <h1>ListPersonView</h1>
                {console.table(this.props.personList)}
            </div>
        );
    }
}

export default ListPersonView;


// const ListPersonView = ({personList,updatePersonList}) => {


//     /**
//      * FUNCTION()
//      */
//     function deletePerson(tabIndex){
//         if(window.confirm(`Etes-vous sur de vouloir supprimer la personne n°${tabIndex+1}`)){
//             let newList = personList.filter((person,index)=> index !==tabIndex);
//             console.log(newList)
//             updatePersonList(newList);
//             alert(`Le contact n0${tabIndex+1} a été supprimé!`);
//         }
//     }

//     return (
//         <div className='container'>
//             <h1 className='title'>Liste de contact</h1>
//             <ArrayComponent personList={personList} updatePersonList={updatePersonList} deletePerson={deletePerson} />
//         </div>
//     );
// }

// export default ListPersonView;
