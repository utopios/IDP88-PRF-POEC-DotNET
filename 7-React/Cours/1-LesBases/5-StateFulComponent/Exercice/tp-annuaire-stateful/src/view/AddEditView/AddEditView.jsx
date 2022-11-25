import React, { Component } from 'react';
import AddEditComponent from '../../component/AddEditComponent/AddEditComponent';



class AddEditView extends Component {

    constructor(props){
        super(props);
        console.log(props);
        this.state = {

        }
    }
    /**
    * FUNCTION()
    */
    AddPerson = (nom, prenom, email, telephone) =>{
        //alert(`${nom} ${prenom} ${email} ${telephone}`);
        let newPerson = { nom, prenom, email, telephone };
         //console.log(newPerson);
        let listTmp = [...this.props.personList];
         console.table(listTmp);
        listTmp.push(newPerson)
         console.table(listTmp);
        this.props.updatePersonList(listTmp);
        // this.props.updatePersonList([...this.props.personList, { nom, prenom, email, telephone }])
        alert(`${nom} ${prenom} a été ajouté`);
        // console.table(personList);
    }
    render() {
        return (
            <div className='container'>
                <AddEditComponent personList={this.props.personList} AddPerson={this.AddPerson} />
            </div>
        );
    }
}

export default AddEditView;
