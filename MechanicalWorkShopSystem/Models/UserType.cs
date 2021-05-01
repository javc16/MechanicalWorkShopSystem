using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MechanicalWorkShopSystem.Models
{
    public class UserType
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public List<User> Users { get; set; }
    }
}
