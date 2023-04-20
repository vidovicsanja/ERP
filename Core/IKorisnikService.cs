using Poslasticarnica.Model;
using Poslasticarnica.Repository;

namespace Poslasticarnica.Core
{
    public interface IKorisnikService : GetCurrentUser
    {
        Korisnik GetCurrentUser(string email);

        public Korisnik Register(Korisnik korisnik);
    }


}
