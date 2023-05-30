using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Registrar : Form
    {
        private const decimal CostoSimple = 12;
        private const decimal CostoDoble = 20;
        bool verificado;
        public Registrar()
        {
            InitializeComponent();
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Obtener los valores ingresados por el usuario
            string nombreCompleto = txtNombreCompleto.Text;
            string telefono = txtTelefono.Text;
            string Correo = txtCorreo.Text;
            DateTime fechaIngreso = dtFechaIngreso.Value;
            DateTime fechaSalida = dtFechaSalida.Value;
            int numPersonas = (int)chkAdultos.Value;
            int tieneNinos = (int)chkNinos.Value;
            
            // Calcular la cantidad de noches que se van a hospedar
            DateTime total = dtFechaIngreso.Value;
            int noches = (int)chkAdultos.Value;
            noches = noches + 1;
            // Calcular el costo total
            decimal costoTotal = 0;

            if (noches < 7)
            {
                // Habitación simple
                costoTotal = noches * CostoSimple;
            }
            else if (noches > 8)
            {
                // Habitación doble
                costoTotal = noches * CostoDoble;
            }
            else
            {
                // No se seleccionó ninguna opción
                MessageBox.Show("Por favor, seleccione el tipo de habitación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mostrar el costo total en un MessageBox
            MessageBox.Show($"El costo total de {noches} noches de hospedaje es: USD {costoTotal}", "Costo de Hospedaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Recordatorio 
            lblRecordatorio.Text = "El check-in para las habitaciones es a las 15hrs y el check-out es a las 13hrs.";
            lblRecordatorio.Visible = true;
            verificado = true;

            // Validar que se hayan ingresado los valores requeridos
            if (string.IsNullOrWhiteSpace(nombreCompleto) || string.IsNullOrWhiteSpace(telefono))
            {
                MessageBox.Show("Por favor ingrese su nombre completo y número de teléfono.");
                return;
            }

            /* Huesped nuevoHuesped = new Huesped(txtNombreCompleto.Text, txtEmail.Text, txtTelefono.Text);

             Nodo nuevoNodo = new Nodo(nuevoHuesped);

             Form1.instance.getListaHuespedes().insertar(nuevoNodo);*/

            // Mostrar un mensaje de confirmación con los detalles del registro
            string mensaje = string.Format("¡Huesped registrado exitosamente!\n\nNombre completo: {0}\nTeléfono:{1}\nCorreo:  {2}\nFecha de ingreso: {3}\nFecha de salida: {4}\nNúmero de personas: {5}\n¿Tiene niños? {6}",
                nombreCompleto, telefono, Correo, fechaIngreso.ToString("dd/MM/yyyy"), fechaSalida.ToString("dd/MM/yyyy"), numPersonas + tieneNinos, tieneNinos > 0 ? "Sí" : "No");
            string mensaje2 = string.Format("");
            MessageBox.Show(mensaje);

        }

        private void chkAdultos_ValueChanged(object sender, EventArgs e)
        {
            int personas = decimal.ToInt32(chkAdultos.Value);
            int mod = personas % 4;

            int habitacion;
            if (mod == 0)
            {
                habitacion = personas / 4;
                MessageBox.Show("Puede reservar " + habitacion.ToString() + " habitaciones dobles para " + personas.ToString() + " personas");
            }
            else if (personas / 4 < 0)
            {
                if (personas == 3)
                {
                    MessageBox.Show("Puede reservar 2 habitaciones simples o 1 habitación doble para " + personas.ToString() + " personas");
                }
                else
                {
                    MessageBox.Show("Puede reservar 1 habitación simple para " + personas.ToString() + "  personas");
                }
            }
            else
            {
                habitacion = (personas - mod) / 4;
                if (mod == 3)
                {
                    MessageBox.Show("Puede reservar " + habitacion.ToString() + " habitaciones dobles y 2 simples para " + personas.ToString() + "  personas");
                }
                else
                {
                    MessageBox.Show("Puede reservar " + habitacion.ToString() + " habitaciones dobles y 1 simple para " + personas.ToString() + "  personas");
                }
            }
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            string correoElectronico = txtCorreo.Text;

            // Patrón de expresión regular para validar el correo electrónico
            string patron = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";

            if (Regex.IsMatch(correoElectronico, patron))
            {
                MessageBox.Show("El correo electrónico es válido.", "Validación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El correo electrónico no es válido.", "Validación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            string telefono = txtTelefono.Text;

            if (telefono.Length != 8)
            {
                MessageBox.Show("El número de teléfono debe tener 8 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("El número de teléfono es válido.", "Validación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}
