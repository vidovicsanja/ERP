import {useState} from "react";
import { putProizvodi } from "../services/ProizvodiServis";

const PutProizvodi = () => {
    const [ID, setID] = useState()
    const [naziv, setNaziv] = useState()
    const [opis, setOpis]=useState()
    const [cena, setCena]=useState()
    const [idkp, setIDKP]=useState()
    
    const putClick = () => {
      console.log(ID, naziv, opis, cena, idkp)
      putProizvodi(ID, naziv, opis, cena, idkp).then(response => 
          console.log(response)
        )
      }
    
      return <section class="vh-100" style={{backgroundColor: '#eee'}}>
      <div class="container h-100">
        <div class="row d-flex justify-content-center align-items-center h-100">
          <div class="col-lg-12 col-xl-11">
            <div class="card text-black" style={{borderRadius: '25px'}}>
              <div class="card-body p-md-5">
                <div class="row justify-content-center">
                  <div class="col-md-10 col-lg-6 col-xl-5 order-2 order-lg-1">
    
                    <p class="text-center h1 fw-bold mb-5 mx-1 mx-md-4 mt-4">Dodajte novi proizvod</p>
    
                    <form class="mx-1 mx-md-4">
    
                      <div class="d-flex flex-row align-items-center mb-4">
                        <i class="fas fa-user fa-lg me-3 fa-fw"></i>
                        <div class="form-outline flex-fill mb-0">
                          <input type="text" id="form3Example1c" class="form-control" onChange={(e) => setID(e.target.value)} />
                          <label class="form-label" for="form3Example1c">ID</label>
                        </div>
                      </div>
    
                      <div class="d-flex flex-row align-items-center mb-4">
                        <i class="fas fa-envelope fa-lg me-3 fa-fw"></i>
                        <div class="form-outline flex-fill mb-0">
                          <input type="email" id="form3Example3c" class="form-control" onChange={(e) => setNaziv(e.target.value)}/>
                          <label class="form-label" for="form3Example3c">Naziv proizvoda</label>
                        </div>
                      </div>
    
                      <div class="d-flex flex-row align-items-center mb-4">
                        <i class="fas fa-user fa-lg me-3 fa-fw"></i>
                        <div class="form-outline flex-fill mb-0">
                          <input type="text" id="form3Example1c" class="form-control" onChange={(e) => setOpis(e.target.value)} />
                          <label class="form-label" for="form3Example1c">Opis proizvoda</label>
                        </div>
                      </div>
    
                      <div class="d-flex flex-row align-items-center mb-4">
                        <i class="fas fa-user fa-lg me-3 fa-fw"></i>
                        <div class="form-outline flex-fill mb-0">
                          <input type="text" id="form3Example1c" class="form-control" onChange={(e) => setCena(e.target.value)}/>
                          <label class="form-label" for="form3Example1c">Cena proizvoda</label>
                        </div>
                      </div>
    
                      <div class="d-flex flex-row align-items-center mb-4">
                        <i class="fas fa-user fa-lg me-3 fa-fw"></i>
                        <div class="form-outline flex-fill mb-0">
                          <input type="text" id="form3Example1c" class="form-control" onChange={(e) => setIDKP(e.target.value)}/>
                          <label class="form-label" for="form3Example1c">ID kategorije proizvoda</label>
    
                        </div>
                      </div>
    
                      <div class="d-flex justify-content-center mx-4 mb-3 mb-lg-4">
                          <button type="button" onClick={() => putClick()}class="btn btn-primary btn-lg">Dodajte novi proizvod</button>
                        </div>
    
                      </form>
                      </div>
                      </div>
                      </div>
                      </div>
                      </div>
                      </div>
                      </div>
                      </section>
    }

    export default PutProizvodi