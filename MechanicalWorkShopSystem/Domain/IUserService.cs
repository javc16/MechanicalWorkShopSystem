using MechanicalWorkShopSystem.Helpers;
using MechanicalWorkShopSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MechanicalWorkShopSystem.Domain
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAll();
        Task<Response> GetById(long id);
        Task<Response> PostUser(User user);
        Task<Response> PutUser(User user);
        Task<Response> DeleteUser(int id);
    }
}
