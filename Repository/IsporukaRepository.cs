using Microsoft.EntityFrameworkCore;
using Poslasticarnica.Core;
using Poslasticarnica.Model;

namespace Poslasticarnica.Repository
{
    public class IsporukaRepository:BaseRepository<Isporuka>, IIsporuka
    {
        public IsporukaRepository(DbContext context) : base(context)
        {
        }
    }
}
