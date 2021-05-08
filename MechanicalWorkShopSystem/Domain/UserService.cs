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
    public class UserService : IUserService
    {
        private readonly MechContext _context;

        public UserService(MechContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _context.User.ToListAsync();
        }

        public async Task<Response> GetById(long id)
        {
            var user = await _context.User.FirstOrDefaultAsync(r => r.Id == id);
            if (user == null)
            {
                return new Response { Message = "User no exists" };
            }

            return new Response { Data = user };
        }

        public async Task<Response> PostUser(User user)
        {
            if (string.IsNullOrEmpty(user.FirstName) || string.IsNullOrEmpty(user.LastName)
                || string.IsNullOrEmpty(user.Phone))
            {
                return new Response { Message = "Please enter the required values" };
            }
            var SavedUser = await _context.Provider.FirstOrDefaultAsync(r => r.Phone == user.Phone);
            if (SavedUser != null)
            {
                return new Response { Message = "This user already exists in our system" };
            }

            _context.User.Add(user);
            await _context.SaveChangesAsync();
            return new Response { Message = "Added sucefully" };
        }

        public async Task<Response> PutUser(User user)
        {
            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return new Response { Message = "Information modified sucefully" };
        }

        public async Task<Response> DeleteUser(int id)
        {
            var user = await _context.User.FindAsync(id);
            if (user == null)
            {
                return "No have a provider with this id";
            }
            _context.User.Remove(user);
            await _context.SaveChangesAsync();
            return new Response { Message = $"User {user.FirstName} {user.LastName} deleted correctly" };
        }


    }
}
