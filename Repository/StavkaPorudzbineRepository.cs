using Microsoft.EntityFrameworkCore;
using Poslasticarnica.Core;
using Poslasticarnica.Model;

namespace Poslasticarnica.Repository
{
    public class StavkaPorudzbineRepository : BaseRepository<StavkaPorudzbineController>, IStavkaPorudzbine
    {
        public StavkaPorudzbineRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<StavkaPorudzbineController> GetByKorisnik(long korisnikId)
        {
            return ApplicationContext.StavkaPorudzbine.Where(x => x.Id == korisnikId).ToList();
        }
    }
}
