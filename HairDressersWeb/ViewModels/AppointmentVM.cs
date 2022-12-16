using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HairDressersWeb.ViewModels
{
    public class AppointmentVM
    {
        public int CustomerId { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
    }
}
