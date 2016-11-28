using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;

namespace BLL
{
    public class TipoVentasBLL
    {
        public static List<TipoVentas>GetLista()
        {
            var lista = new List<TipoVentas>();
            var db = new FarmaciaDb();

            lista = db.TipoVenta.ToList();

            return lista;
        }
    }
}
