using eCommerceApplication.Repositories;
using eCommerceApplication.Services;
using eCommerceService.Repositories;
using eCommerceService.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceService
{
    public static class ServiceRegistration
    {
        public static void ServiceRegister(this IServiceCollection Services)
        {
            Services.AddScoped<IProductRepository, ProductRepository>();
            Services.AddScoped<IProductService, ProductService>();
            Services.AddScoped<IUserService, UserService>();
        }
    }
}
