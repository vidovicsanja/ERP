﻿namespace Poslasticarnica.Model
{
    public class SastojakProizvoda : Entity
    {
        public int KolicinaSastojka { get; set; }
        public string MeraSastojka { get; set; }

        public static Sastojak Sastojak { get; set; }



    }
}
