using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaPrincipios.Open_Closed_Principle;

namespace TareaPrincipios.Liskov_Substitution_Principle
{
    public abstract class Course_con_LSP
    {
        public int CourseId { get; set; }
        public string Title{ get; set; }
        public abstract void Subscribe(Student std);
        public abstract string GetCourseDetails();

    }

    public class Student
    {
        public string nombre { get; set; }
    }

    public class OnlineCourse : Course_con_LSP
    {
        public override void Subscribe(Student std)
        {
            throw new NotImplementedException();
        }
        public override string GetCourseDetails()
        {
            return $"Online Course: {Title}, CourseId: {CourseId}";
        }
    }

    public class OfflineCourse : Course_con_LSP
    {
        public override void Subscribe(Student std)
        {
            throw new NotImplementedException();
        }
        public override string GetCourseDetails()
        {
            return $"Offline Course: {Title}, CourseId: {CourseId}";
        }
    }

    public class HybridCourse : Course_con_LSP
    {
        private readonly OnlineCourse onlineCourse;
        private readonly OfflineCourse offlineCourse;

        public HybridCourse(OnlineCourse onlineCourse, OfflineCourse offlineCourse)
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
        public override string GetCourseDetails()
        {
            return $"Hybrid Course: {Title}, CourseId: {CourseId}\n" +
                   $"{onlineCourse.GetCourseDetails()}\n" +
                   $"{offlineCourse.GetCourseDetails()}";
        }
    }

}
