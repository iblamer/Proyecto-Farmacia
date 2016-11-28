using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class VentasDetalle
    {
        [Key]
        public int Id { get; set; }
        public int VentaId { get; set; }
        public int MedicinaId { get; set; }
    }
}
