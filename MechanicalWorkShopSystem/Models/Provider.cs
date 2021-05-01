﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MechanicalWorkShopSystem.Models
{
    public class Provider
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Bussines { get; set; }
        public string Address { get; set; }
        public int Status { get; set; }
        public int IdMasterProvider { get; set; }
        public MasterProvider MasterProvider { get; set; }
        public List<Recomendation> Recomendations { get; set; }
    }
}
