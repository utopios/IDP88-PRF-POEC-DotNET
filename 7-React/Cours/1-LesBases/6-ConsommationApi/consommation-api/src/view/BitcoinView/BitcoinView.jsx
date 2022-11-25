import React, { useState, useEffect } from 'react';

const BitcoinView = () => {

    const [loading, setloading] = useState(true);
    const [data, setData] = useState(null);

    useEffect(() => {
        async function fetchPrices() {
            const res = await fetch('https://api.coindesk.com/v1/bpi/currentprice.json');
            const resJson = await res.json();
            if (resJson !== null) {
                setData(resJson);
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
                    <div className='priceContainer'>
                        <h1>{data.chartName}</h1>
                        <div>{data.disclaimer}</div>
                        <div>{data.time.updated}</div>
                        <div>{data.bpi.EUR.code} : {data.bpi.EUR.rate_float} €</div>
                        <div></div>
                    </div>
            }
           
        </div>
    );


}

export default BitcoinView;
