using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducionITObservar.Models
{
    public class Detalle
    {
        [Key]
        public int DetalleId { get; set; }
        public int PlanillaId { get; set; }
        [ForeignKey("PlanillaId")]
        public int EstadoId { get; set; }
        [ForeignKey("EstadoId")]

    }
}
