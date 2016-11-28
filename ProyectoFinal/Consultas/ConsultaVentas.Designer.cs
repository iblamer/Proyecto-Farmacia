namespace ProyectoFinal.Consultas
{
    partial class ConsultaVentas
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
            this.components = new System.ComponentModel.Container();
            this.filtroComboBox = new System.Windows.Forms.ComboBox();
            this.filtroTextBox = new System.Windows.Forms.TextBox();
            this.VentasdataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Filtrarbutton = new System.Windows.Forms.Button();
            this.Imprimirbutton = new System.Windows.Forms.Button();
            this.DesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FiltroerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.VentasdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiltroerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // filtroComboBox
            // 
            this.filtroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtroComboBox.FormattingEnabled = true;
            this.filtroComboBox.Items.AddRange(new object[] {
            "Todos",
            "Rango de fecha",
            "Tipo de venta",
            "Id"});
            this.filtroComboBox.Location = new System.Drawing.Point(31, 33);
            this.filtroComboBox.Name = "filtroComboBox";
            this.filtroComboBox.Size = new System.Drawing.Size(121, 21);
            this.filtroComboBox.TabIndex = 0;
            // 
            // filtroTextBox
            // 
            this.filtroTextBox.Location = new System.Drawing.Point(158, 34);
            this.filtroTextBox.Name = "filtroTextBox";
            this.filtroTextBox.Size = new System.Drawing.Size(429, 20);
            this.filtroTextBox.TabIndex = 1;
            // 
            // VentasdataGridView
            // 
            this.VentasdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VentasdataGridView.Location = new System.Drawing.Point(31, 89);
            this.VentasdataGridView.Name = "VentasdataGridView";
            this.VentasdataGridView.Size = new System.Drawing.Size(817, 315);
            this.VentasdataGridView.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtro";
            // 
            // Filtrarbutton
            // 
            this.Filtrarbutton.Location = new System.Drawing.Point(593, 28);
            this.Filtrarbutton.Name = "Filtrarbutton";
            this.Filtrarbutton.Size = new System.Drawing.Size(108, 30);
            this.Filtrarbutton.TabIndex = 4;
            this.Filtrarbutton.Text = "Filtrar";
            this.Filtrarbutton.UseVisualStyleBackColor = true;
            this.Filtrarbutton.Click += new System.EventHandler(this.Filtrarbutton_Click);
            // 
            // Imprimirbutton
            // 
            this.Imprimirbutton.Location = new System.Drawing.Point(31, 410);
            this.Imprimirbutton.Name = "Imprimirbutton";
            this.Imprimirbutton.Size = new System.Drawing.Size(108, 39);
            this.Imprimirbutton.TabIndex = 5;
            this.Imprimirbutton.Text = "Imprimir";
            this.Imprimirbutton.UseVisualStyleBackColor = true;
            this.Imprimirbutton.Click += new System.EventHandler(this.Imprimirbutton_Click);
            // 
            // DesdeDateTimePicker
            // 
            this.DesdeDateTimePicker.Location = new System.Drawing.Point(31, 63);
            this.DesdeDateTimePicker.Name = "DesdeDateTimePicker";
            this.DesdeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DesdeDateTimePicker.TabIndex = 6;
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.Location = new System.Drawing.Point(304, 63);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.HastadateTimePicker.TabIndex = 7;
            // 
            // FiltroerrorProvider
            // 
            this.FiltroerrorProvider.ContainerControl = this;
            // 
            // ConsultaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 452);
            this.Controls.Add(this.HastadateTimePicker);
            this.Controls.Add(this.DesdeDateTimePicker);
            this.Controls.Add(this.Imprimirbutton);
            this.Controls.Add(this.Filtrarbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VentasdataGridView);
            this.Controls.Add(this.filtroTextBox);
            this.Controls.Add(this.filtroComboBox);
            this.Name = "ConsultaVentas";
            this.Text = "ConsultaVentas";
            this.Load += new System.EventHandler(this.ConsultaVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VentasdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiltroerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox filtroComboBox;
        private System.Windows.Forms.TextBox filtroTextBox;
        private System.Windows.Forms.DataGridView VentasdataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Filtrarbutton;
        private System.Windows.Forms.Button Imprimirbutton;
        private System.Windows.Forms.DateTimePicker DesdeDateTimePicker;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.ErrorProvider FiltroerrorProvider;
    }
}