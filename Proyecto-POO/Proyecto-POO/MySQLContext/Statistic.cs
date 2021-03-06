using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_POO.MySqlContext
{
    public partial class Statistic
    {
        public Statistic()
        {
            Statisticsxappointments = new HashSet<Statisticsxappointment>();
        }

        public int IdStatistic { get; set; }
        public DateTime? StatisticDate { get; set; }
        public TimeSpan? StatisticHour { get; set; }
        public int? IdAppointment { get; set; }

        public virtual ICollection<Statisticsxappointment> Statisticsxappointments { get; set; }
    }
}
