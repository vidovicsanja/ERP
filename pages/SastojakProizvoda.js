import {useState} from "react"

const SastojakProizvoda=()=>{

  const [data,setData] = useState([])

  const renderSastojakProizvoda = () => {

    let result = []

    for(let item of data) {
      result.push(<tr>
        <td>{item.ID}</td>
        <td>{item.KolicinaSastojka}</td>
        <td>{item.MeraSastojka}</td>
        <td>{item.SID}</td>
        <td>{item.PROIZID}</td>

      </tr>)
    }

    return result
  }

    return <div>
        <h1>Sastojci proizvoda</h1>

        <table class="table">
  <thead>
    <tr>
      <th scope="col">ID sastojka u proizvodu</th>
      <th scope="col">Kolicina sastojka</th>
      <th scope="col">Mera</th>
      <th scope="col">ID Proizvoda</th>
      <th scope="col">ID sastojka</th>


    </tr>
  </thead>
  <tbody>
   {renderSastojakProizvoda()}
  </tbody>
</table>

    </div>
}

export default SastojakProizvoda