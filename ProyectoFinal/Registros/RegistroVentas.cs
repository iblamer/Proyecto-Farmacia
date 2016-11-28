﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using DAL;
using Entidades;

namespace ProyectoFinal.Registros
{
        public partial class RegistroVentas : Form
        {
        public RegistroVentas()
        {
            InitializeComponent();
        }

        private Ventas venta = new Ventas();
    

        private void RegistroVentas_Load(object sender, EventArgs e)
        {
            LlenaCombo();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Medicinas> lista = new List<Medicinas>();
            lista = MedicinasBLL.GetLista(Convert.ToInt32(MedicinascomboBox.SelectedValue));
            venta.Medicina.AddRange(lista); 
            MedicinasdataGridView.DataSource = null;
            MedicinasdataGridView.DataSource = venta.Medicina;

            subTotalTextBox.Text = (from DataGridViewRow row in MedicinasdataGridView.Rows
                                    where row.Cells[3].FormattedValue.ToString() != string.Empty
                                    select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();
            if (ItbisradioButton.Checked == true && DescuentoradioButton.Checked == false)
            {
                totalTextBox.Text = (double.Parse(subTotalTextBox.Text) * 1.18).ToString();
            }

            if(ItbisradioButton.Checked == true && DescuentoradioButton.Checked == true)
            {
                totalTextBox.Text = (double.Parse(subTotalTextBox.Text) * (double.Parse(DescuentotextBox.Text) + 1) * (1.18)).ToString();
            }

            if(DescuentoradioButton.Checked == true && ItbisradioButton.Checked == false)
            {
                totalTextBox.Text = (double.Parse(subTotalTextBox.Text) * (double.Parse(DescuentotextBox.Text) + 1)).ToString();
            }

            if(ItbisradioButton.Checked == false && DescuentoradioButton.Checked == false)
            {
                totalTextBox.Text = subTotalTextBox.Text;
            }

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            var v = new Ventas();

            if (Validacion())
            {
                LlenarClases(v);

                VentasBLL.Insertar(v);
                MessageBox.Show("Se guardo la venta realizada");
          
            }

        }

        private void LlenaCombo()
        {
            MedicinascomboBox.DataSource = MedicinasBLL.GetLista();
            MedicinascomboBox.DisplayMember = "Nombre";
            MedicinascomboBox.ValueMember = "MedicinaId";

            TipoVentacomboBox.DataSource = TipoVentasBLL.GetLista();
            TipoVentacomboBox.DisplayMember = "Descripcion";
            TipoVentacomboBox.ValueMember = "TipoVentaId";
            
        }


        private void LlenarClases(Ventas venta)
        {
            venta.FechaVenta = fechaVentaDateTimePicker.Value;
            venta.Total = double.Parse(totalTextBox.Text);
            venta.SubTotal = double.Parse(subTotalTextBox.Text);
            venta.TipoVentaId = TipoVentacomboBox.SelectedIndex;
            venta.Medicina = venta.Medicina;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if (ValidarId("Ingrese el id de la venta que quiere buscar") &&Search()) 
            {
                Fill( VentasBLL.Buscar(Utilidades.StringToInt(ventaIdTextBox.Text)));
            }
        }

        private void Fill(Ventas venta)
        {
            fechaVentaDateTimePicker.Value = venta.FechaVenta;
            totalTextBox.Text = venta.Total.ToString();
            subTotalTextBox.Text = venta.SubTotal.ToString();
            TipoVentacomboBox.SelectedIndex = venta.TipoVentaId;
            var lista = new List<Medicinas>();
            MedicinasdataGridView.DataSource = null;
            MedicinasdataGridView.DataSource = venta.Medicina;

        }

        private bool Search()
        {
            if(VentasBLL.Buscar(Utilidades.StringToInt(ventaIdTextBox.Text)) == null)
            {
                MessageBox.Show("El id no existe");
                return false;
            }

            return true;
        }


        private void MedicinasdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if(ValidarId("Ingrese el id de la venta que quiere eliminar") && Search())
            {
                VentasBLL.Eliminar(Utilidades.StringToInt(ventaIdTextBox.Text));
                MessageBox.Show("Se elimino la venta");
                limpiar();
                LimpiarErrores();
                
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ItbisradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(ItbisradioButton.Checked == true)
            {
                ItbistextBox.Text = "18%";
            }

            if(ItbisradioButton.Checked == false)
            {
                ItbistextBox.Text = " ";
            }
        }

        private bool ValidarId(string mensaje)
        {
            if(string.IsNullOrEmpty(ventaIdTextBox.Text))
            {
                idErrorProvider.SetError(ventaIdTextBox, "Ingresar el ID");
                MessageBox.Show(mensaje);
                return false;
            }

            else
            {
                return true;
            }
        }

        private void LimpiarErrores()
        {
            idErrorProvider.Clear();
            totalErrorProvider.Clear();
            SubTotalerrorProvider.Clear();
            MedicinaserrorProvider.Clear();
        }

        private bool Validacion()
        {
            if(string.IsNullOrEmpty(totalTextBox.Text) && MedicinasdataGridView.Rows.Count == 0 && string.IsNullOrEmpty(subTotalTextBox.Text))
            {
                totalErrorProvider.SetError(totalTextBox, "Ingrese medicinas para generar el total del a venta");
                SubTotalerrorProvider.SetError(subTotalTextBox, "Ingrese medicinas para generar el precio de la venta");
                MedicinaserrorProvider.SetError(MedicinasdataGridView, "Ingrese medicinas");
                MessageBox.Show("Por favor llenar todos los campos");
                return false;
            }

            if(MedicinasdataGridView.Rows.Count == 0)
            {
                MedicinaserrorProvider.SetError(MedicinasdataGridView, "Ingrese medicinas");
                return false;
            }

            if(string.IsNullOrEmpty(totalTextBox.Text) && string.IsNullOrEmpty(subTotalTextBox.Text))
            {
                SubTotalerrorProvider.SetError(subTotalTextBox, "Ingrese medicinas para generar el precio de la venta");
                totalErrorProvider.SetError(totalTextBox, "Ingrese medicinas para generar el total de la venta");
                return false;
            }

            if(DescuentoradioButton.Checked == true && string.IsNullOrEmpty(DescuentotextBox.Text))
            {
                DescuentoerrorProvider.SetError(DescuentotextBox, "Ingrese el descuento para el articulo");
            }

            return true;


        }

        private void limpiar()
        {
            totalTextBox.Clear();
            subTotalTextBox.Clear();
            MedicinasdataGridView.Rows.Clear();
            MedicinasdataGridView.Refresh();
            MedicinascomboBox.SelectedIndex = 0;
            ItbisradioButton.Checked = false;
            DescuentoradioButton.Checked = false;              
        }

    }
}
