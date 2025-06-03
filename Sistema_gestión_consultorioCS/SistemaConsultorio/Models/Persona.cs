using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SistemaConsultorio.Models
{
    internal class Persona
    {
        public int Id { get; set; }
        public enum Genero { Masculino, Femenino, Otro }
        public enum GrupoSanguineo { A, B, AB, O }
        private string Nombre;
        private int Edad { get; set; }
        private string Telefono { get; set; }
        private string Direccion { get; set; }
        private Genero genero { get; set; }
        private GrupoSanguineo grupoSanguineo { get; set; }
        private string SeguroMedico { get; set; }

        public Persona(string nombre, int edad, string telefono, string direccion, Genero genero, GrupoSanguineo grupoSanguineo, string seguroMedico)
        {
            Nombre = nombre;
            Edad = edad;
            Telefono = telefono;
            Direccion = direccion;
            this.genero = genero;
            this.grupoSanguineo = grupoSanguineo;
            SeguroMedico = seguroMedico;
        }

        public string nombre
        {
            get { return Nombre; }
            set
            {
                if (string.IsNullOrEmpty(Nombre))
                {
                    Console.WriteLine("El campo no puede estar vacio");
                }
                else if (Nombre.Length <= 1)
                {
                    {
                        Console.WriteLine("El nombre no es valido");
                    }
                }
            }
        }
        public string telefon
        {
            get { return telefon; }

            set
            {
                if (string.IsNullOrEmpty(telefon))
                {
                    Console.WriteLine("Se necesita un número de celular para contactar al usuario");
                }else if(telefon.Length <= 7)
                {
                    Console.WriteLine("Verificar que es un número valido");
                }
            }
        }

        public int edad
        {
            get { return Edad; }
            set
            {
                if (string.IsNullOrEmpty(Convert.ToString(Edad)))
                {
                    Console.WriteLine("No se puede dejar vacio el campo");
                }
            }
        }
    }
}
