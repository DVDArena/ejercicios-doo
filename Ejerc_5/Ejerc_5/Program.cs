namespace Ejerc_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos un arreglo de máquinas virtuales (2 de procesamiento y 2 de aplicación):
                MaquinaVirtual[] maquinas = new MaquinaVirtual[4];

                // Instancias de procesamiento:
                maquinas[0] = new Procesamiento("Proc1", "v1.0", "Linux", "DB_Origen_A", "DB_Fin_A");
                maquinas[1] = new Procesamiento("Proc2", "v1.1", "Windows", "DB_Origen_B", "DB_Fin_B");

                // Instancias de aplicación:
                maquinas[2] = new Aplicacion("App1", "v2.0", "Linux", "Java", "17", "jdbc://db1");
                maquinas[3] = new Aplicacion("App2", "v2.1", "Windows", "Python", "3.12", "jdbc://db2");

                // Levantar todas las máquinas:
                Console.WriteLine("=== Levantando Máquinas ===");
                foreach (MaquinaVirtual m in maquinas)
                {
                    m.Levantar();

                    // Acciones específicas de cada tipo:
                    if (m is Procesamiento p)
                    {
                        p.Clonar();
                        p.Filtrar();
                        p.Almacenar();
                    }
                    else if (m is Aplicacion a)
                    {
                        a.Publicar();
                    }

                    Console.WriteLine();
                }

                // Bajar todas las máquinas:
                Console.WriteLine("=== Bajando Máquinas ===");
                foreach (MaquinaVirtual m in maquinas)
                {
                    m.Bajar();
                    Console.WriteLine();
                }
            }
        }

        // Clase base / padre
        class MaquinaVirtual
        {
            // Atributos:
            public string Nombre;
            public string Version;
            public string SistemaOperativo;
            public int Estado; // 0 = DOWN, 1 = UP

            // Constructor vacío:
            public MaquinaVirtual() { }

            // Constructor con parámetros:
            public MaquinaVirtual(string nombre, string version, string sistemaOperativo)
            {
                this.Nombre = nombre;
                this.Version = version;
                this.SistemaOperativo = sistemaOperativo;
                this.Estado = 0; // comienza apagada
            }

            // Métodos:
            public virtual void Levantar()
            {
                this.Estado = 1;
                Console.WriteLine("Máquina " + this.Nombre + " levantada correctamente.");
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

        // Clase hija: Procesamiento
        class Procesamiento : MaquinaVirtual
        {
            // Atributos propios:
            public string DatosOrigen;
            public string DatosFin;

            // Constructor vacío:
            public Procesamiento() { }

            // Constructor con parámetros:
            public Procesamiento(string nombre, string version, string sistemaOperativo,
                                 string datosOrigen, string datosFin)
                : base(nombre, version, sistemaOperativo)
            {
                this.DatosOrigen = datosOrigen;
                this.DatosFin = datosFin;
            }

            // Métodos:
            public override void Levantar()
            {
                this.Estado = 1;
                Console.WriteLine("Instancia de Procesamiento " + this.Nombre + " levantada.");
                Console.WriteLine("Acceso a datos de origen: " + this.DatosOrigen);
                Console.WriteLine("Acceso a datos de fin: " + this.DatosFin);
            }

            public override void MostrarInfo()
            {
                base.MostrarInfo();
                Console.WriteLine("Origen: " + this.DatosOrigen + ", Fin: " + this.DatosFin);
            }

            public void Clonar()
            {
                Console.WriteLine("Clonando datos desde " + this.DatosOrigen + "...");
            }

            public void Filtrar()
            {
                Console.WriteLine("Filtrando datos...");
            }

            public void Almacenar()
            {
                Console.WriteLine("Almacenando datos en " + this.DatosFin + "...");
            }
        }

        // Clase hija: Aplicacion
        class Aplicacion : MaquinaVirtual
        {
            // Atributos propios:
            public string Lenguaje;
            public string VersionLenguaje;
            public string BaseDatos;

            // Constructor vacío:
            public Aplicacion() { }

            // Constructor con parámetros:
            public Aplicacion(string nombre, string version, string sistemaOperativo,
                              string lenguaje, string versionLenguaje, string baseDatos)
                : base(nombre, version, sistemaOperativo)
            {
                this.Lenguaje = lenguaje;
                this.VersionLenguaje = versionLenguaje;
                this.BaseDatos = baseDatos;
            }

            // Métodos:
            public override void Levantar()
            {
                this.Estado = 1;
                Console.WriteLine("Instancia de Aplicación " + this.Nombre + " levantada.");
                Console.WriteLine("Lenguaje " + this.Lenguaje + " versión " + this.VersionLenguaje + " instalado.");
                Console.WriteLine("Acceso a base de datos: " + this.BaseDatos);
            }

            public override void MostrarInfo()
            {
                base.MostrarInfo();
                Console.WriteLine("Lenguaje: " + this.Lenguaje +
                                  ", Versión: " + this.VersionLenguaje +
                                  ", Base de datos: " + this.BaseDatos);
            }

            public void Publicar()
            {
                Console.WriteLine("Publicando aplicación en " + this.SistemaOperativo +
                                  " con lenguaje " + this.Lenguaje + "...");
            }
        }
    }