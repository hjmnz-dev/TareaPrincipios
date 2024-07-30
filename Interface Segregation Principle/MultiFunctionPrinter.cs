using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaPrincipios.Interface_Segregation_Principle.Interfaces;

namespace TareaPrincipios.Interface_Segregation_Principle
{
    internal class MultiFunctionPrinter : IPrintable, IScannable
    {
        public void Print()
        {
            Console.WriteLine("Imprimiendo desde una impresora multifunción");
        }

        public void Scan()
        {
            Console.WriteLine("Escaneando documento");
        }
    }
}
