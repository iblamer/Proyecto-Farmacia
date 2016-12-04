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
    public partial class ConsultaVentas : Form
    {
        public ConsultaVentas()
        {
            InitializeComponent();
        }

        private void ConsultaVentas_Load(object sender, EventArgs e)
        {

        }


        private void Filtrarbutton_Click(object sender, EventArgs e)
        {
            if(filtroComboBox.SelectedIndex == 0)
            {
                VentasdataGridView.DataSource = VentasBLL.GetLista();
            }
            if (ValidarFiltrar())
            {

                if (filtroComboBox.SelectedIndex == 1)
                {
                    VentasdataGridView.DataSource = VentasBLL.GetLista(DesdeDateTimePicker.Value, HastadateTimePicker.Value);
                }
                if (filtroComboBox.SelectedIndex == 2)
                {
                    VentasdataGridView.DataSource = VentasBLL.GetListaTipo(Utilidades.StringToInt(filtroTextBox.Text));
                }
                if (filtroComboBox.SelectedIndex == 3)
                {
                    VentasdataGridView.DataSource = VentasBLL.GetLista(Utilidades.StringToInt(filtroTextBox.Text));
                }

                if(filtroComboBox.SelectedIndex == 4)

                {
                    VentasdataGridView.DataSource = VentasBLL.GetListaDetalle(Utilidades.StringToInt(filtroComboBox.Text));
                }
            }
        }

        private void ValidarFiltro()
        {

        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            var rptVentas = new VentasReportViewer();
            rptVentas.Show();
        }

        private bool ValidarFiltrar()
        {
            if(filtroComboBox.SelectedIndex == 0 && string.IsNullOrEmpty(filtroTextBox.Text))
            {
                FiltroerrorProvider.SetError(filtroTextBox, "Por favor llenar los campos requeridos");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
