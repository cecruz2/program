using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("digite su edad");
            int salida;
            var edad =Console.ReadLine();
            var result = int.TryParse( edad,out salida);
            if (result==true)
            {
                Console.Write("el valor se puede convertir");
                salida = int.Parse(edad);
            }
            else
            {
                Console.Write("no se puede convertir");
            }



            Console.ReadLine();
        }
    }
}
