using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaConsultorio.Models
{
    public class Paciente : Persona
    {
        private List<Cita> HistorialCitas { get; set; } = new List<Cita>();

        public Paciente(string nombre, int edad, string telefono, string direccion, Genero genero, GrupoSanguineo grupoSanguineo, string seguroMedico)
            : base(nombre, edad, telefono, direccion, genero, grupoSanguineo, seguroMedico)
        { }

        public void AgregarCita(Cita nuevaCita)
        {
            HistorialCitas.Add(nuevaCita);
        }

        public List<Cita> ObtenerHistorialCitas()
        {
            return HistorialCitas;
        }
    }
}
