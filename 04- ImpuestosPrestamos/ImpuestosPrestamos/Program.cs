using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpuestosPrestamos
{
    class Program
    {
        static void Main(string[] args)
        {
            int sueldo;
            String lineaLeida;

            Console.Write("Introduce el sueldo mensual: ");
            lineaLeida = Console.ReadLine();
            sueldo = int.Parse(lineaLeida);
            Console.Write("\n");

            if (sueldo > 3000)
            {
                Console.Write("Deberás pagar impuestos");
            }
            else
            {
                Console.Write("No tienes que pagar impuestos");
            }
                        
            Console.ReadKey();
        }
    }
}
