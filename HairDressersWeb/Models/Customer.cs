using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HairDressersWeb.Enums;

namespace HairDressersWeb.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public WorkType? Type { get; set; }
        public string MasterSurname { get; set; }
    }
}
