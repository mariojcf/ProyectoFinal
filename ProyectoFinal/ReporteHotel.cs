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
    public partial class ReporteHotel : Form
    {
        public ReporteHotel()
        {
            InitializeComponent();
           
        }

        private void VerReporte_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            string ojomensaje = "";
            mensaje += Form1.instance.listaHuesped.mostrarLista();
            ojomensaje += Form1.instance.listaSalon.mostrarListaSalon();
            MessageBox.Show(mensaje);
            MessageBox.Show(ojomensaje);
        }
    }
}
