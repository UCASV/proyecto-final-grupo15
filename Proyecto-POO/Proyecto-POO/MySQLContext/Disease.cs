using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_POO.MySQLContext
{
    public partial class Disease
    {
        public Disease()
        {
            Diseasexcitizens = new HashSet<Diseasexcitizen>();
        }

        public int IdDisease { get; set; }
        public string ChronicDisease { get; set; }

        public virtual ICollection<Diseasexcitizen> Diseasexcitizens { get; set; }
    }
}
