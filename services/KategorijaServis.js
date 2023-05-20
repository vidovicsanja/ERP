export const placanje=async(ID, NazivKategorije)=>
{

    return fetch('https://localhost:7186/api/kategorija/all', {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json'
        },
    }).then(response => response.json())


}