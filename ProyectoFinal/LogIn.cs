using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rUsuarios = new Registros.RegistroUsuarios();

            rUsuarios.Show();
        }

        private void medicinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rMedicinas = new Registros.RegistroMedicinas();

            rMedicinas.Show();
        }

        private void laboratoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rLaboratorios = new Registros.RegistroLaboratorios();

            rLaboratorios.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rVentas = new Registros.RegistroVentas();

            rVentas.Show();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var cUsuarios = new Consultas.ConsultaUsuarios();

            cUsuarios.Show();
        }

        private void mediciansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cMedicinas = new Consultas.ConsultaMedicinas();
            cMedicinas.Show();
        }

        private void laboratoriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var cLaboratorios = new Consultas.ConsultaLaboratorios();
            cLaboratorios.Show();
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var cVentas = new Consultas.ConsultaVentas();
            cVentas.Show();
        }
    }
}
