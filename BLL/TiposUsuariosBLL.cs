using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;

namespace BLL
{
    public class TiposUsuariosBLL
    {
        public static List<TipoUsuarios> GetLista()
        {
            var lista = new List<TipoUsuarios>();

            var db = new FarmaciaDb();

            lista = db.TipoUsuario.ToList();

            return lista;
        }
    }
}
