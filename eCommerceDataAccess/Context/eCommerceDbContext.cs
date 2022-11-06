using eCommerceEntity.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceDataAccess.Context
{
    public class eCommerceDbContext : IdentityDbContext<AppUser>
    {
        public eCommerceDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
