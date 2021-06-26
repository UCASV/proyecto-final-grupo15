using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POO.ViewModels
{
    public class CitizenVm1
    {
        public int Dui { get; set; }
        public string CitizenName { get; set; }
        public string Address { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Email { get; set; }
        public int? Phone { get; set; }
        public int? IdInstitution { get; set; }
        public string dateNow { get; set; }
        public string hourNow { get; set; }
    }
}
