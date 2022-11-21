import 'bootstrap/dist/css/bootstrap.min.css';
import './App.css';
import NavBarComponent from './components/NavBarComponent/NavBarComponent';
import HeaderComponent from './components/HeaderComponent/HeaderComponent';
import FooterComponent from './components/FooterComponent/FooterComponent';

function App() {
  return (
    <div className="App">
      <HeaderComponent />
      <NavBarComponent />
      <FooterComponent />
    </div>
  );
}

export default App;
