using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaPrincipios.Open_Closed_Principle
{
    public abstract class Course_sin_OCP
    {
        public int CourseId { get; set; }
        public int Title { get; set; }

        public abstract void Subscribe(Student std);

    }

    public class Student
    {
        public string nombre { get; set; }
    }

    public class OnlineCourse: Course_sin_OCP
    {
        public override void Subscribe(Student std)
        {
            throw new NotImplementedException();
        }

        
    }
    public class OfflineCourse : Course_sin_OCP
    {
        public override void Subscribe(Student std)
        {
            throw new NotImplementedException();
        }
    }

}
