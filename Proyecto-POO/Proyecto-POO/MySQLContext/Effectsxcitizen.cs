using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_POO.MySqlContext
{
    public partial class Effectsxcitizen
    {
        public int IdEffect { get; set; }
        public int IdCitizen { get; set; }

        public virtual Citizen IdCitizenNavigation { get; set; }
        public virtual SideEffect IdEffectNavigation { get; set; }
    }
}
