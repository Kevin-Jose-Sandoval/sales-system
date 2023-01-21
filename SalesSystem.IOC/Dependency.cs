using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SalesSystem.DAL.DBContext;
using Microsoft.EntityFrameworkCore;
/*using SalesSystem.DAL.Interfaces;
using SalesSystem.DAL.Implementation;
using SalesSystem.BLL.Interfaces;
using SalesSystem.BLL.Implementation;*/

namespace SalesSystem.IOC
{
    public static class Dependency
    {
        public static void InjectDependency(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<salessystemContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("StringSQL"));
            });
        }
    }
}
