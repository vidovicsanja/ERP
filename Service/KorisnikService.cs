using Poslasticarnica.Core;
using Poslasticarnica.Model;
using Poslasticarnica.Model.dto;
using Poslasticarnica.Repository;

namespace Poslasticarnica.Service;

public class KorisnikService : BaseService<IsporukaService>, IKorisnikService
{
    public Korisnik GetCurrentUser(string email)
    {
        try
        {
            using UnitOfWork unitOfWork = new UnitOfWork(new ApplicationContext());

            return unitOfWork.Korisnik.GetWIthEmail(email);
        }
        catch (Exception e) 
        {
            return null;
        }
    }


    public Korisnik Register(RegistrationDTO korisnik)
    {
        try
        {
            using UnitOfWork unitOfWork = new UnitOfWork(new ApplicationContext());


            Korisnik k = new Korisnik();

            k.KorisnickoIme = korisnik.KorisnickoIme;
            k.Lozinka = BCrypt.Net.BCrypt.HashPassword(korisnik.Lozinka);
            k.Ime = korisnik.Ime;
            k.Prezime = korisnik.Prezime;
            k.Email= korisnik.Email;
            k.BrojTelefona = korisnik.BrojTelefona;
            k.Uloga = "Kupac";

            unitOfWork.Korisnik.Add(k);
            unitOfWork.Complete();

            return k;
        }
        catch (Exception e)
        {
            return null;
        }

    }

    public Korisnik AddSeller(RegistrationDTO korisnik)
    {
        try
        {
            using UnitOfWork unitOfWork = new UnitOfWork(new ApplicationContext());


            Korisnik k = new Korisnik();

            k.KorisnickoIme = korisnik.KorisnickoIme;
            k.Lozinka = BCrypt.Net.BCrypt.HashPassword(korisnik.Lozinka);
            k.Ime = korisnik.Ime;
            k.Prezime = korisnik.Prezime;
            k.Email = korisnik.Email;
            k.BrojTelefona = korisnik.BrojTelefona;
            k.Uloga = "Prodavac";

            unitOfWork.Korisnik.Add(k);
            unitOfWork.Complete();

            return k;
        }
        catch (Exception e)
        {
            return null;
        }

    }
}
