using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducionITObservar.Models
{
    public class Planilla
    {
        [Key]
        public int PlanillaId { get; set; }
        public int CarreraId { get; set; }
        [ForeignKey("CarreraId")]
        public int MateriaId { get; set; }
        [ForeignKey("MateriaId")]
        public int ProfesorId { get; set; }
        [ForeignKey("ProfesorId")]
        public int CursoId { get; set; }
        [ForeignKey("CursoId")]

        public DateTime? Fecha { get; set; }
    }
}
