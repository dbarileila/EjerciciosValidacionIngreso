using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIGUIAVALIDACIONES_EJR37
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitar el ingreso de una cadena al usuario, repitiendo la operación 
            //(presentando un mensaje de error) hasta que el ingreso sea válido. Debe tener entre 10 y 20 caracteres.

            do
            {
                Console.Write("Ingrese una cadena de texto (entre 10 y 20 caracteres): ");
                string ingreso = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ingreso))
                {
                    Console.WriteLine("Debe ingresar texto.");
                    continue;
                }

                if (!ingreso.All(c => Char.IsLetter(c) || Char.IsWhiteSpace(c)))
                {
                    Console.WriteLine("Debe ingresar sólo texto.");
                    continue;

                }

                if (ingreso.Length <10 || ingreso.Length >20)
                {
                    Console.WriteLine("El texto debe tener entre 10 y 20 caracteres.");
                    continue;
                }
                else
                {
                    Console.WriteLine($"{ingreso}");
                    break;
                }
    



            } while (true);
            Console.ReadKey();

        }
    }
}
