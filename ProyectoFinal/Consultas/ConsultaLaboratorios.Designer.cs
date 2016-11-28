namespace ProyectoFinal.Consultas
{
    partial class ConsultaLaboratorios
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
            this.LaboratoriosdataGridView = new System.Windows.Forms.DataGridView();
            this.FiltrocomboBox = new System.Windows.Forms.ComboBox();
            this.FiltrotextBox = new System.Windows.Forms.TextBox();
            this.buscarButton = new System.Windows.Forms.Button();
            this.DesdedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Imprimirbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LaboratoriosdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LaboratoriosdataGridView
            // 
            this.LaboratoriosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LaboratoriosdataGridView.Location = new System.Drawing.Point(12, 108);
            this.LaboratoriosdataGridView.Name = "LaboratoriosdataGridView";
            this.LaboratoriosdataGridView.Size = new System.Drawing.Size(516, 210);
            this.LaboratoriosdataGridView.TabIndex = 0;
            // 
            // FiltrocomboBox
            // 
            this.FiltrocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrocomboBox.FormattingEnabled = true;
            this.FiltrocomboBox.Items.AddRange(new object[] {
            "Todos",
            "Id",
            "Nombre",
            "Fecha de ingreso"});
            this.FiltrocomboBox.Location = new System.Drawing.Point(12, 29);
            this.FiltrocomboBox.Name = "FiltrocomboBox";
            this.FiltrocomboBox.Size = new System.Drawing.Size(149, 21);
            this.FiltrocomboBox.TabIndex = 1;
            // 
            // FiltrotextBox
            // 
            this.FiltrotextBox.Location = new System.Drawing.Point(167, 29);
            this.FiltrotextBox.Name = "FiltrotextBox";
            this.FiltrotextBox.Size = new System.Drawing.Size(267, 20);
            this.FiltrotextBox.TabIndex = 2;
            // 
            // buscarButton
            // 
            this.buscarButton.Image = global::ProyectoFinal.Properties.Resources.busqueda;
            this.buscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscarButton.Location = new System.Drawing.Point(453, 23);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(75, 30);
            this.buscarButton.TabIndex = 3;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // DesdedateTimePicker
            // 
            this.DesdedateTimePicker.Location = new System.Drawing.Point(57, 67);
            this.DesdedateTimePicker.Name = "DesdedateTimePicker";
            this.DesdedateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DesdedateTimePicker.TabIndex = 4;
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.Location = new System.Drawing.Point(328, 67);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.HastadateTimePicker.TabIndex = 5;
            // 
            // Imprimirbutton
            // 
            this.Imprimirbutton.Image = global::ProyectoFinal.Properties.Resources.impresora;
            this.Imprimirbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Imprimirbutton.Location = new System.Drawing.Point(22, 324);
            this.Imprimirbutton.Name = "Imprimirbutton";
            this.Imprimirbutton.Size = new System.Drawing.Size(75, 35);
            this.Imprimirbutton.TabIndex = 6;
            this.Imprimirbutton.Text = "Imprimir";
            this.Imprimirbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Imprimirbutton.UseVisualStyleBackColor = true;
            this.Imprimirbutton.Click += new System.EventHandler(this.Imprimirbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Filtro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Desde:";
            // 
            // ConsultaLaboratorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 369);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Imprimirbutton);
            this.Controls.Add(this.HastadateTimePicker);
            this.Controls.Add(this.DesdedateTimePicker);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.FiltrotextBox);
            this.Controls.Add(this.FiltrocomboBox);
            this.Controls.Add(this.LaboratoriosdataGridView);
            this.Name = "ConsultaLaboratorios";
            this.Text = "ConsultaLaboratorios";
            ((System.ComponentModel.ISupportInitialize)(this.LaboratoriosdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView LaboratoriosdataGridView;
        private System.Windows.Forms.ComboBox FiltrocomboBox;
        private System.Windows.Forms.TextBox FiltrotextBox;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.DateTimePicker DesdedateTimePicker;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.Button Imprimirbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}