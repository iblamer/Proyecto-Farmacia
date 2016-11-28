namespace ProyectoFinal.Consultas
{
    partial class VentasReportViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.VentasRptViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // VentasRptViewer
            // 
            this.VentasRptViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VentasRptViewer.Location = new System.Drawing.Point(0, 0);
            this.VentasRptViewer.Name = "VentasRptViewer";
            this.VentasRptViewer.Size = new System.Drawing.Size(894, 463);
            this.VentasRptViewer.TabIndex = 0;
            this.VentasRptViewer.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // VentasReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 463);
            this.Controls.Add(this.VentasRptViewer);
            this.Name = "VentasReportViewer";
            this.Text = "VentasReportViewer";
            this.Load += new System.EventHandler(this.VentasReportViewer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer VentasRptViewer;
    }
}