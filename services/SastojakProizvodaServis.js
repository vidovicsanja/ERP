export const placanje=async(ID, KolicinaSatojka, MeraSastojka, SID, PROIZID)=>
{

    return fetch('https://localhost:7186/api/sastojakProizvoda/all', {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json'
        },
    }).then(response => response.json())


}