using SistemaConsultorio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaConsultorio.Services
{
    public class CitaService
    {
        public static void AgregarCita(Paciente paciente, Cita nuevaCita)
        {
            paciente.AgregarCita(nuevaCita);
            Console.WriteLine($"Se ha asignado una nueva cita a {paciente.nombre}");
        }
    }
}
