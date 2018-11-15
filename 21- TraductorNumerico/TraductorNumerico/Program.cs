using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraductorNumerico
{
    class Program
    {
        public void Traduce(int numero)
        {
            if (numero == 1)
            {
                Console.Write("Uno");
            }
            else
            {
                if (numero == 2)
                {
                    Console.Write("Dos");
                }
                else
                {
                    if (numero == 3)
                    {
                        Console.Write("Tres");
                    }
                    else
                    {
                        if (numero == 4)
                        {
                            Console.Write("Cuatro");
                        }
                        else
                        {
                            if (numero == 5)
                            {
                                Console.Write("Cinco");
                            }
                            else
                            {
                                if (numero == 6)
                                {
                                    Console.Write("Seis");
                                }
                                else
                                {
                                    if (numero == 7)
                                    {
                                        Console.Write("Siete");
                                    }
                                    else
                                    {
                                        if (numero == 8)
                                        {
                                            Console.Write("Ocho");
                                        }
                                        else
                                        {
                                            if (numero == 9)
                                            {
                                                Console.Write("Nueve");
                                            }
                                            else
                                            {
                                                if (numero == 10)
                                                {
                                                    Console.Write("Diez");
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            int num;
            Program tradnum = new Program();

            Console.Write("Introduce un número del 1 al 10: ");
            num = Int32.Parse(Console.ReadLine());

            tradnum.Traduce(num);
        }
    }
}
