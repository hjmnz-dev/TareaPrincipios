using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaPrincipios.Single_Responsability_Principle
{
    public class Persona_sin_SRP
    {
        public string nombre { get; set; }
        public int edad { get; set; }
        public string direccion { get; set; }
        public string correoElectronico { get; set; }

        public void EnviarCorreoElectronico(string mesnaje)
        {
            //Logica de enviar correo
        }

        public void ImprimirDatos()
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Edad: {edad}");
            Console.WriteLine($"Direccion: {direccion}");
            Console.WriteLine($"Correo electronico: {correoElectronico}");
        }

        //Esta clase violenta el principio SRP porque tiene dos responsabilidades, manejar los datos
        //de la persona y tambien enviar correo. Para poder poner en practica el principio
        //se deberia de separar esta otra tarea en otra clase.
    }
}
