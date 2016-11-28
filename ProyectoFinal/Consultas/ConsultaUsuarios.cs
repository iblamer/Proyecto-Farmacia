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
using DAL;

namespace ProyectoFinal.Consultas
{
    public partial class ConsultaUsuarios : Form
    {
        public ConsultaUsuarios()
        {
            InitializeComponent();
        }



        private void filtrarButton_Click(object sender, EventArgs e)
        {
            if(FiltrocomboBox.SelectedIndex == 0)
            {
                UsuariosdataGridView.DataSource = UsuariosBLL.GetLista();
            }

            if(FiltrocomboBox.SelectedIndex == 1)
            {
                UsuariosdataGridView.DataSource = UsuariosBLL.GetLista(Utilidades.StringToInt(FiltrotextBox.Text));
            }

            if(FiltrocomboBox.SelectedIndex == 2)
            {
                UsuariosdataGridView.DataSource = UsuariosBLL.GetLista(FiltrotextBox.Text);
            }

            if (FiltrocomboBox.SelectedIndex == 3)
            {
                UsuariosdataGridView.DataSource = UsuariosBLL.GetLista(DesdedateTimePicker.Value, HastadateTimePicker.Value);
            }

            if(FiltrocomboBox.SelectedIndex == 4)
            {
                UsuariosdataGridView.DataSource = UsuariosBLL.GetListaTelefono(FiltrotextBox.Text);
            }

            if(FiltrocomboBox.SelectedIndex == 5)
            {
                UsuariosdataGridView.DataSource = UsuariosBLL.GetListaTipo(Utilidades.StringToInt(FiltrotextBox.Text));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuariosReportViewer rptUsuarios = new UsuariosReportViewer();

            rptUsuarios.Show();
        }

        private void UsuariosdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private bool ValidarFiltro()
        {
            if (FiltrocomboBox.SelectedIndex != 0 && string.IsNullOrEmpty(FiltrotextBox.Text))
            {
                FiltroErrorProvider.SetError(FiltrotextBox, "Por favor llene los campos requeridos");
                return false;
            }
            else
            {
            return true;
            }
        }
    }
}
