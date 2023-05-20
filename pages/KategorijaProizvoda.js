import {useState} from "react"

const KategorijaProizvoda = () => {

  const [data,setData] = useState([])

  const renderKategorijaProizvoda = () => {

    let result = []

    for(let item of data) {
      result.push(<tr>
        <td>{item.ID}</td>
        <td>{item.NazivLKategorije}</td>


      </tr>)
    }

    return result
  }

    return <div>
        <h1>KategorijaProizvoda</h1>

        <table class="table">
  <thead>
    <tr>
      <th scope="col">ID kategorije</th>
      <th scope="col">Naziv kategorija</th>

    </tr>
  </thead>
  <tbody>
   {renderKategorijaProizvoda()}
  </tbody>
</table>

    </div>
}


export default KategorijaProizvoda