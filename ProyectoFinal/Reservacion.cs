using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class Reservacion
    {
        private string nombre;
        private string numero;

        public Reservacion(string nombre, string numero) {
            this.nombre = nombre;
            this.numero = numero;
        }
        public string getNombre()
        {
            return this.nombre;
        }
        public string getNumero()
        {
            return this.numero;
        }
        public string setNombre()
        {
            return this.nombre;
        }
        public string setNumero()
        {
            return this.numero;
        }

       
    }
}
