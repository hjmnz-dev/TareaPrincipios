using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaPrincipios.Open_Closed_Principle
{
    public abstract class Course_con_OCP
    {
        public int CourseId { get; set; }
        public string Title { get; set; }

        public abstract void Subscribe(Student std);
    }

    public class OnlineCourseOCP : Course_con_OCP
    {
        public override void Subscribe(Student std)
        {
            // Lógica para suscribirse a un curso en línea
            
        }
    }

    public class OfflineCourseOCP : Course_con_OCP
    {
        public override void Subscribe(Student std)
        {
            // Lógica para suscribirse a un curso fuera de línea
        }
    }

    public class HybridCourse : Course_con_OCP
    {
        private readonly OnlineCourseOCP onlineCourse;
        private readonly OfflineCourseOCP offlineCourse;

        public HybridCourse(OnlineCourseOCP onlineCourse, OfflineCourseOCP offlineCourse)
        {
            this.onlineCourse = onlineCourse;
            this.offlineCourse = offlineCourse;
        }

        public override void Subscribe(Student std)
        {
            // Lógica para suscribirse a ambos cursos
            onlineCourse.Subscribe(std);
            offlineCourse.Subscribe(std);
        }
    }

}
