using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Vehiculos
{
    internal class Vehiculo
    {
        protected int id;
        protected string marca;
        protected string modelo;
        protected int anio;

        public Vehiculo() { }

        public Vehiculo(int id, string marca, string modelo, int anio)
        {
            this.id = id;
            this.marca = marca;
            this.modelo = modelo;
            this.anio = anio;
        }

        // Getter y Setter para cada atributo
        public int Id
        {
            get => id;          // Getter → permite leer el valor
            set => id = value;         // Setter → permite asignar un valor
        }

        public string Marca
        {
            get => marca; 
            set => marca = value; 
        }

        public string Modelo
        {
            get => modelo;
            set => modelo = value;
        }

        public int Anio
        {
            get => anio;
            set => anio = value;
        }

        public virtual void mostrar()
        {
            Console.WriteLine("vehiculo id: " + id + " marca: " + marca + " modelo: " + modelo + " anio: " + anio);
        }
    }
}