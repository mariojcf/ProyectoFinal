using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class Cliente
    {
        private String nombre;
        public void setName(String name)
        {
            this.nombre = name;
        }
        public String getName()
        {
            return this.nombre;
        }
    }
}
