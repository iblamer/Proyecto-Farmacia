namespace ProyectoFinal.Consultas
{
    partial class ConsultaMedicinas
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
            this.medicinasDataGridView = new System.Windows.Forms.DataGridView();
            this.FiltrocomboBox = new System.Windows.Forms.ComboBox();
            this.FiltrotextBox = new System.Windows.Forms.TextBox();
            this.DesdedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Filtrarbutton = new System.Windows.Forms.Button();
            this.imprimirButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.medicinasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // medicinasDataGridView
            // 
            this.medicinasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicinasDataGridView.Location = new System.Drawing.Point(41, 112);
            this.medicinasDataGridView.Name = "medicinasDataGridView";
            this.medicinasDataGridView.Size = new System.Drawing.Size(873, 307);
            this.medicinasDataGridView.TabIndex = 0;
            // 
            // FiltrocomboBox
            // 
            this.FiltrocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrocomboBox.FormattingEnabled = true;
            this.FiltrocomboBox.Items.AddRange(new object[] {
            "Todos",
            "Id",
            "Nombre",
            "FechaVencimiento",
            "Laboratorio",
            "Categoria"});
            this.FiltrocomboBox.Location = new System.Drawing.Point(41, 33);
            this.FiltrocomboBox.Name = "FiltrocomboBox";
            this.FiltrocomboBox.Size = new System.Drawing.Size(200, 21);
            this.FiltrocomboBox.TabIndex = 1;
            // 
            // FiltrotextBox
            // 
            this.FiltrotextBox.Location = new System.Drawing.Point(291, 33);
            this.FiltrotextBox.Name = "FiltrotextBox";
            this.FiltrotextBox.Size = new System.Drawing.Size(419, 20);
            this.FiltrotextBox.TabIndex = 2;
            this.FiltrotextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DesdedateTimePicker
            // 
            this.DesdedateTimePicker.Location = new System.Drawing.Point(41, 67);
            this.DesdedateTimePicker.Name = "DesdedateTimePicker";
            this.DesdedateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DesdedateTimePicker.TabIndex = 3;
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.Location = new System.Drawing.Point(291, 67);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.HastadateTimePicker.TabIndex = 4;
            // 
            // Filtrarbutton
            // 
            this.Filtrarbutton.Location = new System.Drawing.Point(732, 30);
            this.Filtrarbutton.Name = "Filtrarbutton";
            this.Filtrarbutton.Size = new System.Drawing.Size(75, 23);
            this.Filtrarbutton.TabIndex = 5;
            this.Filtrarbutton.Text = "Filtrar";
            this.Filtrarbutton.UseVisualStyleBackColor = true;
            this.Filtrarbutton.Click += new System.EventHandler(this.Filtrarbutton_Click);
            // 
            // imprimirButton
            // 
            this.imprimirButton.Location = new System.Drawing.Point(41, 441);
            this.imprimirButton.Name = "imprimirButton";
            this.imprimirButton.Size = new System.Drawing.Size(75, 34);
            this.imprimirButton.TabIndex = 6;
            this.imprimirButton.Text = "Imprimir";
            this.imprimirButton.UseVisualStyleBackColor = true;
            this.imprimirButton.Click += new System.EventHandler(this.imprimirButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Filtro";
            // 
            // ConsultaMedicinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 487);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imprimirButton);
            this.Controls.Add(this.Filtrarbutton);
            this.Controls.Add(this.HastadateTimePicker);
            this.Controls.Add(this.DesdedateTimePicker);
            this.Controls.Add(this.FiltrotextBox);
            this.Controls.Add(this.FiltrocomboBox);
            this.Controls.Add(this.medicinasDataGridView);
            this.Name = "ConsultaMedicinas";
            this.Text = "ConsultaMedicinas";
            ((System.ComponentModel.ISupportInitialize)(this.medicinasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView medicinasDataGridView;
        private System.Windows.Forms.ComboBox FiltrocomboBox;
        private System.Windows.Forms.TextBox FiltrotextBox;
        private System.Windows.Forms.DateTimePicker DesdedateTimePicker;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.Button Filtrarbutton;
        private System.Windows.Forms.Button imprimirButton;
        private System.Windows.Forms.Label label1;
    }
}