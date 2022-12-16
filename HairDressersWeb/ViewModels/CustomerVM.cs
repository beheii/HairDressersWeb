using HairDressersWeb.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HairDressersWeb.ViewModels
{
    public class CustomerVM
    {
        public WorkType? Type { get; set; }
        public string MasterSurname { get; set; }
    }
}
