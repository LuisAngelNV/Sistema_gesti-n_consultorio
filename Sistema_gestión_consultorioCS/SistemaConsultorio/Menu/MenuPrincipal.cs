using SistemaConsultorio.Models;
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
        PacienteService pacienteService = new PacienteService();
        DoctorService doctorService = new DoctorService();
        CitaService citaService = new CitaService();

        public void MenuDeOpciones()
        {
            int Seguir = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Sistema de Gestión del Consultorio");
                Console.WriteLine("Seleccione una opición: ");
                Console.WriteLine("1. Registrar paciente");
                Console.WriteLine("2. Agendar cita");
                Console.WriteLine("3. Consultar citas");
                Console.WriteLine("4. Mostrar pacientes");
                Console.WriteLine("5. Salir");
                int r = Convert.ToInt32(Console.ReadLine());



                switch (r)
                {
                    case 1:
                        Console.WriteLine("Nombre:");
                        string nombre = Console.ReadLine();

                        Console.WriteLine("Edad:");
                        int edad = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Teléfono:");
                        string telefono = Console.ReadLine();

                        Console.WriteLine("Dirección:");
                        string direccion = Console.ReadLine();

                        Console.WriteLine("Género (0 = Masculino, 1 = Femenino, 2 = Otro):");
                        var genero = (Persona.Genero)Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Grupo sanguíneo (0 = A, 1 = B, 2 = AB, 3 = O):");
                        var grupo = (Persona.GrupoSanguineo)Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Seguro médico:");
                        string seguro = Console.ReadLine();

                        Paciente nuevoPaciente = new Paciente(nombre, edad, telefono, direccion, genero, grupo, seguro);
                        pacienteService.AgregarPaciente(nuevoPaciente);

                        Console.WriteLine("Paciente agregado con éxito.");
                        break;
                    case 2:
                        var pacientesDisponibles = pacienteService.ListaPacientes();
                        var doctoresDisponibles = doctorService.ObtenerDoctores();

                        if (pacientesDisponibles.Count == 0 || doctoresDisponibles.Count == 0)
                        {
                            Console.WriteLine("No hay pacientes o doctores registrados.");
                            break;
                        }

                        Console.WriteLine("Seleccione el paciente por número:");
                        for (int i = 0; i < pacientesDisponibles.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {pacientesDisponibles[i].Nombre}");
                        }
                        int indicePaciente = Convert.ToInt32(Console.ReadLine()) - 1;

                        Console.WriteLine("Seleccione el doctor por número:");
                        for (int i = 0; i < doctoresDisponibles.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {doctoresDisponibles[i].Nombre} - {doctoresDisponibles[i].especialidadMedica}");
                        }
                        int indiceDoctor = Convert.ToInt32(Console.ReadLine()) - 1;

                        Console.WriteLine("Motivo de la cita:");
                        string motivo = Console.ReadLine();

                        Console.WriteLine("Fecha y hora de la cita (formato: yyyy-MM-dd HH:mm):");
                        DateTime fecha = DateTime.Parse(Console.ReadLine());

                        Cita nuevaCita = new Cita(fecha, motivo, doctoresDisponibles[indiceDoctor], pacientesDisponibles[indicePaciente]);
                        citaService.AgendarCita(nuevaCita);

                        break;
                    case 3:
                        var ConsultasCitas =  citaService.ObtenerCitas();
                        if (ConsultasCitas.Count == 0)
                        {
                            Console.WriteLine("No cuenta con citas registradas");
                        }
                        else
                        {
                            Console.WriteLine("Laa Citas que se tiene hasta el momento son: ");
                            foreach (Cita citas in ConsultasCitas)
                            {
                                var paciente = citas.PacienteAsignado;
                                Console.WriteLine($"Paciente: {paciente.Nombre}, Edad: {paciente.Edad}, Tel: {paciente.Telefono}, Seguro: {paciente.SeguroMedico}");
                                Console.WriteLine($"Doctor: {citas.DoctorAsignado.Nombre} - {citas.DoctorAsignado.especialidadMedica}");
                                Console.WriteLine($"Motivo: {citas.Motivo}");
                                Console.WriteLine($"Fecha: {citas.Fecha}");
                                Console.WriteLine("-------------");
                            }


                        }
                        break;
                    case 4:
                        var pacientes = pacienteService.ListaPacientes();
                        if (pacientes == null || pacientes.Count == 0)
                        {
                            Console.WriteLine("No hay pacientes registrados.");
                        }
                        else
                        {
                            foreach (var p in pacientes)
                            {
                                Console.WriteLine($"Nombre: {p.Nombre}, Edad: {p.Edad}, Teléfono: {p.Telefono}, Seguro: {p.SeguroMedico}");
                            }
                        }
                        break;
                    case 5:
                        Seguir = r;
                        break;
                    default:
                        Console.WriteLine("No se localizo la opción seleccionada");
                        break;
                }
            } while (Seguir < 5);
            Console.WriteLine("Adios");
        }
    }
}
