import React, { useState } from 'react'
import { useDispatch, useSelector } from 'react-redux';
import {INCR,DECR} from'../reducer/CounterReducer'

export default function Counter() {

    const { count, pric } = useSelector(state => ({
        ...state.CounterReducer,
        ...state.PriceReducer
    }));


    const [price, setPrice] = useState(0);

    const dispatch = useDispatch();

    const decrFunc = () => {
        dispatch({
            type: DECR
        })

    }

    const incrFunc = () => {
        dispatch({
            type: INCR
        })

    }

    const addPriceFunc = () => {
        dispatch({
            type: "ADDPRICE",
            payload: price

        })
    }

    return (
        <>
            <h1>Counter : {count}</h1>
            <h1>AddPrice : {pric}</h1>
            <button className='btn btn-primary' onClick={incrFunc}>+1</button>
            <button className='btn btn-primary' onClick={decrFunc}>-1</button><br />
            <input className='m-2' onChange={e => setPrice(e.target.value)} /><br />
            <button className='btn btn-success m-2' onClick={addPriceFunc}>AddPrice</button>
        </>



    )
}
