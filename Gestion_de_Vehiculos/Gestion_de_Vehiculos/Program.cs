using System.Reflection;
using System.Text.RegularExpressions;

namespace Gestion_de_Vehiculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehiculo> listaVehiculos = new List<Vehiculo>();

            // lista vehículos
            listaVehiculos.Add(new Auto(1, "ford", "meriva", 2012, 4));
            listaVehiculos.Add(new Moto(2, "yamaha", "no_se", 2012, 250));
            listaVehiculos.Add(new Camion(3, "mercedes", "no_se", 2012, 30000));

            Console.WriteLine("vehiculos registrados:");

            foreach (Vehiculo v in listaVehiculos)
            {
                v.mostrar();
                Console.WriteLine();
            }

            // Se agrega nuevo vehículo
            AgregarVehiculo(new Auto(4, "Fiat", "Palio", 2015, 5));

            Console.WriteLine("vehiculos registrados despúes de agregar:");

            foreach (Vehiculo v in listaVehiculos)
            {
                v.mostrar();
                Console.WriteLine();
            }

            // Se modifica 1 vehículo x ID
            ModificarVehiculo(1, "chevrolet", "meriva", 2012);

            Console.WriteLine("vehiculos registrados despúes de modificar:");

            foreach (Vehiculo v in listaVehiculos)
            {
                v.mostrar();
                Console.WriteLine();
            }

            // Se elimina 1 vehículo x ID
            EliminarVehiculo(4);

            Console.WriteLine("vehiculos registrados despúes de eliminar:");

            foreach (Vehiculo v in listaVehiculos)
            {
                v.mostrar();
                Console.WriteLine();
            }


            // Creación de métodos
            void AgregarVehiculo(Vehiculo vehiculo)
            {
                listaVehiculos.Add(vehiculo);
            }

            void ModificarVehiculo(int id, string marca, string modelo, int anio)
            {
                foreach (Vehiculo v in listaVehiculos)
                {
                    if(v.Id == id) //acá se usa getter de ID, comparo ID con id
                    {
                        v.Marca = marca; //acá se usa setter de marca y de c/u para asignar
                        v.Modelo = modelo;
                        v.Anio = anio;
                    }
                }
            }

            void EliminarVehiculo(int id)
            {
                Vehiculo vehiculoAEliminar = null;

                foreach (Vehiculo v in listaVehiculos)
                {
                    if (v.Id == id) //acá se usa getter de ID
                    {
                        vehiculoAEliminar = v;
                    }
                }

                listaVehiculos.Remove(vehiculoAEliminar);
            }
        }
    }
}
        