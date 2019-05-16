using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecuacion
{
    class Program
    {
        
        static void Main(string[] args)
        {           
            Console.Write("digite el valor para a");
            var a = Console.ReadLine();
            var result1 = double.TryParse(a, out double valor1);

            Console.Write("digite el valor para b");
            var b = Console.ReadLine();
            var result2 = double.TryParse(b, out double valor2);

            Console.Write("digite el valor para c");
            var c = Console.ReadLine();
            var result3 = double.TryParse(c, out double valor3);
             
            if ((result1 == true) && (result2 == true) && (result3 == true))
            {
                valor1 = double.Parse(a);
                valor2 = double.Parse(b);
                valor3 = double.Parse(c);                
            }
            else
            {
                Console.Write("digite solo numeros");
            }
            
            if (valor2 == 0)
            {
                Console.Write("el resultado es negativo");
            }
            else
            {
                double resultado1 = (-(valor2)) + -Math.Sqrt((valor2 * valor2) - 4 * (valor1 * valor3)) / 2 * valor1;
                double resultado2 = (-(valor2)) - -Math.Sqrt((valor2 * valor2) - 4 * (valor1 * valor3)) / 2 * valor1;
                Console.WriteLine("el resultado 1 " + resultado1);
                Console.WriteLine("el resultado 2 " + resultado2);
            }
            Console.ReadLine();
        }
    }
}
