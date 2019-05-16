using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("digite el numero");
            var num = Console.ReadLine();
            var result = double.TryParse(num, out double valor1);
            if (result==(true))
            {
                valor1 = double.Parse(num);
                double resultado = Math.Sqrt(valor1);
                double resultado2 = valor1 * valor1;
                Console.WriteLine($"la raiz cuadrada del numero es: {resultado}\n el cuadrado del numero es: {resultado2}");
            
            }
            else
            {
                Console.Write("dijite numeros no letras  ");
            }
            Console.ReadLine();

        }
    }
}
