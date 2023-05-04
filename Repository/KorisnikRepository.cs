using Microsoft.EntityFrameworkCore;
using Poslasticarnica.Core;
using Poslasticarnica.Model;


namespace Poslasticarnica.Repository
{
    public class KorisnikRepository : BaseRepository<Korisnik>, IKorisnik
    {
        public KorisnikRepository(DbContext context) : base(context)
        {
        }

        public Korisnik GetWIthEmail(string email) 
        {
            return ApplicationContext.Korisnik.Where(x => x.Email == email).FirstOrDefault();
        }




    }
}
