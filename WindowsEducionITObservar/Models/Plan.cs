using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducionITObservar.Models
{
    [Table("Plan")]
    public class Plan
    {
        [Key]
        public int PlanId { get; set; }
        public int CarreraId { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Nombre { get; set; }

        [ForeignKey("CarreraId")]
        public virtual Carrera carrera { get; set; }
    }
}
