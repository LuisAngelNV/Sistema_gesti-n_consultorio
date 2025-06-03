using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaConsultorio.Models
{
    internal class Doctor : Persona
    {
        public Especialidad especialidadMedica;
        public Doctor(string nombre, int edad, string telefono, string direccion, Genero genero, GrupoSanguineo grupoSanguineo, string seguroMedico, Especialidad _especialidadMedica)
            : base(nombre, edad, telefono, direccion, genero, grupoSanguineo, seguroMedico)
        {
            especialidadMedica = _especialidadMedica;
        }
    }
}
