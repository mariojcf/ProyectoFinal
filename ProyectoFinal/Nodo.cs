using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProyectoFinal
{
    public class Nodo
    {
        private Reservacion Salon;
        private Husped value;
        private Nodo siguiente;
        private Nodo anterior;

        public Nodo(Husped value) {
            this.value = value;
            this.siguiente = null;
            this.anterior = null;
        }
        public Nodo(Reservacion Salon)
        {
            this.Salon = Salon;
            this.siguiente = null;
            this.anterior = null;
        }
        public Husped getHuesped() { return this.value; }
        public void setHuesped(Husped value) {this.value = value; }
        public Reservacion getReservacion() { return this.Salon; }
        public void setReservacion(Reservacion value) { this.Salon = Salon; }
        public Nodo getSiguiente() { return this.siguiente; }
        public void setSiguiente(Nodo siguiente) { this.siguiente = siguiente; }
        public Nodo getAnterior() { return this.anterior; }
        public void setAnterior(Nodo anterior) { this.anterior = anterior; }

    }
}
