﻿using System.Security.Cryptography.X509Certificates;

namespace Poslasticarnica.Model
{
    public class Porudzbina : Entity
    {

        public DateTime DatumVremePorudzbine { get; set; }
        public long? KID { get; set; }
            

    }
}
