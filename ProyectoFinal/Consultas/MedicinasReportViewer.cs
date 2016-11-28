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
    public partial class MedicinasReportViewer : Form
    {
        public MedicinasReportViewer()
        {
            InitializeComponent();
        }

        private void MedicinasReportViewer_Load(object sender, EventArgs e)
        {

            MediciansRptViewer.Reset();
            MediciansRptViewer.ProcessingMode = ProcessingMode.Local;

            MediciansRptViewer.LocalReport.ReportPath = @"E:\aplicada 1\ProyectoFinal\ProyectoFinal\ProyectoFinal\Reporte\ReporteMedicinas.rdlc";

            ReportDataSource source = new ReportDataSource("DataSetMedicinas", MedicinasBLL.GetLista());

            MediciansRptViewer.LocalReport.DataSources.Add(source);

            this.MediciansRptViewer.RefreshReport();
        }

        private void MediciansRptViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
