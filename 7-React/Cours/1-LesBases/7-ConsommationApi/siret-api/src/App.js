import logo from './logo.svg';
import './App.css';
import ContainerSiret from './view/ContainerSiret/ContainerSiret';

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <ContainerSiret/>
      </header>
    </div>
  );
}

export default App;
