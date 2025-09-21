namespace Ejercicio5_DOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arreglo de Pokemones:
            Pokemon[] pokedex = new Pokemon[3];

            pokedex[0] = new PokemonFuego("Charmander", 10);
            pokedex[1] = new PokemonAgua("Squirtle", 12);
            pokedex[2] = new PokemonElectrico("Pikachu", 15);

            // Ejecutar ataques:
            Console.WriteLine("= Ataques de la Pokedex =");
            foreach (Pokemon p in pokedex)
            {
                p.Atacar();
            }
        }
    }

    // Clase padre:
    class Pokemon
    {
        //Atributos:
        public string Nombre;
        public int Nivel;

        //Constructor vacío:
        public Pokemon() { }

        //Constructor con parámetros:
        public Pokemon(string nombre, int nivel)
        {
            this.Nombre = nombre;
            this.Nivel = nivel;
        }

        //Método:
        public virtual void Atacar()
        {
            Console.WriteLine(this.Nombre + " ataca!");
        }
    }

    // Subclase PokemonFuego:
    class PokemonFuego : Pokemon
    {
        //Constructor vacío:
        public PokemonFuego() { }

        //Constructor con parámetros:
        public PokemonFuego(string nombre, int nivel) : base(nombre, nivel) { }

        //Método:
        public override void Atacar()
        {
            Console.WriteLine("Pokemon " + this.Nombre + " lanza una llamarada!");
        }
    }

    // Subclase PokemonAgua
    class PokemonAgua : Pokemon
    {
        //Constructor vacío:
        public PokemonAgua() { }

        //Constructor con parámetros:
        public PokemonAgua(string nombre, int nivel) : base(nombre, nivel) { }

        //Método:
        public override void Atacar()
        {
            Console.WriteLine("Pokemon " + this.Nombre + " lanza un chorro de agua!");
        }
    }

    // Subclase PokemonElectrico
    class PokemonElectrico : Pokemon
    {
        //Constructor vacío:
        public PokemonElectrico() { }

        //Constructor con parámetros:
        public PokemonElectrico(string nombre, int nivel) : base(nombre, nivel) { }

        //Método:
        public override void Atacar()
        {
            Console.WriteLine("Pokemon " + this.Nombre + " lanza un impactrueno!");
        }
    }
}
