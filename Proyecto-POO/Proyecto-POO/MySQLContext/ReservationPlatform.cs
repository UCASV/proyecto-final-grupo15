using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_POO.MySqlContext
{
    public partial class ReservationPlatform
    {
        public ReservationPlatform()
        {
            Appointments = new HashSet<Appointment>();
        }

        public int IdPlatform { get; set; }
        public string Platform { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
