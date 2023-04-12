namespace Poslasticarnica.Model
{
    public class StavkaPorudzbine:Entity
    {
        public int Kolicina { get; set; }
        public string Mera { get; set; }

        public static Proizvod Proizvod { get; set; }
        public static Porudzbina Porudzbina { get; set; }
    }
}
