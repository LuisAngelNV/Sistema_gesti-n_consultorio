using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaConsultorio.Models
{
    internal class Persona
    {
        public int Id { get; set; }
        public enum Genero { Masculino, Femenino, Otro }
        public enum GrupoSanguineo { A, B, AB, O }

        private string Nombre { get;  set;}
        private int Edad { get; set;}
        private string Telefono { get; set;}
        private string Direccion {  get; set; }
        private Genero genero { get; set; }
        private GrupoSanguineo grupoSanguineo { get; set; }
        private string SeguroMedico { get; set; }


        public Persona(string nombre, int edad, string telefono, string direccion, string genero, string grupoSanguineo, string seguroMedico)
        {
            Nombre = nombre;
            Edad = edad;
            Telefono = telefono;
            Direccion = direccion;
            Genero = genero;
            GrupoSanguineo = grupoSanguineo;
            SeguroMedico = seguroMedico;
        }
    }
}
