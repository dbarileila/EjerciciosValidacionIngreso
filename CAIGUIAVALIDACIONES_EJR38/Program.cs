using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIGUIAVALIDACIONES_EJR38
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitar el ingreso de una serie de números al usuario, donde cada número 
            //de la serie debe ser mayor al anterior.

         
            do
            {
                
                    Console.Write("Ingrese un número: ");
                    string ingreso = Console.ReadLine();

                    Console.Write("Ingrese otro número: ");
                    string ingreso2 = Console.ReadLine();

                    if (!int.TryParse(ingreso, out int salida))
                    {
                        Console.WriteLine("No ingreso un número.");
                        continue;
                    }

                    if (!int.TryParse(ingreso2, out int salida2))
                    {
                        Console.WriteLine("No ingreso un número.");
                        continue;
                    }


                    if (salida < salida2)
                    {
                        Console.WriteLine("El primer número debe ser mayor que el segundo.");
                    }
                    else
                    {
                        Console.WriteLine($"{salida} | {salida2}");
                        break;
                    }
           

            } while (true);

            Console.ReadKey();
        }

       

       
    
    }
}
