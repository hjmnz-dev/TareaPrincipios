using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaPrincipios.Open_Closed_Principle;

namespace TareaPrincipios.Liskov_Substitution_Principle
{
    public abstract class Course_sin_LSP
    {
        public int CourseId { get; set; }
        public string Title { get; set; }

        public abstract void Subscribe(Student std);
    }

    public class OnlineCourseLSP : Course_sin_LSP
    {
        public override void Subscribe(Student std)
        {
            throw new NotImplementedException();
        }
    }

    public class OfflineCourseLSP : Course_sin_LSP
    {
        public override void Subscribe(Student std)
        {
            throw new NotImplementedException();
        }
    }

    public class HybridCourseLSP : Course_sin_LSP
    {
        public override void Subscribe(Student std)
        {
            throw new NotImplementedException();
        }
    }
}
