using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaConsultorio.Menu
{
    internal class MenuPrincipal
    {
        public void MenuDeOpciones()
        {
            Console.WriteLine("Sistema de Gestión del Consultorio");
            Console.WriteLine("1. Registrar paciente");
            Console.WriteLine("2. Agendar cita");
            Console.WriteLine("3. Consultar citas");
            Console.WriteLine("4. Mostrar pacientes");
            Console.WriteLine("5. Salir");

        }
    }
}
