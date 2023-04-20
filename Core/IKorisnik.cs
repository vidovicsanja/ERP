using Poslasticarnica.Model;

namespace Poslasticarnica.Core
{
    public interface IKorisnik:IBaseRepository<Korisnik>, GetCurrentUser
    {
        Korisnik GetWIthEmail(string email);
    }
}
