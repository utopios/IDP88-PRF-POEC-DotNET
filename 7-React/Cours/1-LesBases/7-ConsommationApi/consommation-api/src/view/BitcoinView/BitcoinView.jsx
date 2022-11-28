import React, { useState, useEffect } from 'react';

const BitcoinView = () => {

    const [loading, setloading] = useState(true);
    const [data, setData] = useState(null);
    const [currency, setCurrency] = useState(null);
    const [priceData, setPriceData] = useState(null);

    useEffect(() => {
        async function fetchPrices() {
            const res = await fetch('https://api.coindesk.com/v1/bpi/currentprice.json');
            const resJson = await res.json();
            if (resJson !== null) {
                setData(resJson);
                setCurrency(resJson.bpi.EUR.code);
                setPriceData(resJson.bpi);
                setloading(false);
                console.log(resJson.bpi);
            }
        }
        setTimeout(() => fetchPrices(), 1000);
    }, [])

    return (
        <div>
            {
                loading ?
                    <div className='loading'>
                        <img src="./img/loading.svg" alt="loading-logo" />
                    </div>
                    :
                    // <div className='priceContainer'>
                    //     <h1>{data.chartName}</h1>
                    //     <div>{data.disclaimer}</div>
                    //     <div>{data.time.updated}</div>
                    //     <div>{data.bpi.EUR.code} : {data.bpi.EUR.rate_float} €</div>
                    // </div>

                    <div>
                        <select name="currency" id="currency" onChange={(e) => setCurrency(e.target.value)}>
                            <option value="EUR">EUR (€)</option>
                            <option value="USD">USD ($)</option>
                            <option value="GBP">GBP (£)</option>
                        </select>

                        <div className='bitcoinPrice'>
                            <span>
                                <b>{currency}</b> - Price : <b>{Math.round(priceData[currency].rate_float * 100) / 100}</b> {currency === "EUR" ? "€" : currency === "USD" ? "$" : "£"}
                            </span>

                        </div>
                    </div>
            }

        </div>
    );


}

export default BitcoinView;
