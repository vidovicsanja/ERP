namespace Poslasticarnica.Model
{
    public class StavkaPorudzbineController:Entity
    {
        public int Kolicina { get; set; }
        public string Mera { get; set; }

        public long? IDP{ get; set; }
        public long? IDPP { get; set; }
    }
}
