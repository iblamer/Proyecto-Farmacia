namespace ProyectoFinal.Registros
{
    partial class RegistroUsuarios
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
            System.Windows.Forms.Label usuarioIdLabel;
            System.Windows.Forms.Label nombresLabel;
            System.Windows.Forms.Label nombreUsuarioLabel;
            System.Windows.Forms.Label fechaNacimientoLabel;
            System.Windows.Forms.Label claveLabel;
            System.Windows.Forms.Label telefonoCasaLabel;
            System.Windows.Forms.Label telefonoCelularLabel;
            System.Windows.Forms.Label tipoIdLabel;
            System.Windows.Forms.Label label1;
            this.farmaciaDbDataSet = new ProyectoFinal.FarmaciaDbDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.celularMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.casaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ConfirmartextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TipocomboBox = new System.Windows.Forms.ComboBox();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.usuarioIdTextBox = new System.Windows.Forms.TextBox();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.nombreUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.fechaNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.claveTextBox = new System.Windows.Forms.TextBox();
            this.IderrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.NombreerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.nombreUsuarioerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ClaveerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.TelefonoerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            usuarioIdLabel = new System.Windows.Forms.Label();
            nombresLabel = new System.Windows.Forms.Label();
            nombreUsuarioLabel = new System.Windows.Forms.Label();
            fechaNacimientoLabel = new System.Windows.Forms.Label();
            claveLabel = new System.Windows.Forms.Label();
            telefonoCasaLabel = new System.Windows.Forms.Label();
            telefonoCelularLabel = new System.Windows.Forms.Label();
            tipoIdLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.farmaciaDbDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IderrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombreUsuarioerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClaveerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelefonoerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // usuarioIdLabel
            // 
            usuarioIdLabel.AutoSize = true;
            usuarioIdLabel.Location = new System.Drawing.Point(6, 29);
            usuarioIdLabel.Name = "usuarioIdLabel";
            usuarioIdLabel.Size = new System.Drawing.Size(58, 13);
            usuarioIdLabel.TabIndex = 17;
            usuarioIdLabel.Text = "Usuario Id:";
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.Location = new System.Drawing.Point(6, 55);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(52, 13);
            nombresLabel.TabIndex = 19;
            nombresLabel.Text = "Nombres:";
            // 
            // nombreUsuarioLabel
            // 
            nombreUsuarioLabel.AutoSize = true;
            nombreUsuarioLabel.Location = new System.Drawing.Point(6, 81);
            nombreUsuarioLabel.Name = "nombreUsuarioLabel";
            nombreUsuarioLabel.Size = new System.Drawing.Size(86, 13);
            nombreUsuarioLabel.TabIndex = 21;
            nombreUsuarioLabel.Text = "Nombre Usuario:";
            // 
            // fechaNacimientoLabel
            // 
            fechaNacimientoLabel.AutoSize = true;
            fechaNacimientoLabel.Location = new System.Drawing.Point(6, 158);
            fechaNacimientoLabel.Name = "fechaNacimientoLabel";
            fechaNacimientoLabel.Size = new System.Drawing.Size(96, 13);
            fechaNacimientoLabel.TabIndex = 23;
            fechaNacimientoLabel.Text = "Fecha Nacimiento:";
            // 
            // claveLabel
            // 
            claveLabel.AutoSize = true;
            claveLabel.Location = new System.Drawing.Point(6, 105);
            claveLabel.Name = "claveLabel";
            claveLabel.Size = new System.Drawing.Size(37, 13);
            claveLabel.TabIndex = 25;
            claveLabel.Text = "Clave:";
            // 
            // telefonoCasaLabel
            // 
            telefonoCasaLabel.AutoSize = true;
            telefonoCasaLabel.Location = new System.Drawing.Point(7, 183);
            telefonoCasaLabel.Name = "telefonoCasaLabel";
            telefonoCasaLabel.Size = new System.Drawing.Size(79, 13);
            telefonoCasaLabel.TabIndex = 27;
            telefonoCasaLabel.Text = "Telefono Casa:";
            // 
            // telefonoCelularLabel
            // 
            telefonoCelularLabel.AutoSize = true;
            telefonoCelularLabel.Location = new System.Drawing.Point(7, 209);
            telefonoCelularLabel.Name = "telefonoCelularLabel";
            telefonoCelularLabel.Size = new System.Drawing.Size(87, 13);
            telefonoCelularLabel.TabIndex = 29;
            telefonoCelularLabel.Text = "Telefono Celular:";
            // 
            // tipoIdLabel
            // 
            tipoIdLabel.AutoSize = true;
            tipoIdLabel.Location = new System.Drawing.Point(7, 235);
            tipoIdLabel.Name = "tipoIdLabel";
            tipoIdLabel.Size = new System.Drawing.Size(70, 13);
            tipoIdLabel.TabIndex = 31;
            tipoIdLabel.Text = "Tipo Usuario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(7, 131);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(84, 13);
            label1.TabIndex = 39;
            label1.Text = "Confirmar Clave:";
            // 
            // farmaciaDbDataSet
            // 
            this.farmaciaDbDataSet.DataSetName = "FarmaciaDbDataSet";
            this.farmaciaDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.celularMaskedTextBox);
            this.groupBox1.Controls.Add(this.casaMaskedTextBox);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.ConfirmartextBox);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.TipocomboBox);
            this.groupBox1.Controls.Add(this.ModificarButton);
            this.groupBox1.Controls.Add(this.EliminarButton);
            this.groupBox1.Controls.Add(this.GuardarButton);
            this.groupBox1.Controls.Add(this.BuscarButton);
            this.groupBox1.Controls.Add(usuarioIdLabel);
            this.groupBox1.Controls.Add(this.usuarioIdTextBox);
            this.groupBox1.Controls.Add(nombresLabel);
            this.groupBox1.Controls.Add(this.nombresTextBox);
            this.groupBox1.Controls.Add(nombreUsuarioLabel);
            this.groupBox1.Controls.Add(this.nombreUsuarioTextBox);
            this.groupBox1.Controls.Add(fechaNacimientoLabel);
            this.groupBox1.Controls.Add(this.fechaNacimientoDateTimePicker);
            this.groupBox1.Controls.Add(claveLabel);
            this.groupBox1.Controls.Add(this.claveTextBox);
            this.groupBox1.Controls.Add(telefonoCasaLabel);
            this.groupBox1.Controls.Add(telefonoCelularLabel);
            this.groupBox1.Controls.Add(tipoIdLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 327);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de usuarios";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // celularMaskedTextBox
            // 
            this.celularMaskedTextBox.Location = new System.Drawing.Point(109, 209);
            this.celularMaskedTextBox.Mask = "(999) 000-0000";
            this.celularMaskedTextBox.Name = "celularMaskedTextBox";
            this.celularMaskedTextBox.Size = new System.Drawing.Size(201, 20);
            this.celularMaskedTextBox.TabIndex = 41;
            // 
            // casaMaskedTextBox
            // 
            this.casaMaskedTextBox.Location = new System.Drawing.Point(108, 183);
            this.casaMaskedTextBox.Mask = "(999) 000-0000";
            this.casaMaskedTextBox.Name = "casaMaskedTextBox";
            this.casaMaskedTextBox.Size = new System.Drawing.Size(201, 20);
            this.casaMaskedTextBox.TabIndex = 40;
            // 
            // ConfirmartextBox
            // 
            this.ConfirmartextBox.Location = new System.Drawing.Point(108, 128);
            this.ConfirmartextBox.Name = "ConfirmartextBox";
            this.ConfirmartextBox.PasswordChar = '*';
            this.ConfirmartextBox.Size = new System.Drawing.Size(200, 20);
            this.ConfirmartextBox.TabIndex = 38;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinal.Properties.Resources.sign_up_256;
            this.pictureBox1.Location = new System.Drawing.Point(314, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // TipocomboBox
            // 
            this.TipocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipocomboBox.FormattingEnabled = true;
            this.TipocomboBox.Location = new System.Drawing.Point(109, 235);
            this.TipocomboBox.Name = "TipocomboBox";
            this.TipocomboBox.Size = new System.Drawing.Size(200, 21);
            this.TipocomboBox.TabIndex = 36;
            // 
            // ModificarButton
            // 
            this.ModificarButton.Image = global::ProyectoFinal.Properties.Resources.escritor;
            this.ModificarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ModificarButton.Location = new System.Drawing.Point(207, 262);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(84, 40);
            this.ModificarButton.TabIndex = 35;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ModificarButton.UseVisualStyleBackColor = true;
            this.ModificarButton.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = global::ProyectoFinal.Properties.Resources.usuario;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(109, 262);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(80, 40);
            this.EliminarButton.TabIndex = 34;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = global::ProyectoFinal.Properties.Resources.guardar;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(11, 262);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(82, 40);
            this.GuardarButton.TabIndex = 33;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = global::ProyectoFinal.Properties.Resources.busqueda;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(314, 12);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(85, 35);
            this.BuscarButton.TabIndex = 18;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // usuarioIdTextBox
            // 
            this.usuarioIdTextBox.Location = new System.Drawing.Point(108, 26);
            this.usuarioIdTextBox.Name = "usuarioIdTextBox";
            this.usuarioIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.usuarioIdTextBox.TabIndex = 18;
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.Location = new System.Drawing.Point(108, 52);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombresTextBox.TabIndex = 20;
            // 
            // nombreUsuarioTextBox
            // 
            this.nombreUsuarioTextBox.Location = new System.Drawing.Point(108, 78);
            this.nombreUsuarioTextBox.Name = "nombreUsuarioTextBox";
            this.nombreUsuarioTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreUsuarioTextBox.TabIndex = 22;
            // 
            // fechaNacimientoDateTimePicker
            // 
            this.fechaNacimientoDateTimePicker.Location = new System.Drawing.Point(108, 154);
            this.fechaNacimientoDateTimePicker.Name = "fechaNacimientoDateTimePicker";
            this.fechaNacimientoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaNacimientoDateTimePicker.TabIndex = 24;
            // 
            // claveTextBox
            // 
            this.claveTextBox.Location = new System.Drawing.Point(108, 102);
            this.claveTextBox.Name = "claveTextBox";
            this.claveTextBox.PasswordChar = '*';
            this.claveTextBox.Size = new System.Drawing.Size(200, 20);
            this.claveTextBox.TabIndex = 26;
            // 
            // IderrorProvider
            // 
            this.IderrorProvider.ContainerControl = this;
            // 
            // NombreerrorProvider
            // 
            this.NombreerrorProvider.ContainerControl = this;
            // 
            // nombreUsuarioerrorProvider
            // 
            this.nombreUsuarioerrorProvider.ContainerControl = this;
            // 
            // ClaveerrorProvider
            // 
            this.ClaveerrorProvider.ContainerControl = this;
            // 
            // TelefonoerrorProvider
            // 
            this.TelefonoerrorProvider.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RegistroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 351);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistroUsuarios";
            this.Text = "RegistroUsuarios";
            this.Load += new System.EventHandler(this.RegistroUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.farmaciaDbDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IderrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombreUsuarioerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClaveerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelefonoerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FarmaciaDbDataSet farmaciaDbDataSet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.TextBox usuarioIdTextBox;
        private System.Windows.Forms.TextBox nombresTextBox;
        private System.Windows.Forms.TextBox nombreUsuarioTextBox;
        private System.Windows.Forms.DateTimePicker fechaNacimientoDateTimePicker;
        private System.Windows.Forms.TextBox claveTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox TipocomboBox;
        private System.Windows.Forms.TextBox ConfirmartextBox;
        private System.Windows.Forms.MaskedTextBox celularMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox casaMaskedTextBox;
        private System.Windows.Forms.ErrorProvider IderrorProvider;
        private System.Windows.Forms.ErrorProvider NombreerrorProvider;
        private System.Windows.Forms.ErrorProvider nombreUsuarioerrorProvider;
        private System.Windows.Forms.ErrorProvider ClaveerrorProvider;
        private System.Windows.Forms.ErrorProvider TelefonoerrorProvider;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}