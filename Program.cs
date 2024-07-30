
using TareaPrincipios.Interface_Segregation_Principle.Interfaces;
using TareaPrincipios.Interface_Segregation_Principle;
using TareaPrincipios.Open_Closed_Principle;
using TareaPrincipios.Liskov_Substitution_Principle;
using HybridCourse = TareaPrincipios.Liskov_Substitution_Principle.HybridCourse;
using OfflineCourse = TareaPrincipios.Liskov_Substitution_Principle.OfflineCourse;
using OnlineCourse = TareaPrincipios.Liskov_Substitution_Principle.OnlineCourse;
using Student = TareaPrincipios.Liskov_Substitution_Principle.Student;

//Prueba Aplicando Principio de abierto y cerrado (OCP)


StudentOCP studentOCP = new StudentOCP { Name = "John Doe" };

OnlineCourseOCP onlineCourseOCP = new OnlineCourseOCP { CourseId = 1, Title = "C# Online" };
OfflineCourseOCP offlineCourseOCP = new OfflineCourseOCP { CourseId = 2, Title = "C# Offline" };
HybridCourseOCP hybridCourseOCP = new HybridCourseOCP(onlineCourseOCP, offlineCourseOCP) { CourseId = 3, Title = "C# Hybrid" };

onlineCourseOCP.Subscribe(studentOCP);
offlineCourseOCP.Subscribe(studentOCP);
hybridCourseOCP.Subscribe(studentOCP);

// Prueba Aplicando el Principio de Sustitución de Liskov (LSP)

Student student = new Student { nombre = "Hamsell Jimenez" };

OnlineCourse onlineCourse = new OnlineCourse { CourseId = 1, Title = "C# Online" };
OfflineCourse offlineCourse = new OfflineCourse { CourseId = 2, Title = "C# Offline" };
HybridCourse hybridCourse = new HybridCourse(onlineCourse, offlineCourse) { CourseId = 3, Title = "C# Hybrid" };

Course_con_LSP[] courses = new Course_con_LSP[] { onlineCourse, offlineCourse, hybridCourse };

foreach (var course in courses)
{
    course.Subscribe(student);
    Console.WriteLine(course.GetCourseDetails());
}
// Prueba Aplicando el Principio de segregación de interfaz (ISP)

SimplePrinter simplePrinter = new SimplePrinter();
simplePrinter.Print();

MultiFunctionPrinter multiFunctionPrinter = new MultiFunctionPrinter();
multiFunctionPrinter.Print();
multiFunctionPrinter.Scan();