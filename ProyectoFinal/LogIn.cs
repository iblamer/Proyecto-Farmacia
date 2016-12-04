using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using DAL;
using Entidades;

namespace ProyectoFinal
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        Inicio inicio = new Inicio();

        private void button1_Click(object sender, EventArgs e)
        {
            if(Sesion()== DialogResult.OK)
            {
                this.Visible = false;

                inicio.Show();
            }
        }

        private bool ValidarContrasena()
        {
            if(UsuariosBLL.GetListaContrasena(ContrasenatextBox.Text).Count() == 0)
            {
                MessageBox.Show("Contrasena incorrecta");
                return false;
            }

            return true;
        }

        private bool ValidarUsuario()
        {
            if(UsuariosBLL.GetLista(NombretextBox.Text).Count == 0)
            {
                MessageBox.Show("El usuario no existe");
                return false;
            }
            return true;
        }

        private DialogResult Sesion()
        {
            if(ValidarContrasena() == true && ValidarUsuario() == true)
            {
                return DialogResult.OK;
            }

            return DialogResult.Cancel;
        }
    }
}
