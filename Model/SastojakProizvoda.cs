namespace Poslasticarnica.Model
{
    public class SastojakProizvoda : Entity
    {
        public int KolicinaSastojka { get; set; }
        public string MeraSastojka { get; set; }

        public long? SID { get; set; }

        public long? PROIZID { get; set; }



    }
}
