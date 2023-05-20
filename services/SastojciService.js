export const sastojak=async(ID, nazivSastojka, alergen)=>
{

    return fetch('https://localhost:7186/api/sastojak/all', {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json'
        },
    }).then(response => response.json())


}