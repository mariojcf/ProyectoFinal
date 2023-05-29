using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Registrar : Form
    {
        
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
            DateTime fechaIngreso = dtFechaIngreso.Value;
            DateTime fechaSalida = dtFechaSalida.Value;
            int numPersonas = (int)chkAdultos.Value;
            int tieneNinos = (int)chkNinos.Value;
            // Calcular la cantidad de noches que se van a hospedar
            int noches = (int)(fechaSalida - fechaIngreso).TotalDays;
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
            string mensaje = string.Format("¡Huesped registrado exitosamente!\n\nNombre completo: {0}\nTeléfono: {1}\nFecha de ingreso: {2}\nFecha de salida: {3}\nNúmero de personas: {4}\n¿Tiene niños? {5}",
                nombreCompleto, telefono, fechaIngreso.ToString("dd/MM/yyyy"), fechaSalida.ToString("dd/MM/yyyy"), numPersonas + tieneNinos, tieneNinos >0 ?"Sí" : "No");
            string mensaje2 = string.Format("");
            MessageBox.Show(mensaje);

        }

        private void chkAdultos_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
