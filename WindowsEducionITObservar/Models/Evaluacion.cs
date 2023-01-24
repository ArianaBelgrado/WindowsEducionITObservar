using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducionITObservar.Models
{
    public class Evaluacion
    {
        [Key]
        public int EvaluacionId { get; set; }
        public int TipoId { get; set; }
        [ForeignKey("TipoId")]
        public int EstudianteId { get; set; }
        [ForeignKey("EstudianteId")]
        public int DetalleId { get; set; }
        [ForeignKey("DetalleId")]

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Nota { get; set; }
    }
}
