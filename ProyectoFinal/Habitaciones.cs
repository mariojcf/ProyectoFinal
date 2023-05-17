using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Habitaciones
    {
        private String tipodeHabitacion;
        private String Estado;
        public Habitaciones(String tipodeHabitaicon, String Estado) { 
            this.tipodeHabitacion = tipodeHabitaicon;
            this.Estado = Estado;
        }
        public String getTipodeHabitacion()
        {
            return tipodeHabitacion;
        }
        public String getEstado()
        {
            return Estado;
        }
        public String setTipodeHabitacion()
        {
            return tipodeHabitacion;
        }
        public String setEstado()
        {
            return Estado;
        }
    }
}
