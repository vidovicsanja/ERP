using Microsoft.EntityFrameworkCore;
using Poslasticarnica.Core;
using Poslasticarnica.Model;

namespace Poslasticarnica.Repository
{
    public class PorudzbinaRepository : BaseRepository<Porudzbina>, IPorudzbina
    {
        public PorudzbinaRepository(DbContext context) : base(context)
        {
        }
    }
}
