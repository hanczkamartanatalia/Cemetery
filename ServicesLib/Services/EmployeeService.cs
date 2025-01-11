using EntitiesLib.Entities;
using ServicesLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLib.Services
{
    public class EmployeeService : Service<EmployeeService>, ICrud<Employee>
    {
        Employee ICrud<Employee>.Create(Employee entity)
        {
            throw new NotImplementedException();
        }

        Employee ICrud<Employee>.Delete(Employee entity)
        {
            throw new NotImplementedException();
        }

        Employee ICrud<Employee>.Read(Employee entity)
        {
            throw new NotImplementedException();
        }

        Employee ICrud<Employee>.Update(Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
