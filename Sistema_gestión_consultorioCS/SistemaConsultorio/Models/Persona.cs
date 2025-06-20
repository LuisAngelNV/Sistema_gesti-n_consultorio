using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SistemaConsultorio.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public enum Genero { Masculino, Femenino, Otro }
        public enum GrupoSanguineo { A, B, AB, O }
        public string Nombre
        {
            get => nombre;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length <= 1)
                    throw new ArgumentException("El nombre no es válido.");
                nombre = value;
            }
        }
        private string nombre;
        public int Edad
        {
            get => edad;
            set 
            {
                if (edad < 0) throw new ArgumentException("No puede ser un valor negativo");   
            }
        }
        private int edad;
        public string Telefono
        {
            get => telefono;
            set
            {
                if (string.IsNullOrEmpty(telefono))
                {
                    Console.WriteLine("Se necesita un número de celular para contactar al usuario");
                }
                else if (telefono.Length <= 7)
                {
                    Console.WriteLine("Verificar que es un número valido");
                }
            }
        }
        private string telefono;
        private string Direccion { get; set; }
        private Genero genero { get; set; }
        private GrupoSanguineo grupoSanguineo { get; set; }
        public string SeguroMedico
        {
            get => seguroMedico;
            set
            {
                if (string.IsNullOrEmpty(seguroMedico))
                {
                    Console.WriteLine("");
                }
            }
        }
        private string seguroMedico { get; set; }

        public Persona(string nombre, int _edad, string telefono, string direccion, Genero genero, GrupoSanguineo grupoSanguineo, string seguroMedico)
        {
            Nombre = nombre;
            edad = _edad;
            Telefono = telefono;
            Direccion = direccion;
            this.genero = genero;
            this.grupoSanguineo = grupoSanguineo;
            SeguroMedico = seguroMedico;
        }
    }
}
