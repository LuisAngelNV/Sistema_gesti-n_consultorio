using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaConsultorio.Models
{
    internal class Paciente : Persona
    {
        public Paciente(string nombre, int edad, string telefono, string direccion, string genero, string grupoSanguineo, string seguroMedico)
            : base(nombre, edad, telefono, direccion, genero, grupoSanguineo, seguroMedico)
        {

        }
    }
}
