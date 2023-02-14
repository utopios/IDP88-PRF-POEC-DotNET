import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import { useState, useEffect } from 'react';
import NavBarComponent from './component/NavBarComponent/NavBarComponent';
import { ListPerson } from './datas/ListPerson';

function App() {
  const savedList = localStorage.getItem('List');

  const [personList, updatePersonList] = useState(savedList? JSON.parse(savedList) : ListPerson);

  useEffect(() => {
    localStorage.setItem('List', JSON.stringify(personList))
  }, [personList]);

  return (
    <div className="App">
      <NavBarComponent personList={personList} updatePersonList={updatePersonList} />
    </div>
  );
}

export default App;
