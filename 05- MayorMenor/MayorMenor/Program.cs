using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayorMenor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            String lineaLeida;

            Console.Write("Introduce el primer número: ");
            lineaLeida = Console.ReadLine();
            numero1 = int.Parse(lineaLeida);

            Console.Write("Introduce el segundo número: ");
            lineaLeida = Console.ReadLine();
            numero2 = int.Parse(lineaLeida);
            Console.Write("\n");

            if (numero1 > numero2)
            {
                Console.WriteLine("El número mayor es: " + numero1);
            }
            else
            {
                Console.WriteLine("El numero mayor es: " + numero2);
            }
            Console.ReadKey();
        }
    }
}
