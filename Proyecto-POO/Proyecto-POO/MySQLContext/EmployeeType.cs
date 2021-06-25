using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_POO.MySQLContext
{
    public partial class EmployeeType
    {
        public EmployeeType()
        {
            Employees = new HashSet<Employee>();
        }

        public int IdType { get; set; }
        public string EmployeeType1 { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
