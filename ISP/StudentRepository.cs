using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    internal class StudentRepository : IStudentRepository
    {
        public void AddStudent()
        {
            throw new NotImplementedException();
        }

        public void DeleteStudent()
        {
            throw new NotImplementedException();
        }

        public void EditStudent()
        {
            throw new NotImplementedException();
        }

        public IList<Student> GetAllStudent()
        {
            throw new NotImplementedException();
        }

        public IList<Student> GetAllStudentsByCourse(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
