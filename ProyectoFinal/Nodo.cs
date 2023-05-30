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
        private Salon_de_Eventos Salon;
        private Husped value;
        private Nodo siguiente;
        private Nodo anterior;

        public Nodo(Husped value) {
            this.value = value;
            this.siguiente = null;
            this.anterior = null;
        }
        public Nodo(Salon_de_Eventos Salon)
        {
            this.Salon = Salon;
            this.siguiente = null;
            this.anterior = null;
        }
        public Husped getHuesped() { return this.value; }
        public void setHuesped(Husped value) {this.value = value; }
        public Husped getSalon_de_Eventos() { return this.value; }
        public void setSalon_de_Eventos(Salon_de_Eventos value) { this.Salon = Salon; }
        public Nodo getSiguiente() { return this.siguiente; }
        public void setSiguiente(Nodo siguiente) { this.siguiente = siguiente; }

        public Nodo getAnterior() { return this.anterior; }
        public void setAnterior(Nodo anterior) { this.anterior = anterior; }

    }
}
