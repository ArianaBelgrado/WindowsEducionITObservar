using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducionITObservar.Models
{
    [Table("Profesor")]
    public class Profesor
    {
        [Key]
        public int ProfesorId { get; set; }
        public int LocalidadId { get; set; }
        [ForeignKey("LocalidadId")]

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Nombre { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Apellido { get; set; }

        public List<Planilla> planillas { get; set; }
        public Localidad localidad { get; set; }
    }
}
