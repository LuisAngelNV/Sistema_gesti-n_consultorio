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
        private List<Cita> citas = new List<Cita>();
        public void AgendarCita(Cita cita)
        {
            citas.Add(cita);
            Console.WriteLine("✅ Cita agendada correctamente.");
        }

        public List<Cita> ObtenerCitas()
        {
            return citas;
        }

    }
}
