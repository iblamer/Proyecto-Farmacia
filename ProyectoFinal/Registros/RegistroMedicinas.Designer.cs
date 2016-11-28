namespace ProyectoFinal.Registros
{
    partial class RegistroMedicinas
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
            System.Windows.Forms.Label medicinaIdLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label precioVentaLabel;
            System.Windows.Forms.Label precioCompraLabel;
            System.Windows.Forms.Label fechaVencimientoLabel;
            System.Windows.Forms.Label cantidadExistenciaLabel;
            System.Windows.Forms.Label laboratorioIdLabel;
            System.Windows.Forms.Label especificacionesLabel;
            System.Windows.Forms.Label categoriaIdLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.LaboratoriocomboBox = new System.Windows.Forms.ComboBox();
            this.medicinaIdTextBox = new System.Windows.Forms.TextBox();
            this.medicinasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmaciaDbDataSet = new ProyectoFinal.FarmaciaDbDataSet();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.precioVentaTextBox = new System.Windows.Forms.TextBox();
            this.precioCompraTextBox = new System.Windows.Forms.TextBox();
            this.fechaVencimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cantidadExistenciaTextBox = new System.Windows.Forms.TextBox();
            this.medicinasTableAdapter = new ProyectoFinal.FarmaciaDbDataSetTableAdapters.MedicinasTableAdapter();
            this.tableAdapterManager = new ProyectoFinal.FarmaciaDbDataSetTableAdapters.TableAdapterManager();
            this.EspecificacionesrichTextBox = new System.Windows.Forms.RichTextBox();
            this.DescripcionrichTextBox = new System.Windows.Forms.RichTextBox();
            this.OtrostextBox = new System.Windows.Forms.TextBox();
            this.otroslbl = new System.Windows.Forms.Label();
            medicinaIdLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            precioVentaLabel = new System.Windows.Forms.Label();
            precioCompraLabel = new System.Windows.Forms.Label();
            fechaVencimientoLabel = new System.Windows.Forms.Label();
            cantidadExistenciaLabel = new System.Windows.Forms.Label();
            laboratorioIdLabel = new System.Windows.Forms.Label();
            especificacionesLabel = new System.Windows.Forms.Label();
            categoriaIdLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaciaDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // medicinaIdLabel
            // 
            medicinaIdLabel.AutoSize = true;
            medicinaIdLabel.Location = new System.Drawing.Point(11, 40);
            medicinaIdLabel.Name = "medicinaIdLabel";
            medicinaIdLabel.Size = new System.Drawing.Size(65, 13);
            medicinaIdLabel.TabIndex = 0;
            medicinaIdLabel.Text = "Medicina Id:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(11, 66);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 2;
            nombreLabel.Text = "Nombre:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(11, 92);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 4;
            descripcionLabel.Text = "Descripcion:";
            // 
            // precioVentaLabel
            // 
            precioVentaLabel.AutoSize = true;
            precioVentaLabel.Location = new System.Drawing.Point(11, 144);
            precioVentaLabel.Name = "precioVentaLabel";
            precioVentaLabel.Size = new System.Drawing.Size(71, 13);
            precioVentaLabel.TabIndex = 6;
            precioVentaLabel.Text = "Precio Venta:";
            // 
            // precioCompraLabel
            // 
            precioCompraLabel.AutoSize = true;
            precioCompraLabel.Location = new System.Drawing.Point(11, 170);
            precioCompraLabel.Name = "precioCompraLabel";
            precioCompraLabel.Size = new System.Drawing.Size(79, 13);
            precioCompraLabel.TabIndex = 8;
            precioCompraLabel.Text = "Precio Compra:";
            // 
            // fechaVencimientoLabel
            // 
            fechaVencimientoLabel.AutoSize = true;
            fechaVencimientoLabel.Location = new System.Drawing.Point(11, 197);
            fechaVencimientoLabel.Name = "fechaVencimientoLabel";
            fechaVencimientoLabel.Size = new System.Drawing.Size(101, 13);
            fechaVencimientoLabel.TabIndex = 10;
            fechaVencimientoLabel.Text = "Fecha Vencimiento:";
            // 
            // cantidadExistenciaLabel
            // 
            cantidadExistenciaLabel.AutoSize = true;
            cantidadExistenciaLabel.Location = new System.Drawing.Point(11, 222);
            cantidadExistenciaLabel.Name = "cantidadExistenciaLabel";
            cantidadExistenciaLabel.Size = new System.Drawing.Size(103, 13);
            cantidadExistenciaLabel.TabIndex = 12;
            cantidadExistenciaLabel.Text = "Cantidad Existencia:";
            // 
            // laboratorioIdLabel
            // 
            laboratorioIdLabel.AutoSize = true;
            laboratorioIdLabel.Location = new System.Drawing.Point(11, 248);
            laboratorioIdLabel.Name = "laboratorioIdLabel";
            laboratorioIdLabel.Size = new System.Drawing.Size(66, 13);
            laboratorioIdLabel.TabIndex = 14;
            laboratorioIdLabel.Text = "Laboratorio :";
            // 
            // especificacionesLabel
            // 
            especificacionesLabel.AutoSize = true;
            especificacionesLabel.Location = new System.Drawing.Point(11, 274);
            especificacionesLabel.Name = "especificacionesLabel";
            especificacionesLabel.Size = new System.Drawing.Size(90, 13);
            especificacionesLabel.TabIndex = 16;
            especificacionesLabel.Text = "Especificaciones:";
            // 
            // categoriaIdLabel
            // 
            categoriaIdLabel.AutoSize = true;
            categoriaIdLabel.Location = new System.Drawing.Point(11, 325);
            categoriaIdLabel.Name = "categoriaIdLabel";
            categoriaIdLabel.Size = new System.Drawing.Size(58, 13);
            categoriaIdLabel.TabIndex = 18;
            categoriaIdLabel.Text = "Categoria :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.otroslbl);
            this.groupBox1.Controls.Add(this.OtrostextBox);
            this.groupBox1.Controls.Add(this.DescripcionrichTextBox);
            this.groupBox1.Controls.Add(this.EspecificacionesrichTextBox);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.ModificarButton);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.Guardarbutton);
            this.groupBox1.Controls.Add(this.Buscarbutton);
            this.groupBox1.Controls.Add(this.categoriaComboBox);
            this.groupBox1.Controls.Add(this.LaboratoriocomboBox);
            this.groupBox1.Controls.Add(medicinaIdLabel);
            this.groupBox1.Controls.Add(this.medicinaIdTextBox);
            this.groupBox1.Controls.Add(nombreLabel);
            this.groupBox1.Controls.Add(this.nombreTextBox);
            this.groupBox1.Controls.Add(descripcionLabel);
            this.groupBox1.Controls.Add(precioVentaLabel);
            this.groupBox1.Controls.Add(this.precioVentaTextBox);
            this.groupBox1.Controls.Add(precioCompraLabel);
            this.groupBox1.Controls.Add(this.precioCompraTextBox);
            this.groupBox1.Controls.Add(fechaVencimientoLabel);
            this.groupBox1.Controls.Add(this.fechaVencimientoDateTimePicker);
            this.groupBox1.Controls.Add(cantidadExistenciaLabel);
            this.groupBox1.Controls.Add(this.cantidadExistenciaTextBox);
            this.groupBox1.Controls.Add(laboratorioIdLabel);
            this.groupBox1.Controls.Add(especificacionesLabel);
            this.groupBox1.Controls.Add(categoriaIdLabel);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 437);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de medicinas";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinal.Properties.Resources.medicina__1_;
            this.pictureBox1.Location = new System.Drawing.Point(433, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 307);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // ModificarButton
            // 
            this.ModificarButton.Image = global::ProyectoFinal.Properties.Resources.escritor;
            this.ModificarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ModificarButton.Location = new System.Drawing.Point(213, 386);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(79, 45);
            this.ModificarButton.TabIndex = 23;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ModificarButton.UseVisualStyleBackColor = true;
            this.ModificarButton.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // button3
            // 
            this.button3.Image = global::ProyectoFinal.Properties.Resources.borrar;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(120, 386);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 45);
            this.button3.TabIndex = 22;
            this.button3.Text = "Eliminar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::ProyectoFinal.Properties.Resources.guardar;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarbutton.Location = new System.Drawing.Point(26, 386);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 45);
            this.Guardarbutton.TabIndex = 21;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::ProyectoFinal.Properties.Resources.busqueda;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(326, 28);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(71, 32);
            this.Buscarbutton.TabIndex = 1;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // categoriaComboBox
            // 
            this.categoriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoriaComboBox.FormattingEnabled = true;
            this.categoriaComboBox.Location = new System.Drawing.Point(120, 322);
            this.categoriaComboBox.Name = "categoriaComboBox";
            this.categoriaComboBox.Size = new System.Drawing.Size(200, 21);
            this.categoriaComboBox.TabIndex = 20;
            this.categoriaComboBox.SelectedIndexChanged += new System.EventHandler(this.categoriaComboBox_SelectedIndexChanged);
            // 
            // LaboratoriocomboBox
            // 
            this.LaboratoriocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LaboratoriocomboBox.FormattingEnabled = true;
            this.LaboratoriocomboBox.Location = new System.Drawing.Point(120, 245);
            this.LaboratoriocomboBox.Name = "LaboratoriocomboBox";
            this.LaboratoriocomboBox.Size = new System.Drawing.Size(200, 21);
            this.LaboratoriocomboBox.TabIndex = 19;
            // 
            // medicinaIdTextBox
            // 
            this.medicinaIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicinasBindingSource, "MedicinaId", true));
            this.medicinaIdTextBox.Location = new System.Drawing.Point(120, 37);
            this.medicinaIdTextBox.Name = "medicinaIdTextBox";
            this.medicinaIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.medicinaIdTextBox.TabIndex = 1;
            // 
            // medicinasBindingSource
            // 
            this.medicinasBindingSource.DataMember = "Medicinas";
            this.medicinasBindingSource.DataSource = this.farmaciaDbDataSet;
            // 
            // farmaciaDbDataSet
            // 
            this.farmaciaDbDataSet.DataSetName = "FarmaciaDbDataSet";
            this.farmaciaDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicinasBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(120, 63);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreTextBox.TabIndex = 3;
            // 
            // precioVentaTextBox
            // 
            this.precioVentaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicinasBindingSource, "PrecioVenta", true));
            this.precioVentaTextBox.Location = new System.Drawing.Point(120, 141);
            this.precioVentaTextBox.Name = "precioVentaTextBox";
            this.precioVentaTextBox.Size = new System.Drawing.Size(200, 20);
            this.precioVentaTextBox.TabIndex = 7;
            // 
            // precioCompraTextBox
            // 
            this.precioCompraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicinasBindingSource, "PrecioCompra", true));
            this.precioCompraTextBox.Location = new System.Drawing.Point(120, 167);
            this.precioCompraTextBox.Name = "precioCompraTextBox";
            this.precioCompraTextBox.Size = new System.Drawing.Size(200, 20);
            this.precioCompraTextBox.TabIndex = 9;
            // 
            // fechaVencimientoDateTimePicker
            // 
            this.fechaVencimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.medicinasBindingSource, "FechaVencimiento", true));
            this.fechaVencimientoDateTimePicker.Location = new System.Drawing.Point(120, 193);
            this.fechaVencimientoDateTimePicker.Name = "fechaVencimientoDateTimePicker";
            this.fechaVencimientoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaVencimientoDateTimePicker.TabIndex = 11;
            // 
            // cantidadExistenciaTextBox
            // 
            this.cantidadExistenciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicinasBindingSource, "CantidadExistencia", true));
            this.cantidadExistenciaTextBox.Location = new System.Drawing.Point(120, 219);
            this.cantidadExistenciaTextBox.Name = "cantidadExistenciaTextBox";
            this.cantidadExistenciaTextBox.Size = new System.Drawing.Size(200, 20);
            this.cantidadExistenciaTextBox.TabIndex = 13;
            // 
            // medicinasTableAdapter
            // 
            this.medicinasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LaboratoriosTableAdapter = null;
            this.tableAdapterManager.MedicinasTableAdapter = this.medicinasTableAdapter;
            this.tableAdapterManager.TipoUsuariosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectoFinal.FarmaciaDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            this.tableAdapterManager.VentasTableAdapter = null;
            // 
            // EspecificacionesrichTextBox
            // 
            this.EspecificacionesrichTextBox.Location = new System.Drawing.Point(120, 271);
            this.EspecificacionesrichTextBox.Name = "EspecificacionesrichTextBox";
            this.EspecificacionesrichTextBox.Size = new System.Drawing.Size(200, 45);
            this.EspecificacionesrichTextBox.TabIndex = 25;
            this.EspecificacionesrichTextBox.Text = "";
            // 
            // DescripcionrichTextBox
            // 
            this.DescripcionrichTextBox.Location = new System.Drawing.Point(120, 90);
            this.DescripcionrichTextBox.Name = "DescripcionrichTextBox";
            this.DescripcionrichTextBox.Size = new System.Drawing.Size(200, 45);
            this.DescripcionrichTextBox.TabIndex = 26;
            this.DescripcionrichTextBox.Text = "";
            // 
            // OtrostextBox
            // 
            this.OtrostextBox.Location = new System.Drawing.Point(120, 349);
            this.OtrostextBox.Name = "OtrostextBox";
            this.OtrostextBox.Size = new System.Drawing.Size(200, 20);
            this.OtrostextBox.TabIndex = 27;
            // 
            // otroslbl
            // 
            this.otroslbl.AutoSize = true;
            this.otroslbl.Location = new System.Drawing.Point(11, 356);
            this.otroslbl.Name = "otroslbl";
            this.otroslbl.Size = new System.Drawing.Size(35, 13);
            this.otroslbl.TabIndex = 28;
            this.otroslbl.Text = "Otros:";
            // 
            // RegistroMedicinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 449);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistroMedicinas";
            this.Text = "RegistroMedicinas";
            this.Load += new System.EventHandler(this.RegistroMedicinas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaciaDbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private FarmaciaDbDataSet farmaciaDbDataSet;
        private System.Windows.Forms.BindingSource medicinasBindingSource;
        private FarmaciaDbDataSetTableAdapters.MedicinasTableAdapter medicinasTableAdapter;
        private FarmaciaDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox medicinaIdTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox precioVentaTextBox;
        private System.Windows.Forms.TextBox precioCompraTextBox;
        private System.Windows.Forms.DateTimePicker fechaVencimientoDateTimePicker;
        private System.Windows.Forms.TextBox cantidadExistenciaTextBox;
        private System.Windows.Forms.ComboBox LaboratoriocomboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.ComboBox categoriaComboBox;
        private System.Windows.Forms.RichTextBox DescripcionrichTextBox;
        private System.Windows.Forms.RichTextBox EspecificacionesrichTextBox;
        private System.Windows.Forms.Label otroslbl;
        private System.Windows.Forms.TextBox OtrostextBox;
    }
}