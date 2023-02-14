import 'bootstrap/dist/css/bootstrap.min.css';
import './App.css';
import { useState , useEffect } from 'react';
import NavBarComponent from './components/NavBarComponent/NavBarComponent';
import HeaderComponent from './components/HeaderComponent/HeaderComponent';
import FooterComponent from './components/FooterComponent/FooterComponent';

function App() {

  const savedCart = localStorage.getItem('cart');
  //const [cart, updateCart] = useState([]);

  const [cart, updateCart] = useState(savedCart ? JSON.parse(savedCart) : []);

  useEffect(()=>{
    localStorage.setItem('cart', JSON.stringify(cart))
  },[cart])

  return (
    <div className="App">
      <HeaderComponent />
      <NavBarComponent cart={cart} updateCart={updateCart} />
      <FooterComponent />
    </div>
  );
}

export default App;
