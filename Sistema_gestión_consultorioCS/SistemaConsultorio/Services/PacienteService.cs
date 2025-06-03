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

        public void ListaPacientes()
        {
            foreach (var paciente in pacientes)
            {
                Console.WriteLine($"Nombre: {paciente.nombre}, Edad: {paciente.ed}");
            }
        }

        public void EditarPaciente(string nombre)
        {
        }

        public void EliminarPaciente(string nombre) { }
    }
}
