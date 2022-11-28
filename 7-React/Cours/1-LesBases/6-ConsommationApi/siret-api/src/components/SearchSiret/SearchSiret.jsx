import React from 'react';

const SearchSiret = ({search, setsiret, siret}) => {



    return (
        <div>
            <input type="text" onChange={(e)=>setsiret(e.target.value) } />
            <button onClick={()=>search(siret)}>Valider</button>
        </div>
    );
}

export default SearchSiret;
