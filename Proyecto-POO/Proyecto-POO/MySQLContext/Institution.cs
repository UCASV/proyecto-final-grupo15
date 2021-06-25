using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_POO.MySQLContext
{
    public partial class Institution
    {
        public Institution()
        {
            Citizens = new HashSet<Citizen>();
        }

        public int IdInstitution { get; set; }
        public string InstitutionName { get; set; }

        public virtual ICollection<Citizen> Citizens { get; set; }
    }
}
