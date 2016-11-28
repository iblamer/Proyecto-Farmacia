using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class TipoUsuarios
    {
        [Key]
        public int TipoId { get; set; }
        public string Descripcion { get; set; }
    }
}
