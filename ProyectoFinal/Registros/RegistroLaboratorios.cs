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

namespace ProyectoFinal.Registros
{
    public partial class RegistroLaboratorios : Form
    {
        public RegistroLaboratorios()
        {
            InitializeComponent();
        }

        private void RegistroLaboratorios_Load(object sender, EventArgs e)
        {
            FechaIngresotextBox.Text = DateTime.Now.ToString();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Laboratorios lab = new Laboratorios();
            if(Search())
            {
                Fill(LaboratoriosBLL.Buscar(Utilidades.StringToInt(laboratorioIdTextBox.Text)));
            }
        }

        private void Fill(Laboratorios lab)
        {
            nombreTextBox.Text = lab.Nombre;
            FechaIngresotextBox.Text = lab.FechaIngreso.ToString();
        }

        private bool Search()
        {
            if(LaboratoriosBLL.Buscar(Utilidades.StringToInt(laboratorioIdTextBox.Text)) == null)
            {
                MessageBox.Show("El id no existe");
                return false;
            }

            return true;
        }

        private void FechaIngresodateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            var lab = new Laboratorios();
            
            lab.FechaIngreso = DateTime.Now;
            lab.Nombre = nombreTextBox.Text;
            
            if(LaboratoriosBLL.Insertar(lab))
            {
                MessageBox.Show("Se guardo el laboratorio");
            }

            else
            {
                MessageBox.Show("Error al guardar");
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if(Search())
            {
                LaboratoriosBLL.Eliminar(Utilidades.StringToInt(laboratorioIdTextBox.Text));
                MessageBox.Show("Se elimino el laboratorio");
            }
            else
            {
                MessageBox.Show("Error al eliminar");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
