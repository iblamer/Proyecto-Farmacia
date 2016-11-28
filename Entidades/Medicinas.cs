using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Medicinas
    {
        [Key]
        public int MedicinaId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double PrecioVenta { get; set; }
        public double PrecioCompra { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int CantidadExistencia { get; set; }
        public int LaboratorioId { get; set; }
        public string Especificaciones { get; set; }
        public int CategoriaId { get; set; }
        public virtual List<Ventas> Venta { get; set; }

        public Medicinas()
        {
            this.Venta = new List<Ventas>();
        }

        public Medicinas(int id)
        {
            this.MedicinaId = id;
            this.Venta = new List<Ventas>();

        }

        public Medicinas(int id, string nombre)
        {
            
        }

        public Medicinas(int medicinaId, string nombre, string descripcion, double precioVenta, double precioCompra, DateTime fechaVencimiento, int cantidadExistencia, int laboratorioId, string especificaciones, int categoriaId)
        {
            this.MedicinaId = medicinaId;
            this.Nombre = nombre;
            this.Venta = new List<Ventas>();
            this.Descripcion = descripcion;
            this.PrecioCompra = precioCompra;
            this.PrecioVenta = precioVenta;
            this.FechaVencimiento = fechaVencimiento;
            this.CantidadExistencia = cantidadExistencia;
            this.LaboratorioId = laboratorioId;
            this.Especificaciones = especificaciones;
            this.CategoriaId = categoriaId;
        }
    }
}
