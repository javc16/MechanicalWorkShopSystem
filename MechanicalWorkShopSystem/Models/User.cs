using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MechanicalWorkShopSystem.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Status { get; set; }
        public string IdUserType { get; set; }
        public UserType UserType { get; set; }
        public List<Recomendation> Recomendations { get; set; }

    }
}
