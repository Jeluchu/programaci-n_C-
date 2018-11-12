using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperficieCuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            String lineaLeida;
            int lado;
            int resultado;

            Console.Write("Introduce el tamaño del lado: ");
            lineaLeida = Console.ReadLine();
            
            lado = int.Parse(lineaLeida);

            resultado = lado * lado;

            Console.Write("La superficie del cuadrado es de: " + resultado);

            // ESPERA SALTO DE LÍNEA
            Console.ReadKey();



        }
    }
}
