using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using BLL;
using DAL;

namespace ProyectoFinal.Registros
{
    public partial class RegistroUsuarios : Form
    {
        public RegistroUsuarios()
        {
            InitializeComponent();
        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
          

        }

        private void usuariosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
          

        }

        private void RegistroUsuarios_Load(object sender, EventArgs e)
        {      
            LlenaCombo();
        }

        private bool Search()
        {
            if(UsuariosBLL.Buscar(Utilidades.StringToInt(usuarioIdTextBox.Text)) == null)
            {
                MessageBox.Show("El Id no existe");
                return false;
            }
            return true;
        }


        private void GuardarButton_Click(object sender, EventArgs e)
        {
            var usuario = new Usuarios();
            if (Validar())
            {
                LlenarClases(usuario);
                if (UsuariosBLL.GetLista(Utilidades.StringToInt(usuarioIdTextBox.Text)).Count() == 0)
                {
                    if (UsuariosBLL.Insertar(usuario) && ValidarExiste(nombreUsuarioTextBox.Text))
                    {
                        MessageBox.Show("Se guardo el usuario!");
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar el usuario");
                    }
                }
                else
                {
                    UsuariosBLL.Modificar(Utilidades.StringToInt(usuarioIdTextBox.Text), usuario);
                    MessageBox.Show("Se modifico el usuario");
                    limpiar();
                }
            }
        }

        private void LlenaCombo()
        {
            TipocomboBox.DataSource = TiposUsuariosBLL.GetLista();
            TipocomboBox.DisplayMember = "Descripcion";
            TipocomboBox.ValueMember = "TipoId";
        }



        private void LlenarClases(Usuarios usuario)
        {
            usuario.Nombres = nombresTextBox.Text;
            usuario.NombreUsuario = nombreUsuarioTextBox.Text;
            usuario.Clave = claveTextBox.Text;
            usuario.FechaNacimiento = Convert.ToDateTime(fechaNacimientoDateTimePicker.Text);
            usuario.TipoId = TipocomboBox.SelectedIndex;
            usuario.TelefonoCasa = casaMaskedTextBox.Text;
            usuario.TelefonoCelular = celularMaskedTextBox.Text;
        }

        private void Fill (Usuarios usuario)
        {
            nombresTextBox.Text = usuario.Nombres;
            nombreUsuarioTextBox.Text = usuario.NombreUsuario;
            claveTextBox.Text = usuario.Clave;
            fechaNacimientoDateTimePicker.Text = usuario.FechaNacimiento.ToString();
            casaMaskedTextBox.Text = usuario.TelefonoCasa;
            celularMaskedTextBox.Text = usuario.TelefonoCelular;
            TipocomboBox.SelectedIndex = usuario.TipoId;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if(validarId("Ingrese el id que quiere buscar") &&  Search())
            {
                Fill(UsuariosBLL.Buscar(Utilidades.StringToInt(usuarioIdTextBox.Text)));
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if(Search())
            {
                UsuariosBLL.Eliminar(Utilidades.StringToInt(usuarioIdTextBox.Text));
                MessageBox.Show("Se elimino el usuario");
                limpiar();
            }
        }

        private void limpiar()
        {
            DateTimePicker dp = new DateTimePicker();
            nombreUsuarioTextBox.Text = " ";
            nombresTextBox.Text = " ";
            claveTextBox.Text = " ";
            ConfirmartextBox.Text = " ";
            fechaNacimientoDateTimePicker.Value = dp.Value;
            TipocomboBox.SelectedIndex = 0;
            casaMaskedTextBox.Text = " ";
            celularMaskedTextBox.Text = " ";

        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
           
        }

        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void usuariosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private bool validarId(string mensaje)
        {
            if(string.IsNullOrEmpty(usuarioIdTextBox.Text))
            {
                IderrorProvider.SetError(usuarioIdTextBox, "Ingresar el id");
                MessageBox.Show(mensaje);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ValidarExiste(string nombre)
        {
            if(UsuariosBLL.GetLista(nombre).Count() > 0)
            {
                MessageBox.Show("Este usuario ya existe, intente con otro nombre de usuario");
                return false;
            }
            return true;
        }

        private bool Validar()
        {
          if(string.IsNullOrEmpty(nombresTextBox.Text) && string.IsNullOrEmpty(nombreUsuarioTextBox.Text) && string.IsNullOrEmpty(claveTextBox.Text) && string.IsNullOrEmpty(casaMaskedTextBox.Text) && string.IsNullOrEmpty(celularMaskedTextBox.Text))
           {
                NombreerrorProvider.SetError(nombresTextBox, "Ingrese el nombre");
                nombreUsuarioerrorProvider.SetError(nombreUsuarioTextBox, "Ingrese el nombre de usuario");
                ClaveerrorProvider.SetError(claveTextBox, "Ingrese la clave de el usuario");
                TelefonoerrorProvider.SetError(casaMaskedTextBox, "Ingrese un telefono");
                return false;
           }

          if(string.IsNullOrEmpty(nombreUsuarioTextBox.Text))
            {
                nombreUsuarioerrorProvider.SetError(nombreUsuarioTextBox, "Ingrese el nombre de usuario");
                return false;
            }
          if(string.IsNullOrEmpty(nombreUsuarioTextBox.Text))
            {
                NombreerrorProvider.SetError(nombresTextBox, "Ingrese su nombre");
                return false;
            }
          if(string.IsNullOrEmpty(claveTextBox.Text))
            {
                ClaveerrorProvider.SetError(claveTextBox, "Ingrese la clave");
                return false;
            }
          if(string.IsNullOrEmpty(casaMaskedTextBox.Text) || string.IsNullOrEmpty(celularMaskedTextBox.Text))
            {
                TelefonoerrorProvider.SetError(casaMaskedTextBox, "Ingrese un numero de telefono");
                return false;
            }
            
            return true;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
