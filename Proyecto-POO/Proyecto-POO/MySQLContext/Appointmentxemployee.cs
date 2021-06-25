using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_POO.MySQLContext
{
    public partial class Appointmentxemployee
    {
        public int IdAppointment { get; set; }
        public int IdEmployee { get; set; }

        public virtual Appointment IdAppointmentNavigation { get; set; }
        public virtual Employee IdEmployeeNavigation { get; set; }
    }
}
