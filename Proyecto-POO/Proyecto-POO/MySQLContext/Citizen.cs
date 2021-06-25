using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_POO.MySQLContext
{
    public partial class Citizen
    {
        public Citizen()
        {
            Diseasexcitizens = new HashSet<Diseasexcitizen>();
            Effectsxcitizens = new HashSet<Effectsxcitizen>();
        }

        public int Dui { get; set; }
        public string CitizenName { get; set; }
        public string Address { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Email { get; set; }
        public int? Phone { get; set; }
        public int? IdentifierNumber { get; set; }
        public int? IdInstitution { get; set; }
        public int? IdAppointment { get; set; }

        public virtual Appointment IdAppointmentNavigation { get; set; }
        public virtual Institution IdInstitutionNavigation { get; set; }
        public virtual ICollection<Diseasexcitizen> Diseasexcitizens { get; set; }
        public virtual ICollection<Effectsxcitizen> Effectsxcitizens { get; set; }
    }
}
