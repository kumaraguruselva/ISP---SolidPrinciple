using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    internal class EmployeeRepository : IEmployeeRepository
    {
        public void AddEmployee()
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee()
        {
            throw new NotImplementedException();
        }

        public void EditEmployee()
        {
            throw new NotImplementedException();
        }

        public IList<Employee>GetAllEmployee()
        {
            throw new NotImplementedException();
        }

        public IList<Employee> GetAllEmployeesByCourse(Employee emp)
        {
            throw new NotImplementedException();
        }
    }
}
