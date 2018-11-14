using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenacionSueldos
{
    class Program
    {
        private int[] sueldos;
        String lineaLeida;

        public void Cargar()
        {
            sueldos = new int[5];
            for (int i = 0; i < sueldos.Length; i++)
            {
                Console.Write("Introduce el sueldo: ");
                lineaLeida = Console.ReadLine();
                sueldos[i] = Int32.Parse(lineaLeida);
            }
        }

        public void Ordenar()
        {
            for(int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 4 - j; i++)
                {
                    if (sueldos[i] > sueldos[i + 1])
                    {
                        int operador;
                        operador = sueldos[i];
                        sueldos[i] = sueldos[i + 1];
                        sueldos[i + 1] = operador;
                    }
                }
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("\nEstos son los sueldos ordenados (menor a mayor)\n");
            for (int f = 0; f < sueldos.Length; f++)
            {
                Console.WriteLine(sueldos[f]);
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Program OrdenacionSueldos = new Program();
            OrdenacionSueldos.Cargar();
            OrdenacionSueldos.Ordenar();
            OrdenacionSueldos.Imprimir();
        }
    }
}
