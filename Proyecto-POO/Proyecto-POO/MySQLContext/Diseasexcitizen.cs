using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_POO.MySqlContext
{
    public partial class Diseasexcitizen
    {
        public int IdDisease { get; set; }
        public int IdCitizen { get; set; }

        public virtual Citizen IdCitizenNavigation { get; set; }
        public virtual Disease IdDiseaseNavigation { get; set; }
    }
}
