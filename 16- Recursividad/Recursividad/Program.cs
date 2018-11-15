using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividad
{
    class Program
    {
        /*
         * FUNCIÓN REPETIR ES RECURSIVA
         * AL EJECUTAR SE BLOQUEARÁ Y EMITIRÁ UN ERROR
         */ 

        void Repetir()
        {
            Repetir();
        }

        static void Main(string[] args)
        {
            Program re = new Program();
            re.Repetir();
        }
    }
}
