import { combineReducers, createStore } from "redux";
import { TodosReducer } from "./todosReducer";

export default createStore(
    combineReducers({
        todos: TodosReducer,
        filter:(state=0,action)=>state
    }),
    window.__REDUX_DEVTOOLS_EXTENSION__ && window.__REDUX_DEVTOOLS_EXTENSION__()
)