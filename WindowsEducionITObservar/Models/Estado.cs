using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducionITObservar.Models
{
    [Table("Estado")]
    public class Estado
    {
        [Key]
        public int EstadoId { get; set; }

        [Column(TypeName =  "varchar")]
        [StringLength(50)]
        [Required]
        public string Nombre { get; set; }
        
        public Detalle detalle { get; set; }
        
    }
}
