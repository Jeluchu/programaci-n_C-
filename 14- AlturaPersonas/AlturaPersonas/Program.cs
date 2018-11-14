using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlturaPersonas
{
    class Program
    {
        private float[] alturas;
        private float promedio;
        String lineaLeida;

        public void Cargar()
        {
            alturas = new float[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Introduce la altura de la persona: ");
                lineaLeida = Console.ReadLine();
                alturas[i] = float.Parse(lineaLeida);
            }
        }

        public void CalcularPromedio()
        {
            float suma = 0;
           
            for (int i = 0; i < 5; i++)
            {
                suma += alturas[i];
            }

            promedio = suma / 5;
            Console.Write("\n\n");
            Console.Write("El promedio de las alturas es: " + promedio);
        }

        public void MayoresMenores()
        {
            int mayor = 0, menor = 0;

            for (int i = 0; i < 5; i++)
            {
                if (alturas[i] > promedio)
                {
                    mayor++;
                }
                else
                {
                    if(alturas[i] < promedio)
                    {
                        menor++;
                    }
                }
            }

            Console.Write("\n");
            Console.Write("Cantidad de personas mayores (promedio): " + mayor + "\n");
            Console.Write("Cantidad de personas menores (promedio): " + menor + "\n");
            Console.ReadKey();

        }

        static void Main(string[] args)
        {
            Program alturaPersonas = new Program();
            alturaPersonas.Cargar();
            alturaPersonas.CalcularPromedio();
            alturaPersonas.MayoresMenores();
        }
    }
}
