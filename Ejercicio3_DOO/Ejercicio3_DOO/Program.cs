namespace Ejercicio3_DOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3 objetos de Persona con distintos constructores:
            Persona p1 = new Persona(); // constructor vacío, string vacío (null) y edad 0 por default
            Persona p2 = new Persona("María", 25); // constructor con nombre y edad
            Persona p3 = new Persona("Carlos", 30, "12345678"); // constructor con nombre, edad y DNI

            // Mostrar información:
            Console.WriteLine("= Info de P1 con constructor vacío =");
            p1.MostrarInformacion();
            Console.WriteLine();
            Console.WriteLine("= Info de P2 con constructor con 2 parámetros =");
            p2.MostrarInformacion();
            Console.WriteLine();
            Console.WriteLine("= Info de P3 con constructor con todos los parámetros =");
            p3.MostrarInformacion();
        }
    }

    //Clase padre:
    class Persona
    {
        // Atributos:
        public string Nombre;
        private int Edad;
        public string DNI;

        // Constructor vacío:
        public Persona() { }

        // Constructor con nombre y edad:
        public Persona(string nombre, int edad)
        {
            this.Nombre = nombre;
            this.Edad = edad;
        }

        // Constructor con nombre, edad y DNI:
        public Persona(string nombre, int edad, string dni)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.DNI = dni;
        }

        // Método:
        public void MostrarInformacion()
        {
            Console.WriteLine("Nombre: " + this.Nombre + ", Edad: " + this.Edad + ", DNI: " + this.DNI);
        }
    }
}
