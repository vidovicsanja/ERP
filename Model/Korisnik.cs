﻿namespace Poslasticarnica.Model
{
    public class Korisnik:Entity
    {

        
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string Uloga { get; set; }
    }
}
