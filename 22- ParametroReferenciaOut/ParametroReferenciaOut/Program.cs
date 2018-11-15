using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametroReferenciaOut
{
    class Program
    {
        /*
         * USAMOS UN PARAMETRO POR REFERENCIA DE TIPO OUT
         * CUANDO NO REQUIERE QUE LA VARIABLE QUE ENVIAMOS
         * ESTÉ INICIALIZADA
         */

        private int[] vec;
        int tamLeido;

        public Program()
        {
            Console.Write("Tamaño del vector: ");
            tamLeido = Int32.Parse(Console.ReadLine());
            vec = new int[tamLeido];
            Console.Write("\n");
        }

        public void Cargar()
        {
            for(var i = 0; i < vec.Length; i++)
            {
                Console.Write("Introduce el elemnto: ");
                vec[i] = Int32.Parse(Console.ReadLine());
            }
        }

        public void MayorMenor(out int may, out int men)
        {
            may = vec[0];
            men = vec[0];
            
            for(var i = 1; i < vec.Length; i++)
            {
                if(vec[i] > may)
                {
                    may = vec[i];
                }
                else
                {
                    if(vec[i] < men)
                    {
                        men = vec[i];
                    }
                }
            }           
        }

        static void Main(string[] args)
        {
            int ma, me;
            Program p = new Program();

            p.Cargar();
            p.MayorMenor(out ma, out me);

            Console.Write("\n");
            Console.Write("El mayor elemneto de los vectores es: " + ma + "\n");
            Console.Write("El menor elemneto de los vectores es: " + me);
            Console.ReadKey();
        }
    }
}
