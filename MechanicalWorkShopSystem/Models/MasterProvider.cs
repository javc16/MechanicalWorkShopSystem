using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MechanicalWorkShopSystem.Models
{
    public class MasterProvider
    {
        public int Id { get; set; }
        public int IdProvider { get; set; }
        public DateTime Date { get; set; }
        public List<Provider> Providers { get; set; }
    }
}
