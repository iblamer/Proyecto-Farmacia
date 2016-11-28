using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Microsoft.Reporting.WinForms;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace ProyectoFinal.Consultas
{
    public partial class VentasReportViewer : Form
    {
        public VentasReportViewer()
        {
            InitializeComponent();
        }

        private void VentasReportViewer_Load(object sender, EventArgs e)
        {
            VentasRptViewer.Reset();
            VentasRptViewer.ProcessingMode = ProcessingMode.Local;

            VentasRptViewer.LocalReport.ReportPath = @"E:\aplicada 1\ProyectoFinal\ProyectoFinal\ProyectoFinal\Reporte\ReporteVentas.rdlc";

            ReportDataSource source = new ReportDataSource("DataSetVentas", VentasBLL.GetLista());

            VentasRptViewer.LocalReport.DataSources.Add(source);

            this.VentasRptViewer.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
