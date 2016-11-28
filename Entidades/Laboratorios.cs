using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Laboratorios
    {
        [Key]
        public int LaboratorioId { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaIngreso { get; set; }
       
    }
}
