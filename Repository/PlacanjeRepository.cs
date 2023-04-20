using Microsoft.EntityFrameworkCore;
using Poslasticarnica.Core;
using Poslasticarnica.Model;

namespace Poslasticarnica.Repository
{
    public class PlacanjeRepository : BaseRepository<Placanje>, IPlacanje
    {
        public PlacanjeRepository(DbContext context) : base(context)
        {
        }
    }
}
