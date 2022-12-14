import React, { Component } from 'react';
import DisplayArrayComponent from '../../component/DisplayArray/DisplayArray';
import { Apprenants } from '../../datas/Apprenants';
import './TirageView.css';

class TirageView extends Component {

    constructor(props) {
        super(props);
        this.state = {
            listApprenants: "",
            listGagnant: localStorage.getItem('ListTirage')? JSON.parse(localStorage.getItem('ListTirage')) : []
        }
    }

    getRandomInt = (min, max) => {
        return Math.floor(Math.random() * (max - min) + min);
    }

    tirageAuSort = (list) => {
        let ok = false;
        let tmp = [...this.state.listGagnant];
        console.table(tmp);
        // tant que la personne tirée est présente dans la liste des gagants
        while (!ok) {
            // Generation d'un new random int
            let randomNumber = this.getRandomInt(0, list.length);
            // Récupération, de la personne tirée
            let gagnant = list[randomNumber];
            // rechercher le gagnant correspondant dans la liste des gagnants
            const checkGagnant = this.state.listGagnant.includes(gagnant);

            if (!checkGagnant) {
                if (window.confirm(`${gagnant} a été tiré => Confirmer?`)) {
                    tmp.push(gagnant);
                    console.table(tmp);
                    if (tmp.length === this.state.listApprenants.length)
                        tmp = [];
                    console.log(tmp);
                    ok = true;
                }
            }
        }
        this.setState({
            listGagnant: tmp
        })
    }

    componentDidMount(){
        this.setState({
            listApprenants: Apprenants
        })
    }

    componentDidUpdate(prevState) {
        // Typical usage (don't forget to compare props):
        if (prevState.listGagnant !== this.state.listGagnant) {
            localStorage.setItem('ListTirage', JSON.stringify(this.state.listGagnant))
        }
    }

    render() {
        return (
            <div>
                <button className='btn btn-danger' onClick={() => this.tirageAuSort(this.state.listApprenants)}>Tirer Au sort</button>
                <DisplayArrayComponent listGagnant={this.state.listGagnant}/>
            </div>
        );
    }
}

export default TirageView;
