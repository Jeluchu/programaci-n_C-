using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametrosValor2
{
    class Program
    {
        public int Mayor(int v1, int v2, int v3)
        {
            if (v1 >= v2 && v1 >= v3)
            {
                return v1;
            }
            else
            {
                if (v2 >= v3)
                {
                    return v2;
                }
                else
                {
                    return v3;
                }
            }
        }

        static void Main(string[] args)
        {
            int x1, x2, x3;

            Program p = new Program();

            Console.Write("Introduce el primer número: ");
            x1 = Int32.Parse(Console.ReadLine());

            Console.Write("Introduce el segundo número: ");
            x2 = Int32.Parse(Console.ReadLine());

            Console.Write("Introduce el tercer número: ");
            x3 = Int32.Parse(Console.ReadLine());

            Console.Write("\n");
            Console.Write("El número mayor es " + p.Mayor(x1, x2, x3));
            Console.ReadKey();

                       
        }
    }
}
