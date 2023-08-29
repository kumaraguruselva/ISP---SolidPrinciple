using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    internal interface ICourseRepository
    {
        void AddCourse();
        void EditCourse();
        void DeleteCourse();
        IList<Course> GetAllCourses();
    }
}
