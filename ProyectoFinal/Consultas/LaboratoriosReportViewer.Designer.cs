namespace ProyectoFinal.Consultas
{
    partial class LaboratoriosReportViewer
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
            this.LaboratoriosRptViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // LaboratoriosRptViewer
            // 
            this.LaboratoriosRptViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LaboratoriosRptViewer.Location = new System.Drawing.Point(0, 0);
            this.LaboratoriosRptViewer.Name = "LaboratoriosRptViewer";
            this.LaboratoriosRptViewer.Size = new System.Drawing.Size(548, 392);
            this.LaboratoriosRptViewer.TabIndex = 3;
            // 
            // LaboratoriosReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 392);
            this.Controls.Add(this.LaboratoriosRptViewer);
            this.Name = "LaboratoriosReportViewer";
            this.Text = "LaboratoriosReportViewer";
            this.Load += new System.EventHandler(this.LaboratoriosReportViewer_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer LaboratoriosRptViewer;
    }
}