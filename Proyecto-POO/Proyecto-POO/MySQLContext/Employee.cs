using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_POO.MySqlContext
{
    public partial class Employee
    {
        public Employee()
        {
            Appointmentxemployees = new HashSet<Appointmentxemployee>();
        }

        public int IdEmployee { get; set; }
        public string EmployeeName { get; set; }
        public string InstitutionalEmail { get; set; }
        public string Address { get; set; }
        public int? IdType { get; set; }

        public virtual EmployeeType IdTypeNavigation { get; set; }
        public virtual ICollection<Appointmentxemployee> Appointmentxemployees { get; set; }
    }
}
