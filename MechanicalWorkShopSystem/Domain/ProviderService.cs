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
    public class ProviderService: IProviderService
    {
        private readonly MechContext _context;

        public ProviderService(MechContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Provider>> GetAll()
        {
            return await _context.Provider.ToListAsync();
        }

        public async Task<Response> GetById(long id)
        {
            var provider = await _context.Provider.FirstOrDefaultAsync(r => r.Id == id);
            if (provider == null)
            {
                return new Response { Message = "Provider no exists" };
            }

            return new Response { Data = provider };
        }

        public async Task<Response> PostProvider(Provider provider)
        {
            if (string.IsNullOrEmpty(provider.FirstName) || string.IsNullOrEmpty(provider.LastName)
                || string.IsNullOrEmpty(provider.Phone))
            {
                return new Response { Message = "Please enter the required values" };
            }
            var SavedProvider = await _context.Provider.FirstOrDefaultAsync(r => r.Phone == provider.Phone);
            if (SavedProvider != null)
            {
                return new Response { Message = "This provider already exists in our system" };
            }      
        
            _context.Provider.Add(provider);
            await _context.SaveChangesAsync();
            return new Response { Message = "Added sucefully" };
        }

        public async Task<Response> PutProvider(Provider provider)
        {            
            _context.Entry(provider).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return new Response { Message = "Information modified sucefully" };
        }

        public async Task<Response> DeleteProvider(int id)
        {
            var provider = await _context.Provider.FindAsync(id);
            if (provider == null)
            {
                return "No have a provider with this id";
            }
            _context.Provider.Remove(provider);
            await _context.SaveChangesAsync();
            return new Response { Message = $"Provider {provider.FirstName} {provider.LastName} deleted correctly" };
        }
    }
}
