namespace Poslasticarnica.Core
{
    public interface IUnitOfWork : IDisposable
    {
        int Complete();
        void Dispose();
    }
}
