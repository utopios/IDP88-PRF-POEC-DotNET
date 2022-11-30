import { configureStore } from "@reduxjs/toolkit";
import CounterReducer from "../reducer/CounterReducer";
import PriceReducer from "../reducer/PriceReducer";
import { combineReducers } from "redux";


const rootReducer = combineReducers({
    CounterReducer,
    PriceReducer
});

const store = configureStore({reducer: rootReducer});

export default store;