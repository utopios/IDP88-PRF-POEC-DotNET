import React from 'react';
import AddEditComponent from '../../component/AddEditComponent/AddEditComponent';

const AddEditView = ({ personList, updatePersonList }) => {

    /**
    * FUNCTION()
    */
    function AddPerson(nom, prenom, email, telephone) {
        //alert(`${nom} ${prenom} ${email} ${telephone}`);
        let newPerson = { nom, prenom, email, telephone };
        console.log(newPerson);
        let listTmp = [...personList];
        console.table(listTmp);
        listTmp.push(newPerson)
        console.table(listTmp);
        updatePersonList(listTmp);
        //updatePersonList([...personList, { nom, prenom, email, telephone }])
        alert(`${nom} ${prenom} a été ajouté`);
        console.table(personList);
    }

    return (
        <div className='container'>
            <AddEditComponent personList={personList} AddPerson={AddPerson} />
        </div>
    );
}

export default AddEditView;
