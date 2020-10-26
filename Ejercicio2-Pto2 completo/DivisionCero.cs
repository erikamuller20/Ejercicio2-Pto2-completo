using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Pto2_completo
{
    class DivisionCero
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Introduzca el dividendo");
             int num1;
             num1 = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Introduzca el divisor");
             int num2;
             num2 = Convert.ToInt32(Console.ReadLine()); */

            int num1 = 0;
            bool esNum = false;
            while (!esNum) //Mientras esNum sea falso
            {
                Console.WriteLine("Introduzca el dividendo");
                esNum = int.TryParse(Console.ReadLine(), out num1);
                if (!esNum)
                {
                    Console.WriteLine($"Seguro Ingreso una letra o no ingreso nada! {Environment.NewLine}");
                }
            }

            int num2 = 0;
            bool esNum2 = false;
            while (!esNum2) //Mientras esNum sea falso
            {
                Console.WriteLine("Introduzca el divisor");
                esNum2 = int.TryParse(Console.ReadLine(), out num2);
                if (!esNum2)
                {
                    Console.WriteLine($"Seguro Ingreso una letra o no ingreso nada! {Environment.NewLine}");
                }
            }

            try
             {
                 int division = num1 / num2;
                 Console.WriteLine($"La division es { division }");
             }
             catch (DivideByZeroException ex)
             {
                 Console.WriteLine("Solo Chuck Norris divide por cero!");
                 Console.WriteLine($"Mensaje de error: {ex.Message} ");
             }
             catch (Exception ex)
             {
                 Console.WriteLine($"Ocurrio un error: {ex.Message}");
             }
             finally
             {
                 Console.WriteLine("Proceso finalizado");
             }

             Console.ReadKey(); 

        }
    }
}
