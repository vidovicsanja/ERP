using Poslasticarnica.Model;
using Poslasticarnica.Model.dto;
using Poslasticarnica.Repository;

namespace Poslasticarnica.Core
{
    public interface IKorisnikService : GetCurrentUser
    {
        Korisnik GetCurrentUser(string email);

        public Korisnik Register(RegistrationDTO korisnik);
        public Korisnik AddSeller(RegistrationDTO korisnik);
    }


}
