namespace ProyectoFinal.Consultas
{
    partial class UsuariosReportViewer
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
            this.usuariosRptViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // usuariosRptViewer
            // 
            this.usuariosRptViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usuariosRptViewer.DocumentMapWidth = 15;
            this.usuariosRptViewer.Location = new System.Drawing.Point(0, 0);
            this.usuariosRptViewer.Name = "usuariosRptViewer";
            this.usuariosRptViewer.Size = new System.Drawing.Size(934, 514);
            this.usuariosRptViewer.TabIndex = 0;
            this.usuariosRptViewer.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // reportViewer2
            // 
            this.reportViewer2.Location = new System.Drawing.Point(645, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(8, 8);
            this.reportViewer2.TabIndex = 1;
            // 
            // UsuariosReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 514);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.usuariosRptViewer);
            this.Name = "UsuariosReportViewer";
            this.Text = "UsuariosReportViewer";
            this.Load += new System.EventHandler(this.UsuariosReportViewer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer usuariosRptViewer;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
    }
}