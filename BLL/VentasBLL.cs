﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;
using System.Data.Entity;

namespace BLL
{
    public class VentasBLL
    {
        public static bool Insertar (Ventas venta)
        {
            bool retorno = false;
            try
            {
                using (var db = new FarmaciaDb())
                {
                    var v = db.Venta.Add(venta);

                    foreach (var med in venta.Medicina)
                    {
                        db.Entry(med).State = EntityState.Unchanged;
                    }

                    db.SaveChanges();
                    retorno = true;
                }
            }catch(Exception)
            {
                throw;
            }

            return retorno;
        }
        


        public static Ventas Buscar(int id)
        {
            using (var db = new FarmaciaDb())
            {
                Ventas venta = db.Venta.Find(id);
                if (venta != null)
                {
                    venta.Medicina.Count();
                }
                return venta;

            }

        }

        public static void Eliminar(int id)
        {
            using (var db = new FarmaciaDb())
            {
                var venta = (from v in db.Venta
                                where id == v.VentaId
                                select v).FirstOrDefault();

                db.Venta.Remove(venta);

                var detalle = (from d in db.VentaDetalle
                               where id == d.Id
                               select d).FirstOrDefault();

                db.VentaDetalle.Remove(detalle);

                db.SaveChanges();
            }

        }

        public static void Modificar(int id, Ventas venta)
        {
            using (var db = new FarmaciaDb())
            {
                Ventas v = db.Venta.Find(id);

                v.FechaVenta = venta.FechaVenta;
                v.SubTotal = venta.SubTotal;
                v.Total = venta.Total;
                v.Medicina = venta.Medicina;

                db.SaveChanges();                
            }
        }


        public static List<Ventas>GetLista()
        {
            var lista = new List<Ventas>();
            var db = new FarmaciaDb();

            lista = db.Venta.ToList();
            return lista;
        }

        public static List<Ventas>GetLista(int id)
        {
            var lista = new List<Ventas>();
            var db = new FarmaciaDb();

            lista = db.Venta.Where(v => v.VentaId == id).ToList();

            return lista;
        }

        public static List<Ventas>GetLista(DateTime desde, DateTime hasta)
        {
            var lista = new List<Ventas>();
            var db = new FarmaciaDb();

            lista = db.Venta.Where(v => v.FechaVenta >= desde && v.FechaVenta <= hasta).ToList();

            return lista;
        }

        public static List<Ventas>GetListaTipo(int tipo)
        {
            var lista = new List<Ventas>();
            var db = new FarmaciaDb();

            lista = db.Venta.Where(v => v.TipoVentaId == tipo).ToList();

            return lista;
        }

        

    }
}
