import React, { PureComponent } from 'react';
import DisplayLineComponent from '../DisplayLineComponent/DisplayLineComponent';
import "./DisplayArray.css";

export default class DisplayArrayComponent extends PureComponent {

  render() {
    return (
      <div className='container'>

        <h1>Liste de Contact</h1>
        <table className="table table-striped">
          <thead>
            <tr>
              <th scope='col-1'>ID</th>
              <th scope='col-1'>Nom</th>              
            </tr>
          </thead>
          <tbody>
            {
              !this.props.listGagnant.length === 0 ?
                <img src="./img/loading.svg" alt="Loading" className='loadingImg' />
                :
                this.props.listGagnant.map((person, index) => {
                  return (
                    <DisplayLineComponent
                      index={index}
                      person={person}
                    />
                  )
                })

            }
          </tbody>
        </table>
      </div>
    )
  }
}
