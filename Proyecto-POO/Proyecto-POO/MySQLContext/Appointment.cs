using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_POO.MySqlContext
{
    public partial class Appointment
    {
        public Appointment()
        {
            Appointmentxemployees = new HashSet<Appointmentxemployee>();
            Statisticsxappointments = new HashSet<Statisticsxappointment>();
        }

        public int IdAppointment { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public TimeSpan? AppointmentHour { get; set; }
        public int? IdDose { get; set; }
        public int? IdPlatform { get; set; }
        public int? IdPlace { get; set; }
        public int? IdManager { get; set; }
        public int? IdCitizen { get; set; }

        public virtual Citizen IdCitizenNavigation { get; set; }
        public virtual Dose IdDoseNavigation { get; set; }
        public virtual Manager IdManagerNavigation { get; set; }
        public virtual VaccinationPlace IdPlaceNavigation { get; set; }
        public virtual ReservationPlatform IdPlatformNavigation { get; set; }
        public virtual ICollection<Appointmentxemployee> Appointmentxemployees { get; set; }
        public virtual ICollection<Statisticsxappointment> Statisticsxappointments { get; set; }
    }
}
