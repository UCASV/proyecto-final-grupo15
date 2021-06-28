using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_POO.MySqlContext
{
    public partial class SideEffect
    {
        public SideEffect()
        {
            Effectsxcitizens = new HashSet<Effectsxcitizen>();
        }

        public int IdEffect { get; set; }
        public string SideEffect1 { get; set; }

        public virtual ICollection<Effectsxcitizen> Effectsxcitizens { get; set; }
    }
}
