using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaSueldo
{
    class Program
    {
        static void Main(string[] args)
        {
            // DECLARACIÓN
            int horasTrabajadas;
            float precioHora;
            float sueldo;
            string linea;
            string e = Encoding.Default.GetString(new byte[] { 128 });

            // ESCRIBIR Y LEER
            Console.Write("Introduce las horas trabajadas: ");
            linea = Console.ReadLine();

            // CONVERTIR CADENA EN NÚMERO
            horasTrabajadas = int.Parse(linea);

            Console.Write("Introduce el precio por hora: ");
            linea = Console.ReadLine();

            precioHora = float.Parse(linea);
            sueldo = horasTrabajadas * precioHora;
            
            Console.Write("El sueldo total que ganarás es de: ");

            // CODIFICANDO LOS EL STRING 'e'
            Console.OutputEncoding = Encoding.Default;

            Console.Write(sueldo + e);
            Console.ReadKey();
        }
    }
}
