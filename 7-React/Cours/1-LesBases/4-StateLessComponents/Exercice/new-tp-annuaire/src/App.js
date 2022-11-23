import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import { useState } from 'react';
import NavBarComponent from './component/NavBarComponent/NavBarComponent';
import { ListPerson } from './datas/ListPerson';

function App() {
  const [personList, updatePersonList] = useState(ListPerson);
  return (
    <div className="App">
      <NavBarComponent personList={personList} updatePersonList={updatePersonList} />
    </div>
  );
}

export default App;
