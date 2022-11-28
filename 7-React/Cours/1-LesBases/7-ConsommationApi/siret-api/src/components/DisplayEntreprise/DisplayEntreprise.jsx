import React from 'react';

const DisplayEntreprise = ({ entreprise }) => {
    return (
        <div className='row entreprise'>
            {
                entreprise !== null ?

                    <div>
                        <div className="col">
                            <div className="row m-1">
                                <div className="col-6 offset-1">SIRET : </div>
                                <div className="col">{entreprise[0].siret}</div>
                            </div>
                            <div className="row m-1">
                                <div className="col-6 offset-1">Nom entreprise : </div>
                                <div className="col">{entreprise[0].uniteLegale.denominationUniteLegale}</div>
                            </div>
                            <div className="row m-1">
                                <div className="col-6 offset-1">Siège social : </div>
                                <div className="col">{entreprise[0].etablissementSiege ? "Oui" : "Non"}</div>
                            </div>
                            <div className="row m-1">
                                <div className="col-6 offset-1">Date de création : </div>
                                <div className="col">{entreprise[0].dateCreationEtablissement}</div>
                            </div>
                            <div className="row m-2">
                                <div className="col-6 offset-1">Date dernier traitement : </div>
                                <div className="col">{entreprise[0].dateDernierTraitementEtablissement}</div>
                            </div>
                            <div className="row m-1">
                                <div className="col-6 offset-1">Adresse : </div>
                                <div className="col">
                                    {entreprise[0].adresseEtablissement.numeroVoieEtablissement ?
                                        entreprise[0].adresseEtablissement.numeroVoieEtablissement + ' ' : ''}
                                    {entreprise[0].adresseEtablissement.typeVoieEtablissement ?
                                        entreprise[0].adresseEtablissement.typeVoieEtablissement + ' ' : ''}
                                    {entreprise[0].adresseEtablissement.libelleVoieEtablissement + ' - '}
                                    {entreprise[0].adresseEtablissement.codePostalEtablissement + ' '}
                                    {entreprise[0].adresseEtablissement.libelleCommuneEtablissement + ' '}
                                    <div>{entreprise[0].adresseEtablissement.complementAdresseEtablissement}</div>
                                </div>
                            </div>
                        </div>
                    </div>
                    :
                    <div>
                        <img src="./img/loading.svg" alt="Loading..." />
                    </div>
            }

        </div>
    );
}

export default DisplayEntreprise;
