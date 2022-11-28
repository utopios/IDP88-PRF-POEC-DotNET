import React, { useEffect, useState } from 'react';
import axios from 'axios';


const AxiosView = () => {

    const __baseUrl = "http://localhost:7777";

    const [contacts, setContacts] = useState([]);

    useEffect(() => {
        const fetchCours = () => {
            axios.get(__baseUrl + "/api/contacts")
                .then(res => {
                    if (res.status === 200) {
                        alert(res.data.message);
                        console.log(res.data.data);
                        setContacts(res.data.data);
                    }
                })
                .catch(err => {
                    alert(err);
                })
        }
        fetchCours();
    }, [])

    async function addContact(contact) {

        // Declaration d'un FormData (pour le body de la request)
        let bodyFormData = new FormData();
        // Ajout des elements au formulaire
        //bodyFormData.append('Key','Value')
        bodyFormData.append('title', 'Mr');
        bodyFormData.append('firstname', 'Zorro');
        bodyFormData.append('lastname', 'Legrand');
        bodyFormData.append('dateOfBirth', '1900-06-06');
        bodyFormData.append('urlImg', ' ');
        bodyFormData.append('phone', '+33 6 41 52 63 98');
        bodyFormData.append('email', 'legrand.zorro@gmail.com');

        await axios({
            method: "post",
            url: __baseUrl + "/api/contact",
            data: bodyFormData,
            headers: {
                "Content-Type": "application/json",
                "Access-Control-Allow-Origin": "*"
            }
        }).then((res) => {
            if (res.status === 200) {
                alert(res.data.message)
            }
        }).catch(err => {
            alert(err);
            console.log(err)
        })

    }


    return (
        <div>
            <h1>Utilisation de axios</h1>
            <button onClick={() => addContact()}>Add Contact</button>
        </div>
    );
}

export default AxiosView;
