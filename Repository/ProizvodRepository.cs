using Microsoft.EntityFrameworkCore;
using Poslasticarnica.Core;
using Poslasticarnica.Model;

namespace Poslasticarnica.Repository
{
    public class ProizvodRepository : BaseRepository<Proizvod>, IProizvod
    {
        public ProizvodRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<Proizvod> GetByName(string name) 
        {
            return ApplicationContext.Proizvod.Where
                (x => x.NazivProizvoda.ToLower() == name.ToLower()).ToList();
        }
    }
}
