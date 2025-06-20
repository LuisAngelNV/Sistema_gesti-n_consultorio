using SistemaConsultorio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaConsultorio.Services
{
    internal class PacienteService
    {
        private List<Paciente> pacientes = new List<Paciente>();

        public void AgregarPaciente(Paciente nuevoPaciente)
        {
            pacientes.Add(nuevoPaciente);
        }

        public List<Paciente> ListaPacientes()
        {
            return pacientes;
        }

        public void EditarPaciente(string nombre)
        {
        }

        public void EliminarPaciente(string nombre) { }
    }
}
