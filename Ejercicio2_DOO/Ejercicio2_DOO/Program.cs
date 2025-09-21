namespace Ejercicio2_DOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehiculo[] vehiculos = new Vehiculo[3];

            vehiculos[0] = new Auto("Toyota", "Corolla", 2020, 4, true);
            vehiculos[1] = new Camioneta("Ford", "Ranger", 2019, 4, true);
            vehiculos[2] = new Moto("Honda", "CB500", 2021, "Deportivo");

            foreach (Vehiculo v in vehiculos)
            {
                v.CambiarMarcha();
                v.MostrarInformacion();
                Console.WriteLine();
            }
        }
    }

    // Clase Padre:
    class Vehiculo
    {
        // Atributos:
        public string Marca;
        public string Modelo;
        public int Anio;

        // Constructor vacío:
        public Vehiculo() { }

        // Constructor con parámetros:
        public Vehiculo(string marca, string modelo, int anio)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Anio = anio;
        }

        // Métodos:
        public void CambiarMarcha()
        {
            Console.WriteLine("Cambio de marcha realizado.");
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine("Marca: " + this.Marca + ", Modelo: " + this.Modelo + ", Año: " + this.Anio);
        }
    }

    // Clase hija:
    class Auto : Vehiculo
    {
        // Atributos:
        public int CantidadPuertas;
        public bool EsAutomatico;

        // Constructor vacío:
        public Auto() { }

        // Constructor con parámetros:
        public Auto(string marca, string modelo, int anio, int cantidadPuertas, bool esAutomatico)
            : base(marca, modelo, anio)
        {
            this.CantidadPuertas = cantidadPuertas;
            this.EsAutomatico = esAutomatico;
        }

        // Métodos:
        public override void MostrarInformacion()
        {
            base.MostrarInformacion(); //para llamar al método de la clase padre
            Console.WriteLine("Puertas: " + this.CantidadPuertas + ", Automático: " + this.EsAutomatico);
        }
    }

    // Clase hija:
    class Camioneta : Vehiculo
    {
        // Atributos:
        public int CantidadPuertas;
        public bool Es4x4;

        // Constructor vacío:
        public Camioneta() { }

        // Constructor con parámetros:
        public Camioneta(string marca, string modelo, int anio, int cantidadPuertas, bool es4x4)
            : base(marca, modelo, anio)
        {
            this.CantidadPuertas = cantidadPuertas;
            this.Es4x4 = es4x4;
        }

        // Métodos:
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Puertas: " + this.CantidadPuertas + ", 4x4: " + this.Es4x4);
        }
    }

    // Clase hija
    class Moto : Vehiculo
    {
        // Atributos:
        public string TipoManubrio;

        // Constructor vacío:
        public Moto() { }

        // Constructor con parámetros:
        public Moto(string marca, string modelo, int anio, string tipoManubrio)
            : base(marca, modelo, anio)
        {
            this.TipoManubrio = tipoManubrio;
        }

        // Métodos:
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Tipo de manubrio: " + this.TipoManubrio);
        }
    }
}
