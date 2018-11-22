using Microsoft.Extensions.DependencyInjection;
using TesteEFCore2.Domain.Interfaces;
using TesteEFCore2.Domain.Interfaces.Repository;
using TesteEFCore2.Infra.Context;
using TesteEFCore2.Infra.Repository;
using TesteEFCore2.Infra.UoW;

namespace TesteEFCore2.Infra.CrossCutting
{
    public static class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Infra - Data
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<TesteEFCoreContext>();
        }
    }
}
