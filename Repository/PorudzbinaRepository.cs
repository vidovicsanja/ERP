using Microsoft.EntityFrameworkCore;
using Poslasticarnica.Core;
using Poslasticarnica.Model;

namespace Poslasticarnica.Repository
{
    public class PorudzbinaRepository : BaseRepository<KorisnikController>, IPorudzbina
    {
        public PorudzbinaRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<KorisnikController> GetByKorisnik(long korisnikId)
        {
            return ApplicationContext.Porudzbina.Where(x => x.Id == korisnikId).ToList();
        }
    }
}
