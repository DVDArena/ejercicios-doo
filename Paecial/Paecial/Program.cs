namespace Parcial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arrays con 10 espacios:
            Integrante[] integrantes = new Integrante[10];

            // 7 Técnicos y Gerentes:
            integrantes[0] = new Tecnico("Débora", "D'Arena", "programador", "C#");
            integrantes[1] = new Tecnico("Lucía", "Gómez", "tester", "Java");
            integrantes[2] = new GerenteTech("María", "López", "Argentina", 3);
            integrantes[4] = new Tecnico("Sofía", "Díaz", "programador", "Python");
            integrantes[5] = new Tecnico("Carlos", "Ruiz", "tester", "C#");
            integrantes[6] = new GerenteTech("Pedro", "Martínez", "México", 2);
            integrantes[7] = new Tecnico("Ana", "Fernández", "programador", "Java");

            // 3 Inversores:
            integrantes[7] = new Inversor("Jorge", "Silva", 50000, "Finanzas");
            integrantes[8] = new Inversor("Elena", "Castro", 75000, "Expansión");
            integrantes[9] = new Inversor("Luis", "Torres", 100000, "Innovación");

            //Para mostrar info de todos los integrantes de la empresa:
            Console.WriteLine("Integrantes de la empresa");
            foreach (Integrante i in integrantes)
            {
                i.MostrarInfo();
                Console.WriteLine();
            }
        }
    }

    //Clase padre:
    class Integrante
    {
        //Atributos:
        public string Nombre;
        public string Apellido;

        //Constructor vacío:
        public Integrante() { }

        //Constructor con parámetros:
        public Integrante(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        //Método:
        public virtual void MostrarInfo()
        {
            Console.WriteLine("Nombre: " + Nombre + " " + Apellido);
        }
    }

    //Clase hija:
    class Tecnico : Integrante
    {
        //Atributos:
        public string Especialidad;
        public string Lenguaje;

        //Constructor vacío:
        public Tecnico() { }

        //Constructor con parámetros:
        public Tecnico(string nombre, string apellido, string especialidad, string lenguaje)
            : base(nombre, apellido)
        {
            this.Especialidad = especialidad;
            this.Lenguaje = lenguaje;
        }

        //Método:
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine("Especialidad: " + Especialidad + ", Lenguaje: " + Lenguaje);
        }
    }

    //Clase hija:
    class GerenteTech : Integrante
    {
        //Atributos:
        public string Pais;
        public int CantAreas;

        //Constructor vacío:
        public GerenteTech() { }
        
        //Constructor con parámetros:
        public GerenteTech(string nombre, string apellido, string pais, int cantAreas)
            : base(nombre, apellido)
        {
            this.Pais = pais;
            this.CantAreas = cantAreas;
        }

        //Método:
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine("País: " + Pais + ", Áreas a cargo: " + CantAreas);
        }
    }

    //Clase hija:
    class Inversor : Integrante
    {
        //Atributos:
        public int Monto;
        public string Proyecto;

        //Constructor vacío:
        public Inversor() { }

        //Constructor con parámetros:
        public Inversor(string nombre, string apellido, int monto, string proyecto)
            : base(nombre, apellido)
        {
            this.Monto = monto;
            this.Proyecto = proyecto;
        }

        //Método:
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine("Monto invertido: " + Monto + ", Proyecto: " + Proyecto);
        }
    }
}

