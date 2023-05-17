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
    public partial class Salon_de_Eventos : Form
    {
        bool verificado;
        public Salon_de_Eventos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombreCompleto = txtNombreCompleto.Text;
            string telefono = txtTelefono.Text;
            MonthCalendar calendario = mtCIngreso;
            int numPersonas = (int)chkPersonas.Value;
            //Recordatorio 
            lblAnuncio.Text = "Horarios de uso de 8 a 12 hrs y de 14hrs a 18hrs.";
            lblAnuncio.Visible = true;
            verificado = true;
            // Validar que se hayan ingresado los valores requeridos
            if (string.IsNullOrWhiteSpace(nombreCompleto) || string.IsNullOrWhiteSpace(telefono))
            {
                MessageBox.Show("Por favor ingrese su nombre completo y número de teléfono.");
                return;
            }

            // Mostrar un mensaje de confirmación con los detalles del registro
            string mensaje = string.Format("¡Reserva exitosamente guardada!\n\nNombre completo: {0}\nTeléfono: {1}\nFecha de ingreso: {2}\nNúmero de personas: {3}",
                nombreCompleto, telefono, calendario.SelectionRange.Start.Date.ToShortDateString(), numPersonas);
            string mensaje2 = string.Format("");
            MessageBox.Show(mensaje);
        }
    }
}
