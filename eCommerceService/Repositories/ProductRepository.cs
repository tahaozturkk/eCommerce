using eCommerceApplication.Repositories;
using eCommerceApplication.Services;
using eCommerceDataAccess.Context;
using eCommerceEntity.Entities;
using eCommerceService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceService.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(eCommerceDbContext context) : base(context)
        {
        }
    }
}
