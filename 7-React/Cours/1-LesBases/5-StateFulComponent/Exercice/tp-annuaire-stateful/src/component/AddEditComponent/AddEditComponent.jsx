import React, { Component } from 'react';

class AddEditComponent extends Component {
    constructor(props) {
        super(props);
        this.state = {
            nom: "",
            prenom: "",
            email: "",
            telephone: "",
        }
    }


    componentDidMount(){
        console.log(this.props.index)
        const getPerson = () => {
            if (this.props.index) {
                let person = this.props.personList[this.props.index];
                this.setState({
                    nom : person.nom,
                    prenom : person.prenom,
                    email: person.email,
                    telephone:person.telephone
                })
            }
        }
        getPerson();
    }
    componentDidUpdate(){

    }

    render() {
        return (
            <div>
                <h1>{this.props.index ? "Update" : "Add Person"}</h1>
                <div className="card">
                    <form>
                        <div className="form-control formulaire">
                            <div className="mb-2">
                                <label htmlFor="nom">Nom : </label>
                                <input type="text" name="nom" id="nom" onChange={(e) => this.setState({ nom: e.target.value })} className="form-control" value={this.state.nom} />
                            </div>
                            <div className="mb-2">
                                <label htmlFor="prenom">Prénom : </label>
                                <input type="text" name="prenom" id="prenom" onChange={(e) => this.setState({ prenom: e.target.value })} className="form-control" value={this.state.prenom} />
                            </div>
                            <div className="mb-2">
                                <label htmlFor="email">Email : </label>
                                <input type="email" name="email" id="email" onChange={(e) => this.setState({ email: e.target.value })} className="form-control" value={this.state.email} />
                            </div>
                            <div className="mb-2">
                                <label htmlFor="telephone">Téléphone : </label>
                                <input type="text" name="telephone" id="telephone" onChange={(e) => this.setState({ telephone: e.target.value })} className="form-control" value={this.state.telephone} />
                            </div>


                            {
                            this.props.index === undefined ?
                                <button className='btn btn-secondary form-contol' onClick={() => this.props.AddPerson(this.state.nom, this.state.prenom, this.state.email, this.state.telephone)}>Ajouter</button>
                                :
                                <button className='btn btn-secondary form-contol' onClick={() => this.props.UpdatePerson(this.props.index, this.state.nom, this.state.prenom, this.state.email, this.state.telephone)}>Modifier</button>
                        }

                        </div>
                    </form>
                </div>
            </div>
        );
    }
}

export default AddEditComponent;




// import React, { useState, useEffect } from 'react';
//const AddEditComponent = ({ personList, UpdatePerson, AddPerson, index }) => {

//     /**
//     * States
//     */
//     const [nom, setNom] = useState('');
//     const [prenom, setPrenom] = useState('');
//     const [email, setEmail] = useState('');
//     const [telephone, setTelephone] = useState('');




//     return (
//         <>
            // <h1>{index ? "Update Person" : "Add Person"}</h1>
            // <div className="card">
            //     <form>
            //         <div className="form-control formulaire">
            //             <div className="mb-2">
            //                 <label htmlFor="nom">Nom : </label>
            //                 <input type="text" name="nom" id="nom" onChange={(e) => setNom(e.target.value)} className="form-control" value={nom} />
            //             </div>
            //             <div className="mb-2">
            //                 <label htmlFor="prenom">Prénom : </label>
            //                 <input type="text" name="prenom" id="prenom" onChange={(e) => setPrenom(e.target.value)} className="form-control" value={prenom} />
            //             </div>
            //             <div className="mb-2">
            //                 <label htmlFor="email">Email : </label>
            //                 <input type="email" name="email" id="email" onChange={(e) => setEmail(e.target.value)} className="form-control" value={email} />
            //             </div>
            //             <div className="mb-2">
            //                 <label htmlFor="telephone">Téléphone : </label>
            //                 <input type="text" name="telephone" id="telephone" onChange={(e) => setTelephone(e.target.value)} className="form-control" value={telephone} />
            //             </div>

       
            //         </div>
            //     </form>
            // </div>

//         </>
//     );
// }

// export default AddEditComponent;
