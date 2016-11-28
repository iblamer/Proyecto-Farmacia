using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;

namespace BLL
{
    public class CategoriasBLL
    {
        public static List<Categorias> GetLista()
        {
            var lista = new List<Categorias>();
            var db = new FarmaciaDb();

            lista = db.Categoria.ToList();

            return lista;
        }
    }
}
