using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreparacionExamenExtraAD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void modificarEspecialitatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormulariModificarEspecialitatConnectat form = new FormulariModificarEspecialitatConnectat();
            form.Show();
        }

        private void modificarEspecialitatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormulariModificarEspecialitatsDesconnectat form = new FormulariModificarEspecialitatsDesconnectat();
            form.Show();
        }
    }
}
