import {useState} from "react"

const Porudzbina=()=>{

  const [data,setData] = useState([])

  const renderPorudzbina = () => {

    let result = []

    for(let item of data) {
      result.push(<tr>
        <td>{item.ID}</td>
        <td>{item.DatumVremePorudzbine}</td>
        <td>{item.KID}</td>


      </tr>)
    }

    return result
  }

    return <div>
        <h1>Porudzbina</h1>

        <table class="table">
  <thead>
    <tr>
      <th scope="col">ID porudzbina</th>
      <th scope="col">Datum i vreme porudzbine</th>
      <th scope="col">ID korisnika</th>

    </tr>
  </thead>
  <tbody>
   {renderPorudzbina()}
  </tbody>
</table>

    </div>

}

export default Porudzbina