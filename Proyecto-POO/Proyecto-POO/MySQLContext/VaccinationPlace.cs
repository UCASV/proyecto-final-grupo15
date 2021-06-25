using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_POO.MySQLContext
{
    public partial class VaccinationPlace
    {
        public VaccinationPlace()
        {
            Appointments = new HashSet<Appointment>();
        }

        public int IdPlace { get; set; }
        public string PlaceName { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
