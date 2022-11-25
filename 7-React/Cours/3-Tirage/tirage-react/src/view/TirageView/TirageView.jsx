import React, { Component } from 'react';
import { Apprenants } from '../../datas/Apprenants';
import './TirageView.css';

class TirageView extends Component {

    constructor(props) {
        super(props);
        this.state = {
            listApprenants: Apprenants,
            listGagnant:[]
        }
    }

    getRandomInt=(min, max) => {
        return Math.floor(Math.random() * (max - min) + min);
      }

    tirageAuSort = (list) => {
        //console.log(list)
        const randomNumber = this.getRandomInt(0,list.length);
        //console.log(randomNumber);
        const gagnant = list[randomNumber];
        //console.log(gagnant);
        this.setState({
            listGagnant:[...this.state.listGagnant,gagnant]
        })
        
    }

    render() {
        return (
            <div>
                <button className='btn btn-danger' onClick={() => this.tirageAuSort(this.state.listApprenants)}>Tirer Au sort</button>
            </div>
        );
    }
}

export default TirageView;
