namespace Poslasticarnica.Model
{
    public class StavkaPorudzbineController:Entity
    {
        public int Kolicina { get; set; }
        public string Mera { get; set; }

        public long? PID{ get; set; }
        public long? PPID{ get; set; }
    }
}
