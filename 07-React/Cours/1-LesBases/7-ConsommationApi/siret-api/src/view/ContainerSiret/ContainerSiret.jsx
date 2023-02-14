import React, { Component } from 'react';
import axios from "axios"
import SearchSiret from '../../components/SearchSiret/SearchSiret';
import DisplayEntreprise from '../../components/DisplayEntreprise/DisplayEntreprise';

class ContainerSiret extends Component {
    constructor(props) {
        super(props)
        this.state = {
            entreprise: null,
            siret: ""
        }
    }

    setsiret = (value) => {
        this.setState({
            siret: value,
            entreprise:null
        })
    }

    search = (siret) => {
        //On effectue la recherche en utilisant l'api
        axios.get("https://api.insee.fr/entreprises/sirene/V3/siret/" + siret, { headers: { 'Authorization': 'Bearer ad8b2aac-0fd5-3446-ac6d-cfc772f6ef03' } })
            .then(res => {
                if(res.data.header.statut === 200) {
                    //console.log(res.data.etablissement);
                    this.setState({
                        entreprise : [res.data.etablissement]
                    })
                }
                console.log(res.data.etablissement);
            }).catch(err => {
                console.log(err)
            })
    }


    render() {
        return (
            <div>
                <SearchSiret search={this.search} setsiret={this.setsiret} siret={this.state.siret}/>
                <DisplayEntreprise entreprise={this.state.entreprise}/>
            </div>
        );
    }
}

export default ContainerSiret;
