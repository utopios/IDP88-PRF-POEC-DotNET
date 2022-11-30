import './App.css';
import store from './store';
import { Provider } from 'react-redux'// npm install react-redux
import { TodoListStore } from './components/TodoList';


function App() {
  return (
    <Provider store={store}>
      <TodoListStore/>
    </Provider>
    );
}

export default App;
