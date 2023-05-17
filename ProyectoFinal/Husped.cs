using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Husped
    {
        private String nombre;
        private String correo;
        private int numero; 

        public Husped(String nombre, String correo, int numero)
        {
            this.nombre = nombre;
            this.correo = correo;
            this.numero = numero;
        }

        public String getNombre()
        {
            return nombre;
        }
        public String getCorreo()
        {
            return correo;
        }
        public int getNumero()
        {
            return numero;
        }
        public String setNombre()
        {
           return nombre;
        }
        public String setCorreo()
        {
            return correo;
        }
        public int SetNumero()
        {
            return numero;
        }
    }
}
