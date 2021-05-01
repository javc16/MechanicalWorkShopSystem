using MechanicalWorkShopSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MechanicalWorkShopSystem.Context
{
    public class MechContext : DbContext
    {
        public MechContext(DbContextOptions<MechContext> options) : base(options)
        {

        }

        public DbSet<User> User { get; set; }
        public DbSet<UserType> UserType { get; set; }
        public DbSet<Provider> Provider { get; set; }
        public DbSet<MasterProvider> MasterProvider { get; set; }
        public DbSet<Recomendation> Recomendation { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            //optionBuilder.UseSqlServer(@"Server=38.17.54.162,51688;Database=MechanicalWorkShopSystem30042021;User Id=devops;Password=Yf4-Sf");
            optionBuilder.UseSqlServer(@"Server=38.17.54.162,51688;Database=MechanicalWorkShopSystem30042021;User Id=tempWork;Password=Temp123456");
        }
    }
}
