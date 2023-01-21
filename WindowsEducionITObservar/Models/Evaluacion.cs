using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducionITObservar.Models
{
    public class Evaluacion
    {
        public int EvaluacionId { get; set; }
        public int TipoId { get; set; }
        public int EstudianteId { get; set; }
        public int DetalleId { get; set; }
        public string Nota { get; set; }
    }
}
