using SistemaConsultorio.Services;
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
            PacienteService pacienteService = new PacienteService();
            Console.WriteLine("Sistema de Gestión del Consultorio");
            Console.WriteLine("Seleccione una opición: ");
            Console.WriteLine("1. Registrar paciente");
            Console.WriteLine("2. Agendar cita");
            Console.WriteLine("3. Consultar citas");
            Console.WriteLine("4. Mostrar pacientes");
            Console.WriteLine("5. Salir");
            int r = Convert.ToInt32(Console.ReadLine());

            switch (r) { 
            case 0: pacienteService.AgregarPaciente(); break; 
            case 1: Console.WriteLine(); break; 
            case 2: Console.WriteLine(); break; 
            case 3: Console.WriteLine(); break; 
            case 4: Console.WriteLine(); break; 
            }

        }
    }
}
