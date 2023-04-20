namespace Poslasticarnica.Model
{
    public class Placanje:Entity
    {


        public Boolean Placeno { get; set; }
        public double Iznos { get; set; }
        public string Valuta { get; set; }
        public DateTime DatumVremePlacanja { get; set; }
    }
}
