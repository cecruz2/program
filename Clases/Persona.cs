using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Persona
    {
        public string nombre;public string apellido;public string documento; public string direccion;
        public void Visualizarpersona(Persona per1)
        {
            Console.WriteLine($"Nombre {per1.nombre}, apellido: { per1.apellido}, direccion: {per1.direccion}, documento: {per1.documento},\n");
        }
        /// <summary>
        /// metodo para crear persona
        /// creado 08/05/2019
        /// autor
        /// </summary>
        /// <param name="personita"></param>
        public void Ingrezarpersona(Persona personita)
        {
            Console.WriteLine("ingrese el nombre");
            personita.nombre = Console.ReadLine();
            Console.WriteLine("ingrese el apellido");
            personita.apellido = Console.ReadLine();
            Console.WriteLine("ingrese el documento");
            personita.documento = Console.ReadLine();
            Console.WriteLine("ingrese el direccion");
            personita.direccion = Console.ReadLine();           
        }
        public void verificar(Persona verif)
        {
            if ((verif.nombre == "") || (verif.apellido == "") || (verif.documento == "") || (verif.direccion == ""))
            {               
                Console.WriteLine("error, tiene un valor nulo");              
            }
            else
            {
                Console.Write("es correcto");
            }
        }
        
    }
}
