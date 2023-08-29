using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    internal interface IEmployeeRepository
    {
        void AddEmployee();
        void EditEmployee();
        void DeleteEmployee();
        IList<Employee> GetAllEmployee();
        IList<Employee> GetAllEmployeesByCourse(Employee emp);
    }
}
