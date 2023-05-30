using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class Lista
    {
        private String name;
        private Nodo cabeza;
        private Nodo cola;

        public Lista(string name)
        {
            this.name = name;
            this.cabeza = null;
            this.cola = null;
        }
        public String getNombre()
        {
            return this.name;
        }
        public Nodo getCola()
        {
            return this.cola;
        }
        public void setNombre(String name) { this.name = name; }

        public void setCabeza(Nodo cabeza) { this.cabeza = cabeza; }


        public void setCola(Nodo cola) { this.cabeza = cola; }

        public bool IsListEmpty()
        {
            return this.cabeza == null;
        }

        public void Insertar(Nodo nuevo)
        {
            if (IsListEmpty())
            {
                cabeza = nuevo;
                cola = nuevo;
                cabeza.setSiguiente(cabeza);
                cabeza.setAnterior(cola);
            }
            else
            {
                cola.setSiguiente(nuevo);
                nuevo.setAnterior(cola);
                nuevo.setSiguiente(cabeza);
                cola = nuevo;
                cabeza.setAnterior(cola);
            }
        }
        public void InsertarSalon(Nodo nuevo)
        {
            if (IsListEmpty())
            {
                cabeza = nuevo;
                cola = nuevo;
                cabeza.setSiguiente(cabeza);
                cabeza.setAnterior(cola);
            }
            else
            {
                cola.setSiguiente(nuevo);
                nuevo.setAnterior(cola);
                nuevo.setSiguiente(cabeza);
                cola = nuevo;
                cabeza.setAnterior(cola);
            }
        }
        public string mostrarLista()
        {
            String message = "";

            Nodo actual = this.cabeza;

            do
            {
                Husped huesped = actual.getHuesped();
                message += "Nombre Huesped:\t" + huesped.getNombre() + "\nCorreo electronico:\t" + huesped.getCorreo() + " \nNumero de telefono:\t" + huesped.getNumero() + "\n\n";
                actual = actual.getSiguiente();

            } while (actual != null && actual != cabeza);
            return message;
        }
        public string mostrarListaSalon()
        {
            String message = "";

            Nodo actual = this.cabeza;

            do
            {
                Husped huesped = actual.getHuesped();
                message += "Nombre Huesped:\t" + huesped.getNombre() + " \nNumero de telefono:\t" + huesped.getNumero() + "\n\n";
                actual = actual.getSiguiente();

            } while (actual != null && actual != cabeza);
            return message;
        }
        public bool Buscar(String buscarHues)
        {
            bool exists = false;
            Nodo actual = this.cabeza;
            do
            {
                Husped huesped = actual.getHuesped();
                if (huesped.getNombre() == buscarHues)
                {
                    exists = true;
                    break;
                }
                actual = actual.getSiguiente();
            } while (actual != null && actual != cabeza);

            return exists;
        }
        public bool BuscarSalon(String buscarHues)
        {
            bool exists = false;
            Nodo actual = this.cabeza;
            do
            {
                Husped huesped = actual.getHuesped();
                if (huesped.getNombre() == buscarHues)
                {
                    exists = true;
                    break;
                }
                actual = actual.getSiguiente();
            } while (actual != null && actual != cabeza);

            return exists;
        }
    }
}
