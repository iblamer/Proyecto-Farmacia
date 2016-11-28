using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Entidades;

namespace BLL
{
    public class LaboratoriosBLL
    {
        public static bool Insertar(Laboratorios laboratorio)
        {
            bool retorno = false;

            try
            {
                using (var db = new FarmaciaDb())
                {
                    db.Laboratorio.Add(laboratorio);
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

        public static Laboratorios Buscar(int id)
        {
            var db = new FarmaciaDb();

            return db.Laboratorio.Find(id);
        }

        public static void Eliminar(int id)
        {
            using (var db = new FarmaciaDb())
            {
                var laboratorio = new Laboratorios();

                db.Laboratorio.Find(id);

                db.Laboratorio.Remove(laboratorio);
                db.SaveChanges();
            }
        }

        public static void Modificar(int id, Laboratorios laboratorio)
        {
            using (var db = new FarmaciaDb())
            {
                var lab = new Laboratorios();

                lab.Nombre = laboratorio.Nombre;
            }
        }

        public static List<Laboratorios>GetLista()
        {
            var lista = new List<Laboratorios>();
            var db = new FarmaciaDb();

            lista = db.Laboratorio.ToList();

            return lista;

        }

        public static List<Laboratorios>GetLista(int id)
        {
            var lista = new List<Laboratorios>();
            var db = new FarmaciaDb();

            lista = db.Laboratorio.Where(l => l.LaboratorioId == id).ToList();

            return lista;

        }

        public static List<Laboratorios>GetLista(string nombre)
        {
            var lista = new List<Laboratorios>();
            var db = new FarmaciaDb();

            lista = db.Laboratorio.Where(l => l.Nombre == nombre).ToList();

            return lista;
        }

        public static List<Laboratorios>GetLista(DateTime desde, DateTime hasta)
        {
            var lista = new List<Laboratorios>();
            var db = new FarmaciaDb();

            lista = db.Laboratorio.Where(l => l.FechaIngreso >= desde && l.FechaIngreso <= hasta).ToList();


            return lista;
        }
    }
}
