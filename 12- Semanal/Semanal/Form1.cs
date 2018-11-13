using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semanal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dia.Text = "Lunes";
        }

        private void martes_Click(object sender, EventArgs e)
        {
            dia.Text = "Martes";
        }

        private void miercoles_Click(object sender, EventArgs e)
        {
            dia.Text = "Miércoles";
        }

        private void jueves_Click(object sender, EventArgs e)
        {
            dia.Text = "Jueves";
        }

        private void viernes_Click(object sender, EventArgs e)
        {
            dia.Text = "Viernes";
        }

        private void sabado_Click(object sender, EventArgs e)
        {
            dia.Text = "Sábado";
        }

        private void domingo_Click(object sender, EventArgs e)
        {
            dia.Text = "Domingo";
        }
    }
}
