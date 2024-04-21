namespace Poslasticarnica.Model
{
    public class Proizvod :Entity
    {

        public string NazivProizvoda { get; set; }
        public string Opis { get; set; }

        public double Cena { get; set; }

        /*public string Url { get; set; }*/

        public long? IDKP { get; set; }



    }
}
