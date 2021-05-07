using MechanicalWorkShopSystem.Helpers;
using MechanicalWorkShopSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MechanicalWorkShopSystem.Domain
{
    public interface IMasterProviderService
    {
        Task<IEnumerable<MasterProvider>> GetAll();
        Task<Response> GetById(long id);
        Task<Response> PostMasterProvider(MasterProvider masterProvider);
        Task<Response> PutMasterProvider(MasterProvider masterProvider);
        Task<Response> DeleteMasterProvider(int id);
    }
}
