using System;

namespace Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Naranja naranja1 = new Naranja();
            naranja1.cosechar();

            Naranja naranja2 = new Naranja();
            naranja2.comer();
            
            Limon limon3 = new Limon();
            limon3.condimentar();

            Alumno alumno1 = new Alumno();
            alumno1.inscribirse();

            Alumno alumno2 = new Alumno();
            alumno2.rendirExamen();

            Alumno alumno3 = new Alumno();
            alumno3.asistirAClases();

            Profesor profesor1 = new Profesor();
            profesor1.dictarClase();

            Profesor profesor2 = new Profesor();
            profesor2.corregirExamen();

            Pez pez1 = new Pez();
            pez1.alimentar();

            Pez pez2 = new Pez();
            pez2.nadar();

            Molusco molusco3 = new Molusco();
            molusco3.desplazar();
        }
    }

    class Naranja
    {
        /* atributos de la clase naranja */
        public string color;
        public bool para_jugo;
        public string region;
        public bool madura;

        /* metodos de la clase naranja */
        public void cosechar() 
        { 
            /* comportamiento de la clase naranja del método cosechar*/
            Console.WriteLine("lista para hacer jugo");
        }

        public void comer()
        {
            /* comportamiento de la clase naranja del método comer*/
            Console.WriteLine("lista para comer");
        }
    }

    class Limon
    {
        /* atributos de la clase limon */
        public string color;
        public string region;
        public bool maduro;
        public int nivel_acidez;

        /* metodos de la clase limon */

        public void cosechar()
        {
            /* comportamiento de la clase limon del método cosechar*/
            Console.WriteLine("listo para hacer jugo");
        }

        public void comer()
        {
            /* comportamiento de la clase limon del método comer*/
            Console.WriteLine("listo para comer");
        }
        public void condimentar()
        {
            /* comportamiento de la clase limon del método condimentar*/
            Console.WriteLine("vamos a condimentar esas comidas");
        }
    }

    class Alumno
    {
        /* atributos de la clase alumno */
        public string nombre;
        public int legajo;
        public string carrera;
        public string mail;

        /* metodos de la clase alumno */

        public void inscribirse()
        {
            /* comportamiento de la clase alumno del método inscribirse*/
            Console.WriteLine("vamos a inscribirnos");
        }

        public void rendirExamen()
        {
            /* comportamiento de la clase alumno del método rendirExamen*/
            Console.WriteLine("a estudiar");
        }
        public void asistirAClases()
        {
            /* comportamiento de la clase alumno del método AsistirAClases*/
            Console.WriteLine("no podemos faltar");
        }
    }

    class Profesor
    {
        /* atributos de la clase profesor */
        public string nombre;
        public int legajo;
        public string materia;
        public string mail;

        /* metodos de la clase profesor */

        public void dictarClase()
        {
            /* comportamiento de la clase profesor del método dictarClase*/
            Console.WriteLine("vamos a preparar la clase");
        }

        public void corregirExamen()
        {
            /* comportamiento de la clase profesor del método corregirExamen*/
            Console.WriteLine("a corregir");
        }
        public void asistirAClases()
        {
            /* comportamiento de la clase profesor del método AsistirAClases*/
            Console.WriteLine("no podemos faltar");
        }
    }

    class Pez
    {
        /* atributos de la clase pez */
        public string especie;
        public int tamaño_cm;
        public string color;

        /* metodos de la clase pez */

        public void alimentar()
        {
            /* comportamiento de la clase pez del método alimentar*/
            Console.WriteLine("tengo hambre");
        }

        public void nadar()
        {
            /* comportamiento de la clase pez del método nadar*/
            Console.WriteLine("me gusta nadar");
        }
    }

    class Molusco
    {
        /* atributos de la clase molusco */
        public string especie;
        public int tamaño_cm;
        public string color;
        public int cant_tentaculos;

        /* metodos de la clase molusco */

        public void alimentar()
        {
            /* comportamiento de la clase molusco del método alimentar*/
            Console.WriteLine("tengo hambre");
        }

        public void desplazar()
        {
            /* comportamiento de la clase molusco del método desplazar*/
            Console.WriteLine("quisiera poder nadar");
        }
    }

}
