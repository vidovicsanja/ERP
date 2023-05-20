export const placanje=async(ID, DatumVremePorudzbine, KID)=>
{

    return fetch('https://localhost:7186/api/porudzbina/all', {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json'
        },
    }).then(response => response.json())


}