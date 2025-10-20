using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Vehiculos
{
    internal class Auto: Vehiculo
    {
        protected int cantidadPuertas;

        public Auto() { }

        public Auto(int id, string marca, string modelo, int anio, int cantidadPuertas)
            : base(id, marca, modelo, anio)
        {
            this.cantidadPuertas = cantidadPuertas;
        }

        // Getter y Setter para cada atributo
        public int CantidadPuertas
        {
            get => cantidadPuertas;          // Getter → permite leer el valor
            set => cantidadPuertas = value;         // Setter → permite asignar un valor
        }

        public override void mostrar()
        {
            base.mostrar();
            Console.WriteLine("cantidad de puertas: " + cantidadPuertas);
        }
    }
}
    
