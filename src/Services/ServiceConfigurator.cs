using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Api;
using Google.Cloud.Firestore;
using Microsoft.Extensions.DependencyInjection;

namespace ta_liberado
{
    internal class ServiceConfigurator
    {
        public static ServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            // Banco de dados
            services.AddSingleton(provider =>
            {
                var serviceAccountPath = "serviceAccount.json";
                var databaseId = "ta-liberado";
                Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", serviceAccountPath);
                return FirestoreDb.Create(databaseId);
            });

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<AuthService>();
            services.AddScoped<LoginForm>();

            return services.BuildServiceProvider();
        }
    }
}
