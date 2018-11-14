using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardaSueldos
{
    class Program
    {
        private int[] sueldos;
        String lineaLeida;

        public void Cargar()
        {
            sueldos = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Introduce el valor del sueldo: ");
                lineaLeida = Console.ReadLine();
                sueldos[i] = Int32.Parse(lineaLeida);
            }
            Console.Write("\n\n");
        }

        public void Imprimir()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(sueldos[i]);
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Program sueldo1 = new Program();
            sueldo1.Cargar();
            sueldo1.Imprimir();
        }
    }
}
