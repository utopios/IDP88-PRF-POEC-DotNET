import React from 'react';

const SearchSiret = ({search, setsiret, siret}) => {



    return (
        <div className='row justify-content-center'>
            <input type="text" onChange={(e)=>setsiret(e.target.value)} placeholder="Merci de saisir un siret" className="col form-control" />
            <button onClick={()=>search(siret)} className="col-3 btn btn-primary">Valider</button>
        </div>
    );
}

export default SearchSiret;
