using TesteEFCore2.Domain.Entities;
using TesteEFCore2.Domain.Interfaces.Repository;
using TesteEFCore2.Infra.Context;

namespace TesteEFCore2.Infra.Repository
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(TesteEFCoreContext context) 
            : base(context)
        {
        }
    }
}
