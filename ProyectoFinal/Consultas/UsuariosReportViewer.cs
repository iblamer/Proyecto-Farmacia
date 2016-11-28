using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using BLL;

namespace ProyectoFinal.Consultas
{
    public partial class UsuariosReportViewer : Form
    {
        public UsuariosReportViewer()
        {
            InitializeComponent();
        }

        public void UsuariosReportViewer_Load(object sender, EventArgs e)
        {
            usuariosRptViewer.Reset();
            usuariosRptViewer.ProcessingMode = ProcessingMode.Local;

            usuariosRptViewer.LocalReport.ReportPath = @"E:\aplicada 1\ProyectoFinal\ProyectoFinal\ProyectoFinal\Reporte\ReporteUsuarios.rdlc";

            ReportDataSource source = new ReportDataSource("UsuariosDataSet", UsuariosBLL.GetLista());

            usuariosRptViewer.LocalReport.DataSources.Add(source);

            this.usuariosRptViewer.RefreshReport();


        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
