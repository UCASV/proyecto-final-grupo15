using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_POO.MySqlContext
{
    public partial class Dose
    {
        public Dose()
        {
            Appointments = new HashSet<Appointment>();
        }

        public int IdDose { get; set; }
        public string Dose1 { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
