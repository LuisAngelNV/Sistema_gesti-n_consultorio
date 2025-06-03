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
        public Doctor DoctorAsignado { get; set; }
        public Paciente PacienteAsignado { get; set; }

        public Cita(DateTime fecha, string motivo, Doctor doctor, Paciente paciente)
        {
            Fecha = fecha;
            Motivo = motivo;
            DoctorAsignado = doctor;
            PacienteAsignado = paciente;
        }
    }
}
