using EntitiesLib.Entities;
using ServicesLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLib.Services
{
    public class EmployeeService : Service<EmployeeService, Employee>, IValidate<Employee>
    {
        public bool Validate(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
