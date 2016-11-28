using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
     public class  Ventas
    {
        [Key]
        public int VentaId { get; set; }
        public DateTime FechaVenta { get; set; }
        public double Total { get; set; }
        public double SubTotal { get; set; }
        public const double ITBIS = 1.18;
        public int TipoVentaId { get; set; }
        public int MedicinaId { set; get; }
        public virtual List<Medicinas> Medicina { get; set; }

        public Ventas()
        {
            this.Medicina = new List<Medicinas>();
        }

      
    }
}
