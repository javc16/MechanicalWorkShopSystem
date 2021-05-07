using MechanicalWorkShopSystem.Context;
using MechanicalWorkShopSystem.Helpers;
using MechanicalWorkShopSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MechanicalWorkShopSystem.Domain
{
    public class MasterProviderService: IMasterProviderService
    {
        private readonly MechContext _context;

        public MasterProviderService(MechContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MasterProvider>> GetAll()
        {
            return await _context.MasterProvider.ToListAsync();
        }

        public async Task<Response> GetById(long id)
        {
            var masterProvider = await _context.MasterProvider.FirstOrDefaultAsync(r => r.Id == id);
            if (masterProvider == null)
            {
                return new Response { Message = "MasterProvider no exists" };
            }

            return new Response { Data = masterProvider };
        }

        public async Task<Response> PostMasterProvider(MasterProvider citizen)
        {
            await _context.SaveChangesAsync();
            return new Response { Message = "Added sucefully" };
        }

        public async Task<Response> PutMasterProvider(MasterProvider masterProvider)
        {
     
            _context.Entry(masterProvider).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return new Response { Message = "Information modified sucefully" };
        }

        public async Task<Response> DeleteMasterProvider(int id)
        {
            var masterProvider = await _context.MasterProvider.FindAsync(id);
            if (masterProvider == null)
            {
                return "No have a masterProvider with this id";
            }
            _context.MasterProvider.Remove(masterProvider);
            await _context.SaveChangesAsync();
            return new Response { Message = $"MasterProvider {masterProvider.Id}  deleted correctly" };
        }
    }
}
