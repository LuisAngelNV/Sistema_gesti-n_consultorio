using SistemaConsultorio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaConsultorio.Services
{
    public class DoctorService
    {
        private List<Doctor> doctores = new List<Doctor>();

        public DoctorService()
        {
            // Puedes poblar algunos doctores por defecto
            doctores.Add(new Doctor("Dra. Ana Ruiz", 40, "555-1234", "Av. Central", Persona.Genero.Femenino, Persona.GrupoSanguineo.A, "IMSS", Especialidad.Pediatria));
            doctores.Add(new Doctor("Dr. Juan Pérez", 45, "555-5678", "Calle Norte", Persona.Genero.Masculino, Persona.GrupoSanguineo.O, "Particular", Especialidad.MedicinaGeneral));
        }

        public List<Doctor> ObtenerDoctores()
        {
            return doctores;
        }
    }
}
