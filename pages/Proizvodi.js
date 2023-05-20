import {useState} from "react";

const Proizvodi=()=>{

  const [data,setData] = useState([])

  const renderProizvodi = () => {

    let result = []

    for(let item of data) {
      result.push(<tr>
        <td>{item.id}</td>
        <td>{item.naziv}</td>
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

    </div>
}

export default Proizvodi
