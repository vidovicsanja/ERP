using Poslasticarnica.Core;
using Poslasticarnica.Model;

namespace Poslasticarnica.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;

        private Dictionary<string, dynamic> _repositories;

        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
            Korisnik = new KorisnikRepository(_context);
            KategorijaProizvoda = new KategorijaProizvodaRepository(_context);
            Proizvod = new ProizvodRepository(_context);
            Sastojak = new SastojakRepository(_context);
            SastojakProizvoda = new SastojakProizvodaRepository(_context);
            StavkaPorudzbine = new StavkaPorudzbineRepository(_context);
            Porudzbina = new PorudzbinaRepository(_context);
            Isporuka = new IsporukaRepository(_context);
            Placanje = new PlacanjeRepository(_context);


        }
        public IKorisnik Korisnik { get; set; }
        public IKategorijaProizvoda KategorijaProizvoda { get; set; }
        public IProizvod Proizvod { get; set; }
        public ISastojak Sastojak { get; set; }
        public ISastojakProizvoda SastojakProizvoda { get; set; }
        public IPorudzbina Porudzbina { get; set; }
        public IStavkaPorudzbine StavkaPorudzbine { get; set; }
        public IIsporuka Isporuka { get; set; }
        public IPlacanje Placanje {get; set;}

        public IBaseRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            if(_repositories==null)
            {
                _repositories = new Dictionary<string, dynamic>();

            }

            string type = typeof(TEntity).Name;

            if(_repositories.ContainsKey(type))
            {
                return (IBaseRepository<TEntity>)_repositories[type];
            }

            Type repositoryType = typeof(BaseRepository<>);
            _repositories.Add(type, Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity)), _context));
            return (IBaseRepository<TEntity>)_repositories[type];
        }

        public ApplicationContext Context
        {
            get { return _context; }
        }
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
