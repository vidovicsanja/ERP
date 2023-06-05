export const getPorudzbina=async(ID, DatumVremePorudzbine, KID)=>
{

    return fetch('https://localhost:7186/api/porudzbina/all', {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json',
            'Authorization': 'Bearer ' + localStorage.getItem('token')
        },
    }).then(response => response.json())


}