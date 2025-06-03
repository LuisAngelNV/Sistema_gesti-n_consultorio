using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaConsultorio.Models
{
    internal class Cita
    {
        public DateTime Fecha { get; set; }
        public string Motivo { get; set; }
        public string Medico { get; set; }
        public Cita(DateTime fecha, string motivo, string medico)
        {
            Fecha = fecha;
            Motivo = motivo;
            Medico = medico;
        }

    }
}
