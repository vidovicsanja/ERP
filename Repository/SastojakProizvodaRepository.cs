using Microsoft.EntityFrameworkCore;
using Poslasticarnica.Core;
using Poslasticarnica.Model;

namespace Poslasticarnica.Repository
{
    public class SastojakProizvodaRepository : BaseRepository<SastojakProizvoda>, ISastojakProizvoda
    {
        public SastojakProizvodaRepository(DbContext context) : base(context)
        {
        }
    }
}
