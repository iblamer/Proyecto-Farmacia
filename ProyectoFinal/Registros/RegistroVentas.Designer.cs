namespace ProyectoFinal.Registros
{
    partial class RegistroVentas
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
            System.Windows.Forms.Label ventaIdLabel;
            System.Windows.Forms.Label fechaVentaLabel;
            System.Windows.Forms.Label totalLabel;
            System.Windows.Forms.Label subTotalLabel;
            System.Windows.Forms.Label tipoVentaLabel;
            this.ventaIdTextBox = new System.Windows.Forms.TextBox();
            this.fechaVentaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.subTotalTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.MedicinasdataGridView = new System.Windows.Forms.DataGridView();
            this.MedicinascomboBox = new System.Windows.Forms.ComboBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.TipoVentacomboBox = new System.Windows.Forms.ComboBox();
            this.DescuentotextBox = new System.Windows.Forms.TextBox();
            this.ItbistextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DescuentoradioButton = new System.Windows.Forms.RadioButton();
            this.ItbisradioButton = new System.Windows.Forms.RadioButton();
            this.SubTotalerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.MedicinaserrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.totalErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.idErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DescuentoerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.EliminarButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            ventaIdLabel = new System.Windows.Forms.Label();
            fechaVentaLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            subTotalLabel = new System.Windows.Forms.Label();
            tipoVentaLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MedicinasdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubTotalerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MedicinaserrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescuentoerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ventaIdLabel
            // 
            ventaIdLabel.AutoSize = true;
            ventaIdLabel.Location = new System.Drawing.Point(15, 28);
            ventaIdLabel.Name = "ventaIdLabel";
            ventaIdLabel.Size = new System.Drawing.Size(50, 13);
            ventaIdLabel.TabIndex = 0;
            ventaIdLabel.Text = "Venta Id:";
            // 
            // fechaVentaLabel
            // 
            fechaVentaLabel.AutoSize = true;
            fechaVentaLabel.Location = new System.Drawing.Point(15, 55);
            fechaVentaLabel.Name = "fechaVentaLabel";
            fechaVentaLabel.Size = new System.Drawing.Size(71, 13);
            fechaVentaLabel.TabIndex = 2;
            fechaVentaLabel.Text = "Fecha Venta:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(280, 503);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(34, 13);
            totalLabel.TabIndex = 4;
            totalLabel.Text = "Total:";
            // 
            // subTotalLabel
            // 
            subTotalLabel.AutoSize = true;
            subTotalLabel.Location = new System.Drawing.Point(280, 425);
            subTotalLabel.Name = "subTotalLabel";
            subTotalLabel.Size = new System.Drawing.Size(56, 13);
            subTotalLabel.TabIndex = 6;
            subTotalLabel.Text = "Sub Total:";
            // 
            // tipoVentaLabel
            // 
            tipoVentaLabel.AutoSize = true;
            tipoVentaLabel.Location = new System.Drawing.Point(15, 81);
            tipoVentaLabel.Name = "tipoVentaLabel";
            tipoVentaLabel.Size = new System.Drawing.Size(62, 13);
            tipoVentaLabel.TabIndex = 8;
            tipoVentaLabel.Text = "Tipo Venta:";
            // 
            // ventaIdTextBox
            // 
            this.ventaIdTextBox.Location = new System.Drawing.Point(92, 25);
            this.ventaIdTextBox.Name = "ventaIdTextBox";
            this.ventaIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.ventaIdTextBox.TabIndex = 1;
            // 
            // fechaVentaDateTimePicker
            // 
            this.fechaVentaDateTimePicker.Location = new System.Drawing.Point(92, 51);
            this.fechaVentaDateTimePicker.Name = "fechaVentaDateTimePicker";
            this.fechaVentaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaVentaDateTimePicker.TabIndex = 3;
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(342, 500);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(200, 20);
            this.totalTextBox.TabIndex = 5;
            // 
            // subTotalTextBox
            // 
            this.subTotalTextBox.Location = new System.Drawing.Point(342, 422);
            this.subTotalTextBox.Name = "subTotalTextBox";
            this.subTotalTextBox.Size = new System.Drawing.Size(200, 20);
            this.subTotalTextBox.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AgregarButton);
            this.groupBox1.Controls.Add(this.MedicinasdataGridView);
            this.groupBox1.Controls.Add(this.MedicinascomboBox);
            this.groupBox1.Location = new System.Drawing.Point(18, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 267);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medicinas";
            // 
            // AgregarButton
            // 
            this.AgregarButton.Image = global::ProyectoFinal.Properties.Resources.anadir;
            this.AgregarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AgregarButton.Location = new System.Drawing.Point(194, 9);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(80, 31);
            this.AgregarButton.TabIndex = 13;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // MedicinasdataGridView
            // 
            this.MedicinasdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedicinasdataGridView.Location = new System.Drawing.Point(6, 46);
            this.MedicinasdataGridView.Name = "MedicinasdataGridView";
            this.MedicinasdataGridView.Size = new System.Drawing.Size(518, 202);
            this.MedicinasdataGridView.TabIndex = 1;
            this.MedicinasdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MedicinasdataGridView_CellContentClick);
            // 
            // MedicinascomboBox
            // 
            this.MedicinascomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MedicinascomboBox.FormattingEnabled = true;
            this.MedicinascomboBox.Location = new System.Drawing.Point(6, 19);
            this.MedicinascomboBox.Name = "MedicinascomboBox";
            this.MedicinascomboBox.Size = new System.Drawing.Size(182, 21);
            this.MedicinascomboBox.TabIndex = 0;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(298, 22);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 23);
            this.BuscarButton.TabIndex = 14;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // TipoVentacomboBox
            // 
            this.TipoVentacomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoVentacomboBox.FormattingEnabled = true;
            this.TipoVentacomboBox.Location = new System.Drawing.Point(92, 77);
            this.TipoVentacomboBox.Name = "TipoVentacomboBox";
            this.TipoVentacomboBox.Size = new System.Drawing.Size(200, 21);
            this.TipoVentacomboBox.TabIndex = 18;
            // 
            // DescuentotextBox
            // 
            this.DescuentotextBox.Location = new System.Drawing.Point(342, 448);
            this.DescuentotextBox.Name = "DescuentotextBox";
            this.DescuentotextBox.Size = new System.Drawing.Size(200, 20);
            this.DescuentotextBox.TabIndex = 19;
            // 
            // ItbistextBox
            // 
            this.ItbistextBox.Location = new System.Drawing.Point(342, 474);
            this.ItbistextBox.Name = "ItbistextBox";
            this.ItbistextBox.ReadOnly = true;
            this.ItbistextBox.Size = new System.Drawing.Size(200, 20);
            this.ItbistextBox.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Descuento:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "ITBIS:";
            // 
            // DescuentoradioButton
            // 
            this.DescuentoradioButton.AutoSize = true;
            this.DescuentoradioButton.Location = new System.Drawing.Point(18, 104);
            this.DescuentoradioButton.Name = "DescuentoradioButton";
            this.DescuentoradioButton.Size = new System.Drawing.Size(110, 17);
            this.DescuentoradioButton.TabIndex = 25;
            this.DescuentoradioButton.TabStop = true;
            this.DescuentoradioButton.Text = "Aplicar descuento";
            this.DescuentoradioButton.UseVisualStyleBackColor = true;
            // 
            // ItbisradioButton
            // 
            this.ItbisradioButton.AutoSize = true;
            this.ItbisradioButton.Location = new System.Drawing.Point(134, 104);
            this.ItbisradioButton.Name = "ItbisradioButton";
            this.ItbisradioButton.Size = new System.Drawing.Size(87, 17);
            this.ItbisradioButton.TabIndex = 26;
            this.ItbisradioButton.TabStop = true;
            this.ItbisradioButton.Text = "Aplicar ITBIS";
            this.ItbisradioButton.UseVisualStyleBackColor = true;
            this.ItbisradioButton.CheckedChanged += new System.EventHandler(this.ItbisradioButton_CheckedChanged);
            // 
            // SubTotalerrorProvider
            // 
            this.SubTotalerrorProvider.ContainerControl = this;
            // 
            // MedicinaserrorProvider
            // 
            this.MedicinaserrorProvider.ContainerControl = this;
            // 
            // totalErrorProvider
            // 
            this.totalErrorProvider.ContainerControl = this;
            // 
            // idErrorProvider
            // 
            this.idErrorProvider.ContainerControl = this;
            // 
            // DescuentoerrorProvider
            // 
            this.DescuentoerrorProvider.ContainerControl = this;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = global::ProyectoFinal.Properties.Resources.borrar;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(188, 448);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(79, 41);
            this.EliminarButton.TabIndex = 17;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // ModificarButton
            // 
            this.ModificarButton.Image = global::ProyectoFinal.Properties.Resources.escritor;
            this.ModificarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ModificarButton.Location = new System.Drawing.Point(107, 448);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(79, 41);
            this.ModificarButton.TabIndex = 16;
            this.ModificarButton.Text = "Nuevo";
            this.ModificarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ModificarButton.UseVisualStyleBackColor = true;
            this.ModificarButton.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = global::ProyectoFinal.Properties.Resources.guardar;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(26, 448);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(79, 41);
            this.GuardarButton.TabIndex = 15;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // RegistroVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 535);
            this.Controls.Add(this.ItbisradioButton);
            this.Controls.Add(this.DescuentoradioButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ItbistextBox);
            this.Controls.Add(this.DescuentotextBox);
            this.Controls.Add(this.TipoVentacomboBox);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(ventaIdLabel);
            this.Controls.Add(this.ventaIdTextBox);
            this.Controls.Add(fechaVentaLabel);
            this.Controls.Add(this.fechaVentaDateTimePicker);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(subTotalLabel);
            this.Controls.Add(this.subTotalTextBox);
            this.Controls.Add(tipoVentaLabel);
            this.Name = "RegistroVentas";
            this.Text = "RegistroVentas";
            this.Load += new System.EventHandler(this.RegistroVentas_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MedicinasdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubTotalerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MedicinaserrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescuentoerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ventaIdTextBox;
        private System.Windows.Forms.DateTimePicker fechaVentaDateTimePicker;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.TextBox subTotalTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView MedicinasdataGridView;
        private System.Windows.Forms.ComboBox MedicinascomboBox;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.ComboBox TipoVentacomboBox;
        private System.Windows.Forms.TextBox DescuentotextBox;
        private System.Windows.Forms.TextBox ItbistextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton DescuentoradioButton;
        private System.Windows.Forms.RadioButton ItbisradioButton;
        private System.Windows.Forms.ErrorProvider SubTotalerrorProvider;
        private System.Windows.Forms.ErrorProvider MedicinaserrorProvider;
        private System.Windows.Forms.ErrorProvider totalErrorProvider;
        private System.Windows.Forms.ErrorProvider idErrorProvider;
        private System.Windows.Forms.ErrorProvider DescuentoerrorProvider;
    }
}