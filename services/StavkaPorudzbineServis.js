export const placanje=async(ID, Kolicina, Mera, PID, PPID)=>
{

    return fetch('https://localhost:7186/api/stavkaPorudzbine/all', {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json'
        },
    }).then(response => response.json())


}