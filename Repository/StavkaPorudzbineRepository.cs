using Microsoft.EntityFrameworkCore;
using Poslasticarnica.Core;
using Poslasticarnica.Model;

namespace Poslasticarnica.Repository
{
    public class StavkaPorudzbineRepository : BaseRepository<StavkaPorudzbine>, IStavkaPorudzbine
    {
        public StavkaPorudzbineRepository(DbContext context) : base(context)
        {
        }
    }
}
