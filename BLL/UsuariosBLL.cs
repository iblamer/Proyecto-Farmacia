using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;

namespace BLL
{
    public class UsuariosBLL
    {
        public static bool Insertar (Usuarios usuario)
        {
            bool retorno = false;

            try
            {
                using (var db = new FarmaciaDb())
                {
                    db.Usuario.Add(usuario);
                    db.SaveChanges();
                    db.Dispose();
                    retorno = true;
                }
            }catch(Exception)
            {
                throw;
            }

            return retorno;
        }

        public static Usuarios Buscar (int id)
        {
            using (var db = new FarmaciaDb())
            {
                return db.Usuario.Find(id);
            }
        }

        public static void Eliminar (int id)
        {
            var db = new FarmaciaDb();

            Usuarios usuario = db.Usuario.Find(id);

            db.Usuario.Remove(usuario);
            db.SaveChanges();
            
        }

        public static void Modificar (int id, Usuarios usuario)
        {
            using (var db = new FarmaciaDb())
            {
                Usuarios user = db.Usuario.Find(id);
                user.Nombres = usuario.Nombres;
                user.NombreUsuario = usuario.NombreUsuario;
                user.FechaNacimiento = usuario.FechaNacimiento;
                user.Clave = usuario.Clave;
                user.TelefonoCasa = usuario.TelefonoCasa;
                user.TelefonoCelular = usuario.TelefonoCelular;
                user.TipoId = usuario.TipoId;
                db.SaveChanges();
            }
        }

        public static List<Usuarios>GetLista()
        {
            var lista = new List<Usuarios>();

            var db = new FarmaciaDb();

            lista = db.Usuario.ToList();

            return lista;
        }

        public static List<Usuarios>GetLista(int id)
        {
            var lista = new List<Usuarios>();
            var db = new FarmaciaDb();

            lista = db.Usuario.Where(u => u.UsuarioId == id).ToList();

            return lista;
        }

        public static List<Usuarios>GetLista(string nombre)
        {
            var lista = new List<Usuarios>();
            var db = new FarmaciaDb();

            lista = db.Usuario.Where(u => u.Nombres == nombre || u.NombreUsuario == nombre).ToList();

            return lista;
        }

        public static List<Usuarios>GetLista(DateTime desde, DateTime hasta)
        {
            var lista = new List<Usuarios>();

            var db = new FarmaciaDb();


            lista = db.Usuario.Where(u => u.FechaNacimiento >= desde && u.FechaNacimiento <= hasta).ToList();

            return lista;
        }

        public static List<Usuarios>GetListaTelefono(string telefono)
        {
            var lista = new List<Usuarios>();
            var db = new FarmaciaDb();

            lista = db.Usuario.Where(u => u.TelefonoCasa == telefono || u.TelefonoCelular == telefono).ToList();

            return lista;
        }

        public static List<Usuarios>GetListaTipo(int tipoId)
        {
            var lista = new List<Usuarios>();
            var db = new FarmaciaDb();

            lista = db.Usuario.Where(u => u.TipoId == tipoId).ToList();

            return lista;
        }

        
    }
}
