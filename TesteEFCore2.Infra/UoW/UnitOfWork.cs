using TesteEFCore2.Domain.Interfaces;
using TesteEFCore2.Infra.Context;

namespace TesteEFCore2.Infra.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TesteEFCoreContext _context;

        public UnitOfWork(TesteEFCoreContext context)
        {
            _context = context;
        }

        public bool Commit()
        {
            return _context.SaveChanges() > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
