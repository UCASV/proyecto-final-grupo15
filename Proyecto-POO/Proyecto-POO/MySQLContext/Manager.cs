using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_POO.MySqlContext
{
    public partial class Manager
    {
        public Manager()
        {
            Appointments = new HashSet<Appointment>();
            Booths = new HashSet<Booth>();
            Records = new HashSet<Record>();
        }

        public int IdManager { get; set; }
        public string Username { get; set; }
        public string ManagerPassword { get; set; }
        public string ManagerName { get; set; }
        public string InstitutionalEmail { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Booth> Booths { get; set; }
        public virtual ICollection<Record> Records { get; set; }
    }
}
