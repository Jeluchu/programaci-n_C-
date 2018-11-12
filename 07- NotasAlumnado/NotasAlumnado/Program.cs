using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasAlumnado
{
    class Program
    {
        static void Main(string[] args)
        {
            int puntuacion;
            String lineaLeida;

            Console.Write("Introduce tu nota del examen: ");
            lineaLeida = Console.ReadLine();
            puntuacion = int.Parse(lineaLeida);

            if (puntuacion < 5)
            {
                Console.Write("Estás suspenso");
            }
            else
            {
                Console.Write("Has aprobado el examen. ¡Enhorabuena!");
            }
            Console.ReadKey();
        }
    }
}
