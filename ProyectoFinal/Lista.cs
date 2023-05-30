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
                Reservacion Salon = actual.getReservacion();
                message += "Nombre de :\t" + Salon.getNombre() + " \nNumero de telefono:\t" + Salon.getNumero() + "\n\n";
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
        public bool BuscarSalon(String buscarSalon)
        {
            bool exists = false;
            Nodo actual = this.cabeza;
            do
            {
                Reservacion salon = actual.getReservacion();
                if (salon.getNombre() == buscarSalon)
                {
                    exists = true;
                    break;
                }
                actual = actual.getSiguiente();
            } while (actual != null && actual != cabeza);

            return exists;
        }
        public void eliminar(String EliminarHuesped)
        {
            String message = "";
            Nodo actual = this.cabeza;
            Nodo anterior = null;
            bool encontrado = false;
            if (actual != null)
            {
                do
                {
                    Husped huesped = actual.getHuesped();
                    if (huesped.getNombre() == EliminarHuesped)
                    {
                        if (actual == cabeza)
                        {
                            cabeza = cabeza.getSiguiente();
                            cabeza.setSiguiente(cola);
                            cola.setSiguiente(cabeza);
                        }
                        else if (actual == cola)
                        {
                            cola = anterior;
                            anterior.setSiguiente(cabeza);
                            cabeza.setAnterior(cola);
                        }
                        else
                        {
                            //anterior.setSiguiente(anterior) = actual.getSiguiente();
                            actual.getSiguiente().setSiguiente(anterior);
                        }
                        Console.WriteLine("\n Huesped eliminado con exito\n");
                        encontrado = true;
                    }
                    anterior = actual;
                    actual = actual.getSiguiente();
                } while (actual != cabeza && encontrado != true);
                if (!encontrado)
                {
                    Console.WriteLine("\n Huesped No encontrado");
                }
            }
            else
            {
                Console.WriteLine("\n La lista se encuentra vacía");
            }
        }
        public void eliminarSalon(String Eliminar)
        {
            String message = "";
            Nodo actual = this.cabeza;
            Nodo anterior = null;
            bool encontrado = false;
            if (actual != null)
            {
                do
                {
                    Reservacion reservacion = actual.getReservacion();
                    if (reservacion.getNombre() == Eliminar)
                    {
                        if (actual == cabeza)
                        {
                            cabeza = cabeza.getSiguiente();
                            cabeza.setSiguiente(cola);
                            cola.setSiguiente(cabeza);
                        }
                        else if (actual == cola)
                        {
                            cola = anterior;
                            anterior.setSiguiente(cabeza);
                            cabeza.setAnterior(cola);
                        }
                        else
                        {
                            //anterior.setSiguiente(anterior) = actual.getSiguiente();
                            actual.getSiguiente().setSiguiente(anterior);
                        }
                        Console.WriteLine("\n Evento eliminado con exito\n");
                        encontrado = true;
                    }
                    anterior = actual;
                    actual = actual.getSiguiente();
                } while (actual != cabeza && encontrado != true);
                if (!encontrado)
                {
                    Console.WriteLine("\n Evento No encontrado.");
                }
            }
            else
            {
                Console.WriteLine("\n No se encuentra registrado ningun evento.");
            }
        }
    }
}
