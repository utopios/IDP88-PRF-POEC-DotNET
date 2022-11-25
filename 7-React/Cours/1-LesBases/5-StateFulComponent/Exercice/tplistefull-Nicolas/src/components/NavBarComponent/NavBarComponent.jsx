import React, { PureComponent } from 'react';
import {
    BrowserRouter,
    Routes,
    Route,
    Outlet,
    Link
} from 'react-router-dom';
import './NavBarComponent.css';
import HomeView from '../../views/HomeView/HomeView';
import AddPersonView from '../../views/AddPersonView/AddPersonView';
import ListView from '../../views/ListView/ListView';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { faHome, faAddressCard, faFolderPlus } from '@fortawesome/free-solid-svg-icons'
import { MyContactList } from '../../datas/ListContact';

class NavBarComponent extends PureComponent {
    constructor(props){
        super(props)
      
        this.state = {
            contacts: MyContactList
        }

      }

    
  componentDidMount(){
    const savedList = localStorage.getItem('listContact');
     const c = savedList ? JSON.parse(savedList) : MyContactList ;
     this.setState({c});
  }

      addContact = (person) => {
        let contactTMP = [...this.state.contacts];
        let newContact = {
            id: (this.state.contacts[this.state.contacts.length-1] !== undefined)? 
            (this.state.contacts[this.state.contacts.length-1].id + 1) : 1,
            firstname : person.firstname,
            lastname : person.lastname,
            Email : person.Email,
            Phone : person.Phone
        };
        contactTMP.push(newContact);
        this.updatePersonList(contactTMP);
    }
    
    deleteContact = (id) => {
        let contactTmp = [];
        for(let contact of this.state.contacts){
            if(contact.id !== id){
                contactTmp.push(contact)
            }
        }
        this.setState({
            contacts : contactTmp
        })
        alert(`Le contact n°${id} a bien été éliminé.`)
    }
    
    editContact = (id, newContent) => {
        let contactTMP = [];
        for(let contact of this.state.contacts){
            if(contact.id === id){
              contact.firstname= newContent.firstname;
              contact.lastname= newContent.lastname;
              contact.Phone= newContent.Phone;
              contact.Email= newContent.Email;
                contactTMP.push(contact)
            } else{
                contactTMP.push(contact)
            }
        }
        this.updatePersonList(contactTMP)
    }


    updatePersonList = (list) => {
        this.setState({
            contacts : list
        })
        localStorage.setItem('listContact', JSON.stringify(this.state.contacts));
    }
    render() {
        return (
            <div>
                       <div>
            <BrowserRouter>
            <div id="NavBar">

                        <Link to="/">
                        <FontAwesomeIcon className='iconMenu' icon={faHome}/>
                        </Link>

                        <Link to="/list">
                        <FontAwesomeIcon className='iconMenu' icon={faAddressCard}/>
                        </Link>
         
                        <Link to="/form">
                        <FontAwesomeIcon className='iconMenu' icon={faFolderPlus}/>
                        </Link>
             
                </div>
                <Routes>
                    <Route path="/" element={<HomeView />} />
                    <Route path="/list" element={<ListView contacts={this.state.contacts} editContact={this.editContact} deleteContact={this.deleteContact}/>}/>
                    <Route path="/form" element={<AddPersonView contacts={this.state.contacts} addContact={this.addContact}/>} />
                    <Route path="/*" element={<HomeView />} />
                </Routes>
            </BrowserRouter>
            <div className="container">
                <Outlet />
            </div>
        </div> 
            </div>
        );
    }
}

export default NavBarComponent;

