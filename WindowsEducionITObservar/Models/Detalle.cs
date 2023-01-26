using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducionITObservar.Models
{
    [Table("Detalle")]
    public class Detalle
    {
        [Key]
        public int DetalleId { get; set; }
        public int PlanillaId { get; set; }
        [ForeignKey("PlanillaId")]
        public int EstadoId { get; set; }
        [ForeignKey("EstadoId")]
        public List<Estado> estados{ get; set;}

        public List<Planilla> planillas { get; set; }

    }
}
