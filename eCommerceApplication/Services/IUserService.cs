using eCommerceEntity.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceApplication.Services
{
    public interface IUserService
    {
        Task CreateUser(RegisterDto registerDto);
    }
}
