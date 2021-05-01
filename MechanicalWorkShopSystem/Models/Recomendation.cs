using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MechanicalWorkShopSystem.Models
{
    public class Recomendation
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public User User { get; set; }
        public int IdProvider { get; set; }
        public Provider Provider { get; set; } 
        public int Position { get; set; }
    }
}
