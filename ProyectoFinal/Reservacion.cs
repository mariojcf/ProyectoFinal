using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Reservacion
    {
        private int FechadeInicio;
        private int FechadeSalida;
        private int CantidadPersonas;
        private int CantidadHabitaciones;

        public Reservacion(int CantidadPersonas, int CantidadHabitaciones, int FechadeInicio, int FechadeSalida) { 
            this.CantidadHabitaciones = CantidadHabitaciones;
            this.CantidadPersonas = CantidadPersonas;
            this.FechadeInicio = FechadeInicio;
            this.FechadeSalida = FechadeSalida;
        }
        public int getFechadeInicio()
        {
            return this.FechadeInicio;
        }
        public int getFechadeSalida()
        {
            return this.FechadeSalida;
        }
        public int setFechadeInicio()
        {
            return this.CantidadPersonas;
        }
        public int setFechadeSalida()
        {
            return this.FechadeSalida;
        }

        public int getCantidadPersonas()
        {
            return this.CantidadPersonas;
        }
        public int getCantidadHabitaciones()
        {
            return CantidadHabitaciones;
        }
        public int setCantidadPersonas()
        {
            return this.CantidadPersonas;
        }
        public int setCantidadHabitaciones()
        {
            return this.CantidadHabitaciones;
        }
    }
}
