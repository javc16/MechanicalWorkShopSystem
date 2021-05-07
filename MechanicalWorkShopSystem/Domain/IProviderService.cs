using MechanicalWorkShopSystem.Helpers;
using MechanicalWorkShopSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MechanicalWorkShopSystem.Domain
{
    public interface IProviderService
    {
        Task<IEnumerable<Provider>> GetAll();
        Task<Response> GetById(long id);
        Task<Response> PostProvider(Provider provider);
        Task<Response> PutProvider(Provider provider);
        Task<Response> DeleteProvider(int id);
    }
}
