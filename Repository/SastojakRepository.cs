using Microsoft.EntityFrameworkCore;
using Poslasticarnica.Core;
using Poslasticarnica.Model;

namespace Poslasticarnica.Repository
{
    public class SastojakRepository : BaseRepository<Sastojak>, ISastojak
    {
        public SastojakRepository(DbContext context) : base(context)
        {
        }
    }
}
