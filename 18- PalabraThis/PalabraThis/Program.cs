using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalabraThis
{
    class Program
    {
        private String nombre;
        private int edad;

        public Program(String nombr, int edd)
        {
            this.nombre = nombr;
            this.edad = edd;
            this.Imprimir();
        }

        public void Imprimir()
        {
            Console.Write("Nombre: " + this.nombre + "\n");
            Console.Write("Edad: " + this.edad + "\n");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Program personal = new Program("Jelu", 19);
        }
    }
}
