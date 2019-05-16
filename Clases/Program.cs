using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona per1 = new Persona();
           
            Persona per2 = new Persona();

            per1.Ingrezarpersona(per1);
            per2.Ingrezarpersona(per2);

            per1.Visualizarpersona(per1);
            per2.Visualizarpersona(per2);

            per1.verificar(per1);
            per2.verificar(per2);


           Console.ReadLine();
        }
    }
}
