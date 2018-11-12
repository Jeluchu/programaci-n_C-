using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperativosNumerales
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            String lineaLeida;
            int resSuma;
            int resResta;
            int resMulti;
            int resDiv;

            Console.Write("Introduce el primer númro: ");
            lineaLeida = Console.ReadLine();
            numero1 = int.Parse(lineaLeida);

            Console.Write("Introduce el segundo número: ");
            lineaLeida = Console.ReadLine();
            numero2 = int.Parse(lineaLeida);
            Console.Write("\n");

            if (numero1 > numero2)
            {
                resSuma = numero1 + numero2;
                resResta = numero1 - numero2;

                Console.Write("El resultado de la suma es: " + resSuma + "\n");
                Console.Write("El resultado de la resta es: " + resResta);

            }
            else
            {
                resMulti = numero2 * numero1;
                resDiv = numero2 / numero1;

                Console.Write("El resultado de la multiplicación es: " + resMulti + "\n");
                Console.Write("El resultado de la división es: " + resDiv);
            }
            Console.ReadKey();
        }
    }
}
