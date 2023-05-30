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
    public partial class Intento : Form
    {
        public Intento()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ColumnCount = 7; // 7 columnas para los días de la semana
            dataGridView1.RowCount = 6; // 6 filas para las semanas

            // Agregar los encabezados de los días de la semana
            dataGridView1.Columns[0].HeaderText = "Domingo";
            dataGridView1.Columns[1].HeaderText = "Lunes";
            dataGridView1.Columns[2].HeaderText = "Martes";
            dataGridView1.Columns[3].HeaderText = "Miércoles";
            dataGridView1.Columns[4].HeaderText = "Jueves";
            dataGridView1.Columns[5].HeaderText = "Viernes";
            dataGridView1.Columns[6].HeaderText = "Sábado";

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtener la fecha seleccionada
            DateTime fechaSeleccionada = DateTime.Today
                .AddDays(e.ColumnIndex - (int)DateTime.Today.DayOfWeek)
                .AddWeeks(e.RowIndex);

            // Mostrar la fecha seleccionada en una etiqueta o control similar
            labelFechaSeleccionada.Text = fechaSeleccionada.ToString("dd/MM/yyyy");

            // Aquí puedes implementar la lógica para realizar la reserva
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Obtener la fecha correspondiente a la celda
            DateTime fechaCelda = DateTime.Today
                .AddDays(e.ColumnIndex - (int)DateTime.Today.DayOfWeek)
                .AddWeeks(e.RowIndex);

            // Ejemplo: Cambiar el fondo de la celda para la fecha actual
            if (fechaCelda.Date == DateTime.Today.Date)
            {
                e.CellStyle.BackColor = Color.Yellow;
            }

        }
    }
}
