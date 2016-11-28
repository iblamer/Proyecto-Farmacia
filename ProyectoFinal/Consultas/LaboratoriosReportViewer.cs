using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Microsoft.Reporting.WinForms;

namespace ProyectoFinal.Consultas
{
    public partial class LaboratoriosReportViewer : Form
    {
        public LaboratoriosReportViewer()
        {
            InitializeComponent();
        }

        private void LaboratoriosReportViewer_Load(object sender, EventArgs e)
        {
            LaboratoriosRptViewer.Reset();
            LaboratoriosRptViewer.ProcessingMode = ProcessingMode.Local;

            LaboratoriosRptViewer.LocalReport.ReportPath = @"E:\aplicada 1\ProyectoFinal\ProyectoFinal\ProyectoFinal\Reporte\ReporteLaboratorios.rdlc";

            ReportDataSource source = new ReportDataSource("DataSetLaboratorios", LaboratoriosBLL.GetLista());

            LaboratoriosRptViewer.LocalReport.DataSources.Add(source);

            this.LaboratoriosRptViewer.RefreshReport();

        }
    }
}
