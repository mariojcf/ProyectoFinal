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
            Registrar registrar= new Registrar();
            registrar.Show();
        }
    }
}