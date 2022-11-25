import React from 'react';
import AddEditComponent from '../../component/AddEditComponent/AddEditComponent';
import { useParams } from 'react-router-dom';
import { useNavigate } from "react-router-dom"
import './AddEditView.css';

const AddEditView = ({ personList, updatePersonList }) => {
    let { index } = useParams();
    console.table(personList)
    let navigate = useNavigate();
    /**
     * Function     
     */
    function addPerson(nom, prenom, email, telephone) {
        updatePersonList([...personList, { nom, prenom, email, telephone }])
        alert(`${nom} ${prenom} a été ajouté!`);
        return navigate("/list");
    }

    function updatePerson(indexTab, nom, prenom, email, telephone) {
        let listTmp = [...personList];
        //console.table(listTmp);
        listTmp[indexTab] = {
            nom: nom,
            prenom: prenom,
            email: email,
            telephone: telephone,
        }
        //console.table(listTmp);
        updatePersonList(listTmp);
        index = undefined;
        alert(`${nom} ${prenom} a été Modifiée!`);
        return navigate("/list");
    }
    /**
     * JSX
     */
    return (
        <div className='container'>
            <AddEditComponent
                addPerson={addPerson}
                updatePerson={updatePerson}
                personList={personList}
                index={index}
            />
        </div>
    );
};

export default AddEditView;


// class AddEditView extends Component {

//     constructor(props){
//         super(props);
//         console.log(props);
//         this.state = {

//         }
//     }
//     /**
//     * FUNCTION()
//     */
//     AddPerson = (nom, prenom, email, telephone) =>{
//         alert(`${nom} ${prenom} ${email} ${telephone}`);
//         let newPerson = { nom, prenom, email, telephone };
//          console.log(newPerson);
//         let listTmp = [...this.props.personList];
//          console.table(listTmp);
//         listTmp.push(newPerson)
//          console.table(listTmp);
//         this.props.updatePersonList(listTmp);
//         this.props.updatePersonList([...this.props.personList, { nom, prenom, email, telephone }])
//         alert(`${nom} ${prenom} a été ajouté`);
//         console.table(personList);
//     }
//     render() {
//         return (
//             <div className='container'>
//                 <AddEditComponent personList={this.props.personList} AddPerson={this.AddPerson} />
//             </div>
//         );
//     }
// }

// export default AddEditView;
