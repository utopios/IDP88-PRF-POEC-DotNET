import React, { Component } from 'react';
import axios from "axios"
import SearchSiret from '../../components/SearchSiret/SearchSiret';

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
            siret: value
        })
    }

    search = (siret) => {
        //On effectue la recherche en utilisant l'api
        axios.get("https://api.insee.fr/entreprises/sirene/V3/siret/" + siret, { headers: { 'Authorization': 'Bearer 40f1cb09-f38c-372e-bf09-f1820687cec3' } })
            .then(res => {
                // if(res.data.header.statut === 200) {
                //     //console.log(res.data.etablissement);
                //     this.setState({
                //         entreprise : [res.data.etablissement]
                //     })
                // }
                console.log(res.data.etablissement);
            }).catch(err => {
                console.log(err)
            })
    }


    render() {
        return (
            <div>
                <SearchSiret search={this.search} setsiret={this.setsiret} siret={this.state.siret}/>
            </div>
        );
    }
}

export default ContainerSiret;
