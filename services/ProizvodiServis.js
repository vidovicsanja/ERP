export const proizvod=async(ID, naziv, opis, cena, idkp)=>
{

    return fetch('https://localhost:7186/api/proizvod/all', {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json'
        },
    }).then(response => response.json())


}