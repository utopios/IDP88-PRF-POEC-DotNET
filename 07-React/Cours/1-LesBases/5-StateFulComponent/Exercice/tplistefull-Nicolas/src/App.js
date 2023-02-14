import 'bootstrap/dist/css/bootstrap.min.css';
import './App.css';
import NavBarComponent from './components/NavBarComponent/NavBarComponent';
import HeaderComponent from './components/HeaderComponent/HeaderComponent';
import FooterComponent from './components/FooterComponent/FooterComponent';
import React, { PureComponent } from 'react'
import { MyContactList } from './datas/ListContact';

export default class App extends PureComponent {

  constructor(props){
    super(props)
    this.state = {
        contacts:MyContactList
    }
  }

  render() {
    return (
      <div className="App">
<HeaderComponent />
<NavBarComponent />
<FooterComponent />
</div>
    )
  }
}
