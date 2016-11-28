using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using BLL;
using Entidades;
using System.Windows.Forms;

namespace ProyectoFinal.Consultas
{
    public partial class ConsultaLaboratorios : Form
    {
        public ConsultaLaboratorios()
        {
            InitializeComponent();
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            if(FiltrocomboBox.SelectedIndex == 0)
            {
                LaboratoriosdataGridView.DataSource = LaboratoriosBLL.GetLista();
            }

            if(FiltrocomboBox.SelectedIndex == 1)
            {
                LaboratoriosdataGridView.DataSource = LaboratoriosBLL.GetLista(Utilidades.StringToInt(FiltrotextBox.Text));
            }

            if(FiltrocomboBox.SelectedIndex == 2)
            {
                LaboratoriosdataGridView.DataSource = LaboratoriosBLL.GetLista(FiltrotextBox.Text);
            }

            if(FiltrocomboBox.SelectedIndex == 3)
            {
                LaboratoriosdataGridView.DataSource = LaboratoriosBLL.GetLista(DesdedateTimePicker.Value, HastadateTimePicker.Value);
            }
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            var rptLaboratorios = new LaboratoriosReportViewer();

            rptLaboratorios.Show();
        }
    }
}
