using Microsoft.EntityFrameworkCore;
using Poslasticarnica.Core;
using Poslasticarnica.Model;

namespace Poslasticarnica.Repository
{
    public class KategorijaProizvodaRepository:BaseRepository<KategorijaProizvoda>, IKategorijaProizvoda
    {
        public KategorijaProizvodaRepository(DbContext context) : base(context)
        {
        }
    }
}
