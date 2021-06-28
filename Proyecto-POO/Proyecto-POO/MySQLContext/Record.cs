using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_POO.MySqlContext
{
    public partial class Record
    {
        public int IdRecord { get; set; }
        public DateTime? RecordDate { get; set; }
        public TimeSpan? RecordHour { get; set; }
        public int? IdManager { get; set; }
        public int? IdBooth { get; set; }

        public virtual Booth IdBoothNavigation { get; set; }
        public virtual Manager IdManagerNavigation { get; set; }
    }
}
