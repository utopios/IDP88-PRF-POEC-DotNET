import React from 'react';
import AddEditComponent from '../../component/AddEditComponent/AddEditComponent';
import { useParams, useNavigate } from 'react-router-dom';


const AddEditView = ({ personList, updatePersonList }) => {
    let { index } = useParams();
    let navigate = useNavigate()
    //console.log(index);
    /**
    * FUNCTION()
    */
    function AddPerson(nom, prenom, email, telephone) {
        //alert(`${nom} ${prenom} ${email} ${telephone}`);
        let newPerson = { nom, prenom, email, telephone };
        //console.log(newPerson);
        let listTmp = [...personList];
        //console.table(listTmp);
        listTmp.push(newPerson)
        // console.table(listTmp);
        updatePersonList(listTmp);
        //updatePersonList([...personList, { nom, prenom, email, telephone }])
        alert(`${nom} ${prenom} a été ajouté`);
        //console.table(personList);
    }

    function UpdatePerson(tabIndex, nom, prenom, email, telephone) {
        let tmp = [...personList];
        tmp[tabIndex] = { nom, prenom, email, telephone };
        updatePersonList(tmp);
        alert(`Le contact n°${tabIndex + 1} a été modifié!`)
        index = undefined;
        return navigate("/list");

    }

    return (
        <div className='container'>
            <AddEditComponent
                personList={personList}
                AddPerson={AddPerson}
                UpdatePerson={UpdatePerson}
                index={index} />
        </div>
    );
}

export default AddEditView;
