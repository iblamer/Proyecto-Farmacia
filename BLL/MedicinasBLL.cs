using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Entidades;

namespace BLL
{
    public class MedicinasBLL
    {
        public static bool Insertar(Medicinas med)
        {
            bool retorno = false;

            try
            {
                using (var db = new FarmaciaDb())
                {
                    db.Medicina.Add(med);
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

        public static Medicinas Buscar(int id)
        {
            using (var db = new FarmaciaDb())
            {
                return db.Medicina.Find(id);
            }

        }

        public static void Eliminar(int id)
        {
            using (var db = new FarmaciaDb())
            {
                var med = new Medicinas();
                med = db.Medicina.Find(id);

                db.Medicina.Remove(med);
                db.SaveChanges();
            }
        }

        public static void Modificar(int id, Medicinas medicina)
        {
            using (var db = new FarmaciaDb())
            {
                Medicinas med = db.Medicina.Find(id);

                med.Nombre = medicina.Nombre;
                med.Descripcion = medicina.Descripcion;
                med.Especificaciones = medicina.Especificaciones;
                med.LaboratorioId = medicina.LaboratorioId;
                med.PrecioCompra = medicina.PrecioCompra;
                med.PrecioVenta = medicina.PrecioVenta;
                med.FechaVencimiento = medicina.FechaVencimiento;
                med.CategoriaId = medicina.CategoriaId;
                med.CantidadExistencia = medicina.CantidadExistencia;

                db.SaveChanges();

            }
        }

        public static List<Medicinas> GetLista()
        {
            var lista = new List<Medicinas>();

            var db = new FarmaciaDb();

            lista = db.Medicina.ToList();

            return lista;
        }

        public static List<Medicinas>GetLista(int id)
        {
            var lista = new List<Medicinas>();

            var db = new FarmaciaDb();

            lista = db.Medicina.Where(m => m.MedicinaId == id).ToList();

            return lista;
        }

        public static List<Medicinas>GetLista(string nombre)
        {
            var lista = new List<Medicinas>();

            var db = new FarmaciaDb();

            lista = db.Medicina.Where(m => m.Nombre == nombre).ToList();

            return lista;
        }

        public static List <Medicinas> GetLista(DateTime desde, DateTime hasta)
        {
            var lista = new List<Medicinas>();

            var db = new FarmaciaDb();

            lista = db.Medicina.Where(m => m.FechaVencimiento >= desde && m.FechaVencimiento <= hasta).ToList();

            return lista;
        }

        public static List<Medicinas> GetListaLaboratorio(int laboratorioId)
        {
            var lista = new List<Medicinas>();

            var db = new FarmaciaDb();

            lista = db.Medicina.Where(m => m.LaboratorioId == laboratorioId).ToList();

            return lista;
        }

        public static List<Medicinas> GetListaCategoria(int categoriaId)
        {
            var lista = new List<Medicinas>();

            var db = new FarmaciaDb();

            lista = db.Medicina.Where(m => m.CategoriaId == categoriaId).ToList();

            return lista; 
        }

    }
}
