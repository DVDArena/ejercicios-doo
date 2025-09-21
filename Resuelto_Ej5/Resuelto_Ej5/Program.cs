namespace Resuelto_Ej5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creación de arreglo de máquinas virtuales:
            MaquinaVirtual[] maquinas = new MaquinaVirtual[4];


            // las 2 de procesamiento:
            maquinas[0] = new Procesamiento("Proc1", "v1.0", "Linux", "DB_origen1", "DB_fin1");
            maquinas[1] = new Procesamiento("Proc2", "v1.1", "Windows", "DB_origen2", "DB_fin2");

            // las 2 de aplicación:
            maquinas[2] = new Aplicacion("App1", "v2.0", "Linux", "Java", "17", "jdbc://db1");
            maquinas[3] = new Aplicacion("App2", "v2.1", "Windows", "Python", "3.12", "jdbc://db2");

            // Levantamos:
            Console.WriteLine("=== Levantando Máquinas ===");
            foreach (MaquinaVirtual m in maquinas)
            {
                Console.WriteLine("dar acceso a la base de datos?");
                string respuesta = Console.ReadLine();
                if (respuesta == "si")
                {
                    m.Levantar();
                    Console.WriteLine();
                }
                
            }

            // Bajamos:
            Console.WriteLine("=== Bajando Máquinas ===");
            foreach (MaquinaVirtual m in maquinas)
            {
                m.Bajar();
                Console.WriteLine();
            }
        }
    }

    // Clase base/padre:
    class MaquinaVirtual
    {
        //Atributos:
        public string Nombre;
        public string Version;
        public string SistemaOperativo;
        public int Estado; // 0=down, 1=up

        //Constructor vacío:
        public MaquinaVirtual() { }

        //Constructor con parámetros:
        public MaquinaVirtual(string nombre, string version, string sistemaOperativo)
        {
            this.Nombre = nombre;
            this.Version = version;
            this.SistemaOperativo = sistemaOperativo;
            this.Estado = 0; // inicia apagada
        }

        //Métodos:
        public virtual void Levantar()
        {
            this.Estado = 1;
            Console.WriteLine("Máquina " + this.Nombre + " levantada.");
        }

        public void Bajar()
        {
            this.Estado = 0;
            Console.WriteLine("Máquina " + this.Nombre + " bajada.");
        }

        public virtual void MostrarInfo()
        {
            Console.WriteLine("Nombre: " + this.Nombre +
                              ", Versión: " + this.Version +
                              ", SO: " + this.SistemaOperativo +
                              ", Estado: " + (this.Estado == 1 ? "UP" : "DOWN"));
        }
    }

    // Clase hija Procesamiento
    class Procesamiento : MaquinaVirtual
    {
        // Atributos:
        public string DatosOrigen;
        public string DatosFin;

        //Constructor vacío:
        public Procesamiento() { }

        //Constructor con parámetros:
        public Procesamiento(string nombre, string version, string sistemaOperativo,
                             string datosOrigen, string datosFin)
            : base(nombre, version, sistemaOperativo)
        {
            this.DatosOrigen = datosOrigen;
            this.DatosFin = datosFin;
        }

        //Métodos:
        public override void Levantar()
        {
            this.Estado = 1;
            Console.WriteLine("Procesamiento " + this.Nombre + " levantado correctamente.");
            Console.WriteLine("Acceso a datos de origen: " + this.DatosOrigen);
            Console.WriteLine("Acceso a datos de fin: " + this.DatosFin);
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine("Origen: " + this.DatosOrigen + ", Fin: " + this.DatosFin);
        }
    }

    // Clase hija Aplicacion
    class Aplicacion : MaquinaVirtual
    {
        
        //Atributos:
        public string Lenguaje;
        public string VersionLenguaje;
        public string BaseDatos;

        //Constructor vacío:
        public Aplicacion() { }

        //Constructor con parámetros:
        public Aplicacion(string nombre, string version, string sistemaOperativo,
                          string lenguaje, string versionLenguaje, string baseDatos)
            : base(nombre, version, sistemaOperativo)
        {
            this.Lenguaje = lenguaje;
            this.VersionLenguaje = versionLenguaje;
            this.BaseDatos = baseDatos;
        }

        //Métodos
        public override void Levantar()
        {
            this.Estado = 1;
            Console.WriteLine("Aplicación " + this.Nombre + " levantada correctamente.");
            Console.WriteLine("Lenguaje " + this.Lenguaje + " en versión " + this.VersionLenguaje + " instalado.");
            Console.WriteLine("Acceso a base de datos: " + this.BaseDatos);
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine("Lenguaje: " + this.Lenguaje +
                              ", Versión Lenguaje: " + this.VersionLenguaje +
                              ", Base de datos: " + this.BaseDatos);
        }
    }
}
