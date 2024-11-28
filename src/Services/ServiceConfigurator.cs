using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace ta_liberado
{
    internal class ServiceConfigurator
    {
        public static IServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();

            // Registra os serviços e repositórios
            //serviceCollection.AddScoped<IUserRepository, UserRepository>();
            //serviceCollection.AddScoped<IAuthService, AuthService>();

            // Retorna o provedor de serviços
            return serviceCollection.BuildServiceProvider();
        }
    }
}
