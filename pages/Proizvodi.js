import {useEffect, useState} from "react";
import { getProizvodi, onClick} from "../services/ProizvodiServis";

const Proizvodi=()=>{

  const [data,setData] = useState([])


  useEffect(() => {
    fetchData(1, 5)
  }, [])

  const fetchData = (page, perPage) => {
    getProizvodi(page, perPage).then(response => {
      setData(response || [])
    })
  }


  const renderProizvodi = () => {

    let result = []

    for(let item of data) {
      result.push(<tr>
        <td>{item.id}</td>
        <td>{item.nazivProizvoda}</td>
        <td>{item.cena}</td>
        <td>{item.opis}</td>
        <td>{item.idkp}</td>

      </tr>)
    }

    return result
  }

    return <div>
        <h1>Proizvodi</h1>

        <table class="table">
  <thead>
    <tr>
      <th scope="col">ID proizvoda</th>
      <th scope="col">Naziv proizvoda</th>
      <th scope="col">Cena proizvoda</th>
      <th scope="col">Opis proizvoda</th>
      <th scope="col">ID kategorije proizvoda</th>
    </tr>
  </thead>
  <tbody>
   {renderProizvodi()}
  </tbody>
</table>

<button onClick={() => fetchData(1, 5)}>
  1
</button>

<button onClick={() => fetchData(2, 5)}>
  2
</button>

<button onClick={() => fetchData(3, 5)}>
  3
</button>

<button onClick={() => fetchData(4, 5)}>
  4
</button>

<button onClick={() => fetchData(5, 5)}>
  5
</button>


</div>

}

export default Proizvodi

