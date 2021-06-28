using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_POO.MySqlContext
{
    public partial class Statisticsxappointment
    {
        public int IdStatistics { get; set; }
        public int IdAppointment { get; set; }

        public virtual Appointment IdAppointmentNavigation { get; set; }
        public virtual Statistic IdStatisticsNavigation { get; set; }
    }
}
