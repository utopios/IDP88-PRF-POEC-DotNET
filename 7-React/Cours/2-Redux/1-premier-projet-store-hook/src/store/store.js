import { configureStore } from "@reduxjs/toolkit";
import CounterReducer from "../reducer/CounterReducer";
import PriceReducer from "../reducer/PriceReducer";
import { combineReducers } from "redux";


const rootReducer = combineReducers({
    CounterReducer,
    PriceReducer
});

const store = configureStore({reducer: rootReducer},window.__REDUX_DEVTOOLS_EXTENSION__ && window.__REDUX_DEVTOOLS_EXTENSION__());

export default store;