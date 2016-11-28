namespace ProyectoFinal.Registros
{
    partial class RegistroLaboratorios
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
            System.Windows.Forms.Label laboratorioIdLabel;
            System.Windows.Forms.Label nombreLabel;
            this.farmaciaDbDataSet = new ProyectoFinal.FarmaciaDbDataSet();
            this.laboratoriosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laboratoriosTableAdapter = new ProyectoFinal.FarmaciaDbDataSetTableAdapters.LaboratoriosTableAdapter();
            this.tableAdapterManager = new ProyectoFinal.FarmaciaDbDataSetTableAdapters.TableAdapterManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FechaIngresotextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.laboratorioIdTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.farmaciaDbDataSet1 = new ProyectoFinal.FarmaciaDbDataSet();
            this.NombreerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.buscarErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            laboratorioIdLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.farmaciaDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboratoriosBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaciaDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // laboratorioIdLabel
            // 
            laboratorioIdLabel.AutoSize = true;
            laboratorioIdLabel.Location = new System.Drawing.Point(12, 26);
            laboratorioIdLabel.Name = "laboratorioIdLabel";
            laboratorioIdLabel.Size = new System.Drawing.Size(75, 13);
            laboratorioIdLabel.TabIndex = 9;
            laboratorioIdLabel.Text = "Laboratorio Id:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(12, 52);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 11;
            nombreLabel.Text = "Nombre:";
            // 
            // farmaciaDbDataSet
            // 
            this.farmaciaDbDataSet.DataSetName = "FarmaciaDbDataSet";
            this.farmaciaDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // laboratoriosBindingSource
            // 
            this.laboratoriosBindingSource.DataMember = "Laboratorios";
            this.laboratoriosBindingSource.DataSource = this.farmaciaDbDataSet;
            // 
            // laboratoriosTableAdapter
            // 
            this.laboratoriosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LaboratoriosTableAdapter = this.laboratoriosTableAdapter;
            this.tableAdapterManager.MedicinasTableAdapter = null;
            this.tableAdapterManager.TipoUsuariosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectoFinal.FarmaciaDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            this.tableAdapterManager.VentasTableAdapter = null;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FechaIngresotextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.GuardarButton);
            this.groupBox1.Controls.Add(this.EliminarButton);
            this.groupBox1.Controls.Add(this.Buscarbutton);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(laboratorioIdLabel);
            this.groupBox1.Controls.Add(this.laboratorioIdTextBox);
            this.groupBox1.Controls.Add(nombreLabel);
            this.groupBox1.Controls.Add(this.nombreTextBox);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de laboratorios";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // FechaIngresotextBox
            // 
            this.FechaIngresotextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laboratoriosBindingSource, "Nombre", true));
            this.FechaIngresotextBox.Location = new System.Drawing.Point(107, 78);
            this.FechaIngresotextBox.Name = "FechaIngresotextBox";
            this.FechaIngresotextBox.ReadOnly = true;
            this.FechaIngresotextBox.Size = new System.Drawing.Size(200, 20);
            this.FechaIngresotextBox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Fecha de ingreso:";
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = global::ProyectoFinal.Properties.Resources.guardar;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(12, 102);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 37);
            this.GuardarButton.TabIndex = 16;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = global::ProyectoFinal.Properties.Resources.borrar;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(118, 104);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 37);
            this.EliminarButton.TabIndex = 15;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::ProyectoFinal.Properties.Resources.busqueda;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(317, 19);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 37);
            this.Buscarbutton.TabIndex = 14;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinal.Properties.Resources.quimica;
            this.pictureBox1.Location = new System.Drawing.Point(317, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // laboratorioIdTextBox
            // 
            this.laboratorioIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laboratoriosBindingSource, "LaboratorioId", true));
            this.laboratorioIdTextBox.Location = new System.Drawing.Point(107, 23);
            this.laboratorioIdTextBox.Name = "laboratorioIdTextBox";
            this.laboratorioIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.laboratorioIdTextBox.TabIndex = 10;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laboratoriosBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(107, 49);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreTextBox.TabIndex = 12;
            // 
            // farmaciaDbDataSet1
            // 
            this.farmaciaDbDataSet1.DataSetName = "FarmaciaDbDataSet";
            this.farmaciaDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NombreerrorProvider
            // 
            this.NombreerrorProvider.ContainerControl = this;
            // 
            // buscarErrorProvider
            // 
            this.buscarErrorProvider.ContainerControl = this;
            // 
            // RegistroLaboratorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 151);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistroLaboratorios";
            this.Text = "RegistroLaboratorios";
            this.Load += new System.EventHandler(this.RegistroLaboratorios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.farmaciaDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboratoriosBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaciaDbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FarmaciaDbDataSet farmaciaDbDataSet;
        private System.Windows.Forms.BindingSource laboratoriosBindingSource;
        private FarmaciaDbDataSetTableAdapters.LaboratoriosTableAdapter laboratoriosTableAdapter;
        private FarmaciaDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox laboratorioIdTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Label label1;
        private FarmaciaDbDataSet farmaciaDbDataSet1;
        private System.Windows.Forms.TextBox FechaIngresotextBox;
        private System.Windows.Forms.ErrorProvider NombreerrorProvider;
        private System.Windows.Forms.ErrorProvider buscarErrorProvider;
    }
}