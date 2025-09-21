namespace Ejercicio4_DOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear 2 objetos jugadores:
            Jugador j1 = new Jugador("Lionel Messi", 36, 15, "Delantero");
            Jugador j2 = new Jugador("Emiliano Martínez", 32, 10, "Arquero");

            // Crear 2 objetos técnicos:
            Tecnico t1 = new Tecnico("Lionel Scaloni", 45, 5, "Director Técnico");
            Tecnico t2 = new Tecnico("Pablo Aimar", 44, 3, "Asistente Técnico");

            // Mostrar información:
            Console.WriteLine("= Jugadores =");
            j1.MostrarInformacion();
            j2.MostrarInformacion();

            Console.WriteLine("\n= Técnicos =");
            t1.MostrarInformacion();
            t2.MostrarInformacion();
        }
    }

    // Clase padre:
    class Integrante
    {
        //Atributos:
        public string Nombre;
        public int Edad;
        public int Antiguedad;

        //Constructor vacío:
        public Integrante() { }

        //Constructor con parámetros:
        public Integrante(string nombre, int edad, int antiguedad)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Antiguedad = antiguedad;
        }

        // Método virtual para sobrescribir en las clases hijas:
        public virtual void MostrarInformacion()
        {
            Console.WriteLine("Nombre: " + this.Nombre + ", Edad: " + this.Edad + ", Antigüedad: " + this.Antiguedad + " años");
        }
    }

    // Clase hija Jugador:
    class Jugador : Integrante
    {
        //Atributo:
        public string Posicion;

        //Constructor vacío:
        public Jugador() { }

        //Constructor con parámetros:
        public Jugador(string nombre, int edad, int antiguedad, string posicion)
            : base(nombre, edad, antiguedad)
        {
            this.Posicion = posicion;
        }

        // Sobrescribir método para agregar la posición:
        public override void MostrarInformacion()
        {
            Console.WriteLine("Nombre: " + this.Nombre + ", Edad: " + this.Edad + ", Antigüedad: " + this.Antiguedad + " años, Posición: " + this.Posicion);
        }
    }

    // Clase hija Tecnico:
    class Tecnico : Integrante
    {

        //Atributo:
        public string Especialidad;

        //Constructor vacio:
        public Tecnico() { }

        //Constructor con parámetros:
        public Tecnico(string nombre, int edad, int antiguedad, string especialidad)
            : base(nombre, edad, antiguedad)
        {
            this.Especialidad = especialidad;
        }

        // Sobrescribir método para agregar la especialidad:
        public override void MostrarInformacion()
        {
            Console.WriteLine("Nombre: " + this.Nombre + ", Edad: " + this.Edad + ", Antigüedad: " + this.Antiguedad + " años, Especialidad: " + this.Especialidad);
        }
    }
}