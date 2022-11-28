import React, { useState, useEffect } from 'react';

const Stateless = () => {
    // useState => Hook d'état
    const [count, setCount] = useState(0);

    // useEffect = > Hook d'état (Équivalent à componentDidMount plus componentDidUpdate) :
    useEffect(() => {
        // Mettre à jour le titre du document en utilisant l'API du navigateur
        document.title = `Vous avez cliqué ${count} fois`;
    },[count]);

    return (
        <div>
            <p>StateLess =&gt; Vous avez cliqué {count} fois</p>
            <button onClick={() => setCount(count + 1)}>
                Incrémenter
            </button>
            <button onClick={() => setCount(0)}>
                Reset
            </button>
        </div>
    );
};

export default Stateless;