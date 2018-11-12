using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorModo1
{
    class Operarios
    {
        private int[] sueldos;
        String lineaLeida;
        int contador;

        // CONSTRUCTOR
        public Operarios()
        {
            // CANTIDAD DE ESPACIO EN SUELDOS
            sueldos = new int[5];
                        
            for (int i = 0; i < sueldos.Length; i++)
            {
                contador = i + 1;
                Console.Write("Ingrese el sueldo " + contador + ": ");
                lineaLeida = Console.ReadLine();
                sueldos[i] = int.Parse(lineaLeida);
            }
        }

        public void Imprimir()
        {
            // RECORREMOS SUELDOS
            for (int i = 0; i < sueldos.Length; i++)
            {
                Console.WriteLine(sueldos[i]);
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            // CREACIÓN DEL OBJETO
            Operarios op = new Operarios();

            Console.Write("\n");

            // EL OBJETO LLAMA AL MÉTODO
            op.Imprimir();
        }
    }
}
