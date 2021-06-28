using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_POO.MySqlContext
{
    public partial class Booth
    {
        public Booth()
        {
            Records = new HashSet<Record>();
        }

        public int IdBooth { get; set; }
        public string Address { get; set; }
        public int? PhoneNumber { get; set; }
        public string Email { get; set; }
        public int? IdManager { get; set; }

        public virtual Manager IdManagerNavigation { get; set; }
        public virtual ICollection<Record> Records { get; set; }
    }
}
