using Poslasticarnica.Model;

namespace Poslasticarnica.Core
{
    public interface IProizvod:IBaseRepository<Proizvod>

    {
        IEnumerable<Proizvod> GetByName(string name);
    }
}
