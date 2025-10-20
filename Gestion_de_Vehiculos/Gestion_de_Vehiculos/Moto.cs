using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Vehiculos
{
    internal class Moto: Vehiculo
    {
       protected int cilindrada;

        public Moto() { }

        public Moto(int id, string marca, string modelo, int anio, int cilindrada)
            : base(id, marca, modelo, anio)
        {
            this.cilindrada = cilindrada;
        }

        // Getter y Setter para cada atributo
        public int Cilindrada
        {
            get => cilindrada;          // Getter → permite leer el valor
            set => cilindrada = value;         // Setter → permite asignar un valor
        }

        public override void mostrar()
        {
            base.mostrar();
            Console.WriteLine("cilindrada: " + cilindrada);
        }
    }
}
    
