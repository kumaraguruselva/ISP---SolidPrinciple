using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    internal interface IStudentRepository
    {

        void AddStudent();
        void EditStudent();
        void DeleteStudent();
        IList<Student> GetAllStudent();
        IList<Student> GetAllStudentsByCourse(Student student);

    }
}
