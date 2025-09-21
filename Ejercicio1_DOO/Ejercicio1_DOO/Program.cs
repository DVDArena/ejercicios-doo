namespace Ejercicio1_DOO
{
    // CLASE PRINCIPAL:
    internal class Program
    {
        // MÉTODO MAIN:
        static void Main(string[] args)
        {
            // Arreglos de latitud y longitud con 5 espacios de diferencia para "encriptación":
            float[] latitud = new float[6];
            float[] longitud = new float[11]; // longitud con 5 posiciones extra

            // latitudes
            latitud[0] = 168.0f;
            latitud[1] = 170.5f;
            latitud[2] = 172.2f;
            latitud[3] = 174.1f;
            latitud[4] = 176.3f;
            latitud[5] = 179.0f;

            // longitudes 
            longitud[0] = -123.57f;
            longitud[1] = -124.00f;
            longitud[2] = -125.45f;
            longitud[3] = -126.78f;
            longitud[4] = -127.12f;

            // posiciones correctas (desplazadas 5)
            longitud[5] = -58.3816f; // corresponde a latitud[0]
            longitud[6] = -64.1888f;
            longitud[7] = -63.6167f;
            longitud[8] = -60.6393f;
            longitud[9] = -70.7695f;
            longitud[10] = -58.5873f; // corresponde a latitud[5]

            // Mostrar coordenadas correctas (con desplazamiento de 5)
            for (int i = 0; i < latitud.Length; i++)
            {
                Console.WriteLine("La posición exacta es: Latitud = " + latitud[i] +
                                  ", Longitud = " + longitud[i + 5]);
            }
        }
    }
}