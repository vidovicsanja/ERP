using Poslasticarnica.Core;
using Poslasticarnica.Model;
using Poslasticarnica.Repository;

namespace Poslasticarnica.Service
{
    public class ProizvodService : BaseService<Proizvod>, IProizvodService
    {

        public IEnumerable<Proizvod> GetByName(string name) 
        {
            try
            {
                using UnitOfWork unitOfWork = new UnitOfWork(new ApplicationContext());

                return unitOfWork.Proizvod.GetByName(name);
            }
            catch (Exception e) 
            {
                return new List<Proizvod>();
            }
        }
    }
}
