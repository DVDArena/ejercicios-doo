using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Vehiculos
{
    internal class Camion: Vehiculo
    {
        protected int capacidadCarga;

        public Camion() { }

        public Camion(int id, string marca, string modelo, int anio, int capacidadCarga)
            : base(id, marca, modelo, anio)
        {
            this.capacidadCarga = capacidadCarga;
        }

        // Getter y Setter para cada atributo
        public int CapacidadCarga
        {
            get => capacidadCarga;          // Getter → permite leer el valor
            set => capacidadCarga = value;         // Setter → permite asignar un valor
        }

        public override void mostrar()
        {
            base.mostrar();
            Console.WriteLine("capacidad de carga: " + capacidadCarga + " kg");
        }
    }
}
