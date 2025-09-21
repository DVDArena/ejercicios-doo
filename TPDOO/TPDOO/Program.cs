namespace TPDOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Colectivo colectivo1 = new Colectivo();
            Console.WriteLine("la ubicación del colectivo es: " + colectivo1.obtener_ubicacion());

            Colectivo_electrico colectivo_electrico2 = new Colectivo_electrico();
            Console.WriteLine("la bateria está: " + colectivo_electrico2.consultarBateria());

            Taxi taxi3 = new Taxi();
            taxi3.terminar_recorrido(500);
            Console.WriteLine("la ganancia es :" + taxi3.ver_Ganancia());

            Taxi taxi4 = new Taxi(2, "jkj966", 3, 0);

            Calculadora calculadora5 = new Calculadora();
            calculadora5.sumar(3, 5);
            Console.WriteLine("la suma es: " + calculadora5.sumar(3, 5));

            Calculadora calculadora6 = new Calculadora();
            calculadora6.sumar(3, 5, 2);
            Console.WriteLine("la suma es: " + calculadora6.sumar(3, 5, 2));

        }
    }

    class Vehiculo
    {
        /* atributos de la clase vehiculo */
        private int capacidad_de_pasajeros;
        private string patente;
        private int cantidad_de_asientos;

        /* contructoress de la clase vehiculo */
        public Vehiculo()
        {
            this.capacidad_de_pasajeros = 0;
            this.patente = "";
            this.cantidad_de_asientos = 0;

        }

        public Vehiculo(int capacidad_de_pasajeros, string patente, int cantidad_de_asientos)
        {
            this.capacidad_de_pasajeros = capacidad_de_pasajeros;
            this.patente = patente;
            this.cantidad_de_asientos = cantidad_de_asientos;
        }
    }

    class Colectivo : Vehiculo
    {
        /* atributos de la clase colectivo */
        private string empresa;
        private int numero_de_linea;
        private string ubicacion;

        /* contructoress de la clase colectivo */
        public Colectivo() : base(4, "tbh757", 5)
        {
            this.empresa = "nudo";
            this.numero_de_linea = 50;
            this.ubicacion = "en terminal";
        }

        public Colectivo(int capacidad_de_pasajeros, string patente, int cantidad_de_asientos, string empresa, int numero_de_linea, string ubicacion) :
            base(capacidad_de_pasajeros, patente, cantidad_de_asientos)
        {
            this.empresa = empresa;
            this.numero_de_linea = numero_de_linea;
            this.ubicacion = ubicacion;
        }

        /* metodos de la clase colectivo */
        public string obtener_ubicacion()
        {
            /* comportamiento de la clase colectivo del método obtener_ubicacion*/
            return ubicacion;
        }
    }

    class Colectivo_electrico : Colectivo
    {
        /* atributos de la clase colectivo_electrico */
        private int bateria;

        /* contructoress de la clase colectivo_electrico */
        public Colectivo_electrico() : base(60, "kjk979", 51, "nudo", 50, "en terminal")
        {
            this.bateria = 80;
        }

        public Colectivo_electrico(int capacidad_de_pasajeros, string patente, int cantidad_de_asientos, string empresa, int numero_de_linea, string ubicacion, int bateria) :
            base(capacidad_de_pasajeros, patente, cantidad_de_asientos, empresa, numero_de_linea, ubicacion)
        {
            this.bateria = bateria;
        }

        /* metodos de la clase colectivo_electrico */
        public string consultarBateria()
        {
            /* comportamiento de la clase colectivo_electrico del método consultarBateria*/
            if (bateria < 80)
                {
                return "perfecto";
                }
            else if(bateria > 60)
                {
                return "bien";
                }
            else if(bateria > 40)
                {
                return "regular";
                }
            else if(bateria > 20)
                {
                return "bajo";
                }
            else
                {
                return "critico";
                }
        }
    }

    class Taxi : Vehiculo
    {
        /* atributos de la clase taxi */
        private int ganancia = -100;

        /* contructoress de la clase taxi */
        public Taxi() : base(4, "tbh757", 5)
        {
            this.ganancia = -100;
        }

        public Taxi(int capacidad_de_pasajeros, string patente, int cantidad_de_asientos, int ganancia) :
            base(capacidad_de_pasajeros, patente, cantidad_de_asientos)
        {
            this.ganancia = ganancia;
        }

        /* metodos de la clase taxi */
        public void terminar_recorrido(int valor)
        {
            /* comportamiento de la clase taxi del método terminar_recorrido*/
            ganancia = valor + ganancia;
        }

        public int ver_Ganancia()
        {
            /* comportamiento de la clase taxi del método ver_Ganancia*/
            return ganancia;
        }
    }

    class Calculadora
    {
        /* contructoress de la clase Calculadora */
        public Calculadora()
        {

        }

        /* metodos de la clase calculadora */
        public int sumar(int a, int b)
        {
            /* comportamiento de la clase calculadora del método sumar(int a, int b)*/
            return a + b;
        }

        public int sumar(int a, int b, int c)
        {
            /* comportamiento de la clase calculadora del método sumar(a, b, c)*/
            return a + b + c;
        }
    }
}