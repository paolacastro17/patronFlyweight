using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Flyweight
{
    public class Auto : IVehiculo
    {
        public string color;
        public string patente;
        public string duenio;

        //Aqui creamos un constructor:
        public Auto(string color, string patente, string duenio)
        {
            this.color = color;
            this.patente = patente;
            this.duenio = duenio;
        }

        public string mostrarDetalle()
        {
            return "Patente:" + this.patente + ", Color:" + this.color + ", Duenio:" + this.duenio;
        }
    }
}
