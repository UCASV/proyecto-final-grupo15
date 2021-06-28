using Proyecto_POO.MySqlContext;
using Proyecto_POO.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POO.ViewModels
{
    public class CitizenMapper
    {
        public static CitizenVm MapCitizenToCitizenVm(Citizen c)
        {
            return new CitizenVm
            {
                Dui = c.Dui,
                CitizenName = c.CitizenName,
                Address = c.Address,
                Birthdate = c.Birthdate,
                Email = c.Email,
                Phone = c.Phone,
                IdInstitution = c.IdInstitution

            };
        }

        public static EmployeeVm MapEmployeeToEmployeeVm(Employee em)
        {
            return new EmployeeVm
            {
                IdEmployee = em.IdEmployee,
                EmployeeName = em.EmployeeName,
                InstitutionalEmail = em.InstitutionalEmail,
                Address = em.Address,
                IdType = em.IdType                   
            };
        }
    }
}
