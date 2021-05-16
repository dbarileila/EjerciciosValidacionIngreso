using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIGUIAVALIDACIONES_EJR35
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitar el ingreso de un número al usuario, repitiendo la operación 
            //(presentando un mensaje de error) hasta que el ingreso sea válido.

            do
            {
                Console.Write("Ingrese un número: ");
                string ingreso = Console.ReadLine();

                if (!double.TryParse(ingreso, out double salida))
                {
                    Console.WriteLine("Debe ingresar un número válido.");
                    continue;
                }
                else
                {
                    Console.WriteLine($"Usted ingreso el número: {salida}");
                    break;

                }


            } while (true);

            Console.ReadKey();



        }
    }
}
