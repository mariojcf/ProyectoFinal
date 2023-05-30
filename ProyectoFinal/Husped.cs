using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class Husped
    {
        private String nombre;
        private String correo;
        private String numero; 

        public Husped(String nombre, String correo, string numero)
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
        public String getNumero()
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
        public String SetNumero()
        {
            return numero;
        }
    }
}
