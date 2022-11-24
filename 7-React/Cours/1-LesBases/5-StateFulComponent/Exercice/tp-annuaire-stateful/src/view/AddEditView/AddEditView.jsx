import React, { Component } from 'react';
import AddEditComponent from '../../component/AddEditComponent/AddEditComponent';



class AddEditView extends Component {

    constructor(props){
        super(props);
        console.log(props);
        this.state = {

        }
    }

    render() {
        return (
            <div>
                <h1>AddEditView</h1>
            </div>
        );
    }
}

export default AddEditView;


// const AddEditView = ({ personList, updatePersonList }) => {

//     /**
//     * FUNCTION()
//     */
//     function AddPerson(nom, prenom, email, telephone) {
//         //alert(`${nom} ${prenom} ${email} ${telephone}`);
//         let newPerson = { nom, prenom, email, telephone };
//         console.log(newPerson);
//         let listTmp = [...personList];
//         console.table(listTmp);
//         listTmp.push(newPerson)
//         console.table(listTmp);
//         updatePersonList(listTmp);
//         //updatePersonList([...personList, { nom, prenom, email, telephone }])
//         alert(`${nom} ${prenom} a été ajouté`);
//         console.table(personList);
//     }

//     return (
//         <div className='container'>
//             <AddEditComponent personList={personList} AddPerson={AddPerson} />
//         </div>
//     );
// }

// export default AddEditView;
