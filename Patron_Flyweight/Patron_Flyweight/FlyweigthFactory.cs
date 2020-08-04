using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Flyweight
{
    public class FlyweigthFactory
    {
        IVehiculo auto;

            //creamos un metodo para una lista de todos lo autos
        public void listarAutos(string[] color, string[] patentes, string[] duenios)
        {
            for (int i = 0; i < duenios.Length; i++)
            {
                auto = new Auto(color[i], patentes[i], duenios[i]);

                Console.WriteLine("Datos del auto\n" + auto.mostrarDetalle());
            }
        }
    }
}
