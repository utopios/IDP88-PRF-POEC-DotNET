import axios from 'axios';

const __BASE_URL = 'http://localhost:7777/api';

const __HEADERS = {
    'Accept': 'application/json',
    'Content-Type': 'application/json'
}

export const getContactApi = (async () => {
    return await axios(__BASE_URL + '/contacts', {
        method: 'get',
        headers: __HEADERS
    });
});

export const postContactApi = (async (contact) => {
    // Declaration d'un FormData (pour le body de la request)
    let bodyFormData = new FormData();
    // Ajout des elements au formulaire
    //bodyFormData.append('Key','Value')
    bodyFormData.append('title', contact.title);
    bodyFormData.append('firstname', contact.firstname);
    bodyFormData.append('lastname', contact.lastname);
    bodyFormData.append('dateOfBirth', contact.dateOfBirth);
    bodyFormData.append('phone', contact.phone);
    bodyFormData.append('email', contact.email);
    bodyFormData.append('img', contact.img);

    return await axios({
        method: "post",
        url: __BASE_URL + "/contact",
        data: bodyFormData,
        headers: {
            "Content-Type": "multipart/form-data"
        }
    }).catch(err => {
        alert(err);
        console.log(err)
    })
});

export const updateContactApi = (async (contact) => {
    console.table(contact);
    // Declaration d'un FormData (pour le body de la request)
    let bodyFormData = new FormData();
    // Ajout des elements au formulaire
    //bodyFormData.append('Key','Value')
    bodyFormData.append('id', parseInt(contact.id));
    bodyFormData.append('title', contact.title);
    bodyFormData.append('firstname', contact.firstname);
    bodyFormData.append('lastname', contact.lastname);
    bodyFormData.append('dateOfBirth', contact.dateOfBirth);
    bodyFormData.append('urlImg', contact.urlImg);
    bodyFormData.append('phone', contact.phone);
    bodyFormData.append('email', contact.email);
    bodyFormData.append('created', contact.created);

    return await axios({
        method: "put",
        url: __BASE_URL + "/contact/" + contact.id,
        data: bodyFormData,
        headers: __HEADERS
    }).catch(err => {
        alert(err);
        console.log(err)
    })

});

export const deleteContactApi = (async (id) => {
    return await axios({
        method: "delete",
        url: __BASE_URL + "/contact/" + id,
        headers: __HEADERS
    }).catch(err => {
        alert(err);
        console.log(err)
    })

});

export const postImage = (async (id, image) => {

    let bodyFormData = new FormData();

    bodyFormData.append('img', image);

    return await axios({
        method: "post",
        url: __BASE_URL + "/contact/" + id,
        data: bodyFormData,
        headers: {
            "Content-Type": "multipart/form-data"
        }
    }).catch(err => {
        alert(err);
        console.log(err)
    })

});

