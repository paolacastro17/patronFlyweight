using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            FlyweigthFactory patron = new FlyweigthFactory();

            string[] patentes = { "ARG123", "CHL789", "PER456" };
            string[] colores = { "Negro", "Azul", "Rojo" };
            string[] duenios = { "Carlos", "Pedro", "Juan" };

            patron.listarAutos(colores, patentes, duenios);

            Console.ReadKey();
        }
    }
}

