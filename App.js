
import './App.css';
import { Routes, Route, Outlet, Link, BrowserRouter as Router } from "react-router-dom";

import Isporuka from './pages/Isporuka';
import KategorijaProizvoda from './pages/KategorijaProizvoda';
import Proizvodi from './pages/Proizvodi';
import SastojakProizvoda from './pages/SastojakProizvoda';
import Sastojci from './pages/Sastojci';
import Placanje from './pages/Placanje';
import Porudzbina from './pages/Porudzbina';
import About from './pages/About';
import Login from './pages/Login';
import Registration from './pages/Registration';

function App() {
  return (
        <Router>
          <Routes>
            <Route path="/kategorije" element={<KategorijaProizvoda />}/>
            <Route path="/proizvodi" element={<Proizvodi />}/>
            <Route path="/porudzbina" element={<Porudzbina />}/>
            <Route path="/isporuka" element={<Isporuka />}/>
            <Route path="/placanje" element={<Placanje />}/>
            <Route path="/sastojci" element={<Sastojci />}/>
            <Route path="/about" element={<About />}/>
            <Route path="/login" element={<Login />}/>
            <Route path="/registration" element={<Registration />}/>
            
           </Routes>
        </Router>
  );

}

export default App;
