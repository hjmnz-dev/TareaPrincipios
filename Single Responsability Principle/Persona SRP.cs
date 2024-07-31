using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaPrincipios.Single_Responsability_Principle
{
    public class Persona_SRP
    {
        public string nombre { get; set; }
        public int edad { get; set; }
        public string direccion { get; set; }
        public string correoElectronico { get; set; }

        public void ImprimirDatos()
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Edad: {edad}");
            Console.WriteLine($"Direccion: {direccion}");
            Console.WriteLine($"Correo electronico: {correoElectronico}");
        }

    }
}
