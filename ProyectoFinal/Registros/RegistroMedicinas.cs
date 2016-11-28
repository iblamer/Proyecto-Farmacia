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

namespace ProyectoFinal.Registros
{
    public partial class RegistroMedicinas : Form
    {
        public RegistroMedicinas()
        {
            InitializeComponent();
        }



        private void RegistroMedicinas_Load(object sender, EventArgs e)
        {
            LlenaCombo();
            OtrostextBox.Visible = false;
            otroslbl.Visible = false;
        }

        

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Medicinas medicina = new Medicinas();
            LlenarClases(medicina);

            if(MedicinasBLL.Insertar(medicina))
            {
                MessageBox.Show("Se inserto la medician");
                Limpiar();
            }
            else
            {
                MessageBox.Show("Error al insertar la medicina");
            }
        }

        private bool Search()
        {
            if(MedicinasBLL.Buscar(Utilidades.StringToInt(medicinaIdTextBox.Text)) == null)
            {
                MessageBox.Show("El id no existe");
                return false;
            }

            return true;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if(Search())
            {
                Fill(MedicinasBLL.Buscar(Utilidades.StringToInt(medicinaIdTextBox.Text)));
            }
        }

        private void LlenarClases(Medicinas medicina)
        {
            medicina.Nombre = nombreTextBox.Text;
            medicina.PrecioCompra = double.Parse(precioCompraTextBox.Text);
            medicina.PrecioVenta = double.Parse(precioVentaTextBox.Text);
            medicina.CantidadExistencia = int.Parse(precioVentaTextBox.Text);
            medicina.FechaVencimiento = fechaVencimientoDateTimePicker.Value;
            medicina.Descripcion = DescripcionrichTextBox.Text;
            medicina.Especificaciones = EspecificacionesrichTextBox.Text;
            medicina.LaboratorioId = Convert.ToInt16(LaboratoriocomboBox.SelectedValue);
        }

        private void Fill(Medicinas medicina)
        {
            nombreTextBox.Text = medicina.Nombre;
            DescripcionrichTextBox.Text = medicina.Descripcion;
            precioCompraTextBox.Text = medicina.PrecioCompra.ToString();
            precioVentaTextBox.Text = medicina.PrecioVenta.ToString();
            cantidadExistenciaTextBox.Text = medicina.CantidadExistencia.ToString();
            fechaVencimientoDateTimePicker.Value = medicina.FechaVencimiento;
            EspecificacionesrichTextBox.Text = medicina.Especificaciones;
            LaboratoriocomboBox.SelectedValue = medicina.LaboratorioId;
            categoriaComboBox.SelectedItem = medicina.CategoriaId;
        }

        private void Limpiar()
        {
            DateTimePicker dp = new DateTimePicker();
            nombreTextBox.Text = " ";
            DescripcionrichTextBox.Text = " ";
            precioCompraTextBox.Text = " ";
            precioVentaTextBox.Text = " ";
            cantidadExistenciaTextBox.Text = " ";
            fechaVencimientoDateTimePicker.Value = dp.Value;
            EspecificacionesrichTextBox.Text = " ";
            LaboratoriocomboBox.SelectedIndex = 0;
            categoriaComboBox.SelectedIndex = 0;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Search())
            {
                MedicinasBLL.Eliminar(Utilidades.StringToInt(medicinaIdTextBox.Text));
                Limpiar();
                MessageBox.Show("Se elimino la medicina");
            }
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            if (Search())
            {
                Medicinas med = new Medicinas();
                LlenarClases(med);

                MedicinasBLL.Modificar(Utilidades.StringToInt(medicinaIdTextBox.Text), med);

                MessageBox.Show("Se elimino la medicina");
            }
           
        }

        private void LlenaCombo()
        {
            categoriaComboBox.DataSource = CategoriasBLL.GetLista();
            categoriaComboBox.DisplayMember = "Descripcion";
            categoriaComboBox.ValueMember = "CategoriaId";

            LaboratoriocomboBox.DataSource = LaboratoriosBLL.GetLista();
            LaboratoriocomboBox.DisplayMember = "Nombre";
            LaboratoriocomboBox.ValueMember = "LaboratorioId";
        }

        private void categoriaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(categoriaComboBox.SelectedIndex == 8)
            {
                otroslbl.Visible = true;
                OtrostextBox.Visible = true;
            }
            if(categoriaComboBox.SelectedIndex != 8)
            {
                otroslbl.Visible = false;
                OtrostextBox.Visible = false;
            }

        }
    }
}
