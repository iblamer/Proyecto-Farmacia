using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using BLL;

namespace ProyectoFinal.Consultas
{
    public partial class ConsultaMedicinas : Form
    {
        public ConsultaMedicinas()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void Filtrarbutton_Click(object sender, EventArgs e)
        {
            if(FiltrocomboBox.SelectedIndex == 0)
            {
                medicinasDataGridView.DataSource = MedicinasBLL.GetLista();
            }

            if(FiltrocomboBox.SelectedIndex == 1)
            {
                medicinasDataGridView.DataSource = MedicinasBLL.GetLista(Utilidades.StringToInt(FiltrotextBox.Text));
            }

            if(FiltrocomboBox.SelectedIndex == 2)
            {
                medicinasDataGridView.DataSource = MedicinasBLL.GetLista(FiltrotextBox.Text);
            }

            if(FiltrocomboBox.SelectedIndex == 3)
            {
                medicinasDataGridView.DataSource = MedicinasBLL.GetLista(DesdedateTimePicker.Value, HastadateTimePicker.Value);
            }

            if(FiltrocomboBox.SelectedIndex == 4)
            {
                medicinasDataGridView.DataSource = MedicinasBLL.GetListaLaboratorio(Utilidades.StringToInt(FiltrotextBox.Text));
            }

            if(FiltrocomboBox.SelectedIndex == 5)
            {
                medicinasDataGridView.DataSource = MedicinasBLL.GetListaCategoria(Utilidades.StringToInt(FiltrotextBox.Text));
            }

        }

        private void imprimirButton_Click(object sender, EventArgs e)
        {
            var rptMedicinas = new MedicinasReportViewer();

            rptMedicinas.Show();
        }
    }
}
