namespace modeloParcial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Empleados (10 en total):
            Empleado[] empleados = new Empleado[10];
            // 3 Administrativos:
            empleados[0] = new Administrativo("Juan", "Pérez", "Recursos Humanos", "Asistente");
            empleados[1] = new Administrativo("Lucía", "Gómez", "Contabilidad", "Analista");
            empleados[2] = new Administrativo("Carlos", "Ruiz", "Sistemas", "Secretario");
            // 2 Gerentes:
            empleados[3] = new Gerente("María", "López", 10, 3);
            empleados[4] = new Gerente("Pedro", "Martínez", 7, 2);
            // 5 Técnicos:
            empleados[5] = new Tecnico("Ana", "Fernández", "programador", "C#");
            empleados[6] = new Tecnico("Luis", "Torres", "tester", "C#");
            empleados[7] = new Tecnico("Jorge", "Silva", "programador", "Java");
            empleados[8] = new Tecnico("Sofía", "Díaz", "tester", "C#");
            empleados[9] = new Tecnico("Elena", "Castro", "programador", "Python");
            // Mostrar todos:
            Console.WriteLine("=== Lista de empleados ===");
            foreach (Empleado e in empleados)
            {
                e.MostrarInfo();
                Console.WriteLine();
            }
            // Extra: contar programadores y testers
            int cantProgramadores = 0;
            int cantTesters = 0;
            foreach (Empleado e in empleados)
            {
                if (e is Tecnico t)
                {
                    if (t.Especialidad == "programador")
                        cantProgramadores++;
                    else if (t.Especialidad == "tester")
                        cantTesters++;
                }
            }
            Console.WriteLine("Cantidad de Programadores: " + cantProgramadores);
            Console.WriteLine("Cantidad de Testers: " + cantTesters);
        }
    }
    // Clase base:
    class Empleado
    {
        public string Nombre;
        public string Apellido;
        public Empleado() { }
        public Empleado(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }
        public virtual void MostrarInfo()
        {
            Console.WriteLine("Nombre: " + Nombre + " " + Apellido);
        }
    }
    // Administrativo:
    class Administrativo : Empleado
    {
        public string Area;
        public string Puesto;
        public Administrativo() { }
        public Administrativo(string nombre, string apellido, string area, string puesto)
        : base(nombre, apellido)
        {
            this.Area = area;
            this.Puesto = puesto;
        }
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine("Área: " + Area + ", Puesto: " + Puesto);
        }
    }
    // Gerente:
    class Gerente : Empleado
    {
        public int AniosExperiencia;
        public int CantAreas;
        public Gerente() { }
        public Gerente(string nombre, string apellido, int aniosExp, int cantAreas)
        : base(nombre, apellido)
        {
            this.AniosExperiencia = aniosExp;
            this.CantAreas = cantAreas;
        }
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine("Años de experiencia: " + AniosExperiencia +
            ", Áreas a cargo: " + CantAreas);
        }
    }
    // Técnico:
    class Tecnico : Empleado
    {
        public string Especialidad; // programador o tester
        public string Lenguaje;
        public Tecnico() { }
        public Tecnico(string nombre, string apellido, string especialidad, string lenguaje)
        : base(nombre, apellido)
        {
            this.Especialidad = especialidad;
            this.Lenguaje = lenguaje;
        }
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine("Especialidad: " + Especialidad +
            ", Lenguaje: " + Lenguaje);
        }
    }
}