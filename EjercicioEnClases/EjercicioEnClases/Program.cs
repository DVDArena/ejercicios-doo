namespace EjercicioEnClases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arreglo de Persona:
            Persona[] personas = new Persona[2];

            
            personas[0] = new Usuario("Débora", "D'Arena", "debora87", "1234");
            personas[1] = new Cliente("Juan", "Pérez", "juanperez@mail.com");

            // Recorremos el arreglo y mostramos la info de cada objeto
            foreach (Persona p in personas)
            {
                p.MostrarInfo(); // se llama al método correspondiente según el tipo
                Console.WriteLine("-----");
            }

      

        }

        Clase base: Persona
    class Persona
        {
            // Atributos:
            public string Nombre;
            public string Apellido;

            // Constructor vacío:
            public Persona() { }

            // Constructor con parámetros:
            public Persona(string nombre, string apellido)
            {
                this.Nombre = nombre;
                this.Apellido = apellido;
            }

            // Método:
            public virtual void MostrarInfo()
            {
                Console.WriteLine("Nombre: " + this.Nombre + " " + this.Apellido);
            }
        }

        // Clase hija: Usuario
        class Usuario : Persona
        {
            // Atributos:
            public string Username;
            public string Password;

            // Constructor vacío:
            public Usuario() { }

            // Constructor con parámetros:
            public Usuario(string nombre, string apellido, string username, string password)
                : base(nombre, apellido)
            {
                this.Username = username;
                this.Password = password;
            }

            // Métodos:
            public string IniciarSesion(string username, string password)
            {
                if (this.Username == username && this.Password == password)
                    return "Inicio de sesión correcto";
                else
                    return "Usuario o contraseña incorrectos";
            }

            public void CambiarContrasena(string actual, string nueva)
            {
                if (this.Password == actual)
                {
                    this.Password = nueva;
                    Console.WriteLine("Contraseña cambiada correctamente");
                }
                else
                {
                    Console.WriteLine("La contraseña actual no coincide");
                }
            }

            public override void MostrarInfo()
            {
                base.MostrarInfo();
                Console.WriteLine("Usuario: " + this.Username);
            }
        }

        // Clase hija: Cliente
        class Cliente : Persona
        {
            // Atributos:
            public string Correo;

            // Constructor vacío:
            public Cliente() { }

            // Constructor con parámetros:
            public Cliente(string nombre, string apellido, string correo)
                : base(nombre, apellido)
            {
                this.Correo = correo;
            }

            public override void MostrarInfo()
            {
                base.MostrarInfo();
                Console.WriteLine("Correo: " + this.Correo);
            }
        }
    }


















}
}
