using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaProductosNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int resultadoSuma;
            int resultadoMulti;
            String lineaLeida;

            Console.Write("Introduce el primer número: ");
            lineaLeida = Console.ReadLine();
            numero1 = int.Parse(lineaLeida);

            Console.Write("Introduce el segundo número: ");
            lineaLeida = Console.ReadLine();
            numero2 = int.Parse(lineaLeida);

            resultadoSuma = numero1 + numero2;
            resultadoMulti = numero1 * numero2;

            Console.Write("\n\n");
            Console.Write("El resultado de la suma es: " + resultadoSuma + "\n");
            Console.Write("El resultado de la multiplicación es: " + resultadoMulti);
            Console.ReadKey();
        }
    }
}
