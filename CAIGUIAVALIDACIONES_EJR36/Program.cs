using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIGUIAVALIDACIONES_EJR36
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitar el ingreso de una fecha al usuario, repitiendo la operación 
            //(presentando un mensaje de error) hasta que el ingreso sea válido.

            do
            {
                Console.Write("Ingrese una fecha (formato MM/dd/yyyy): ");
                string ingreso = Console.ReadLine();

                if (!DateTime.TryParse(ingreso, out DateTime salida))
                {
                    Console.WriteLine("No ingreso una fecha válida.");
                }
                else
                {
                    Console.WriteLine($"Usted ingreso: {salida.ToShortDateString()}");
                    break;
                }


            } while (true);
            Console.ReadKey();

        }
    }
}
