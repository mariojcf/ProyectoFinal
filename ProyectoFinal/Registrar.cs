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

            // Validar que se hayan ingresado los valores requeridos
            if (string.IsNullOrWhiteSpace(nombreCompleto) || string.IsNullOrWhiteSpace(telefono))
            {
                MessageBox.Show("Por favor ingrese su nombre completo y número de teléfono.");
                return;
            }

            // Mostrar un mensaje de confirmación con los detalles del registro
            string mensaje = string.Format("¡Huesped registrado exitosamente!\n\nNombre completo: {0}\nTeléfono: {1}\nFecha de ingreso: {2}\nFecha de salida: {3}\nNúmero de personas: {4}\n¿Tiene niños? {5}",
                nombreCompleto, telefono, fechaIngreso.ToString("dd/MM/yyyy"), fechaSalida.ToString("dd/MM/yyyy"), numPersonas + tieneNinos, tieneNinos >0 ?"Sí" : "No");
            MessageBox.Show(mensaje);
        }
    }
}
