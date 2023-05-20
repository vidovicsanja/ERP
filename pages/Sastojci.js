import {useState} from 'react'

const Sastojci=()=>{


  const [data,setData] = useState([])

  const renderSastojci = () => {

    let result = []

    for(let item of data) {
      result.push(<tr>
        <td>{item.id}</td>
        <td>{item.nazivSastojka}</td>
        <td>{item.alergen}</td>

      </tr>)
    }

    return result
  }

    return <div>
        <h1>Sastojci</h1>

        <table class="table">
  <thead>
    <tr>
      <th scope="col">ID sastojka</th>
      <th scope="col">Naziv sastojka</th>
      <th scope="col">Alergeni</th>
    </tr>
  </thead>
  <tbody>
   {renderSastojci()}
  </tbody>
</table>

    </div>
}

export default Sastojci