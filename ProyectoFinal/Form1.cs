using System;
using System.Windows.Forms;
namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RegistrarHuesped_Click(object sender, EventArgs e)
        {
            Registrar registrar = new Registrar();
            registrar.Show();
        }

        private void verReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteHotel reporte = new ReporteHotel();
            reporte.Show();
        }

        private void habitacionSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salon_de_Eventos salon = new Salon_de_Eventos();
            salon.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String message = "¿Está seguro que desea salir?";
            String title = "Cerrar aplcación";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;

            DialogResult result = MessageBox.Show(message, title, buttons, icon);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}