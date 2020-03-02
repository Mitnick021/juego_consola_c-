using System;

namespace juego_parques
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("     || ESCALERA NUMERICA ||");

            Console.WriteLine("Digite la cantidad de jugadores");

            String cantJug = Console.ReadLine();
            Console.WriteLine("La cantidad de jugadores es: " + cantJug);
            int cantidad = int.Parse(cantJug);

            if (cantidad < 2 || cantidad > 4)
            {

                Console.WriteLine("La cantidad de jugadores debe ser entre 2 y 4: ");

            }
            else
            {

                Console.WriteLine("Digite el nivel del juego (20, 30 o 50): ");
                String nivelJuego = Console.ReadLine();
                int niv_jue = int.Parse(nivelJuego);

                if (niv_jue == 20) { 

                Console.WriteLine("El nivel del juego selecionado es: " + nivelJuego);

                Console.WriteLine("__________________\n");

                Console.WriteLine("__________________\n");

                Console.WriteLine("INICIO DEL JUEGO");

                Console.WriteLine("__________________\n");

                int nivel = 0;

                nivel = int.Parse(nivelJuego);

                int iteracion = 0;
                int aux = 0;
                int aux2 = 0;
                int auxFinal = 0;
                int i = 1;

                    for (iteracion = 0; iteracion < nivel; iteracion += auxFinal)
                    {

                        Console.WriteLine("El jugador 1 esta en la posicion: " + iteracion);
                        Console.WriteLine("El jugador 2 esta en la posicion: " + iteracion);

                        Console.WriteLine("__________________\n");

                        Console.WriteLine("Lanzamiento numero: " + i);

                        String enter = Console.ReadLine();

                        Random rdm = new Random();

                        aux = rdm.Next(1, 6);
                        aux2 = rdm.Next(1, 6);
                        auxFinal = aux + aux2;

                        Console.WriteLine("Los dados dan: " + auxFinal + "\n");

                        i++;

                    }

                } else if (niv_jue == 30)
                {

                    Console.WriteLine("El nivel del juego selecionado es: " + nivelJuego);

                    Console.WriteLine("__________________\n");

                    Console.WriteLine("__________________\n");

                    Console.WriteLine("INICIO DEL JUEGO");

                    Console.WriteLine("__________________\n");

                    int nivel = 0;

                    nivel = int.Parse(nivelJuego);

                    int iteracion = 0;
                    int aux = 0;
                    int aux2 = 0;
                    int auxFinal = 0;
                    int i = 1;

                    for (iteracion = 0; iteracion < nivel; iteracion += auxFinal)
                    {

                        Console.WriteLine("El jugador 1 esta en la posicion: " + iteracion);
                        Console.WriteLine("El jugador 2 esta en la posicion: " + iteracion);
                        Console.WriteLine("El jugador 3 esta en la posicion: " + iteracion);

                        Console.WriteLine("__________________\n");

                        Console.WriteLine("Lanzamiento numero: " + i);

                        String enter = Console.ReadLine();

                        Random rdm = new Random();

                        aux = rdm.Next(1, 6);
                        aux2 = rdm.Next(1, 6);
                        auxFinal = aux + aux2;

                        Console.WriteLine("Los dados dan: " + auxFinal + "\n");

                        i++;
                    }

                    } else if (niv_jue == 50)
                {

                    Console.WriteLine("El nivel del juego selecionado es: " + nivelJuego);

                    Console.WriteLine("__________________\n");

                    Console.WriteLine("__________________\n");

                    Console.WriteLine("INICIO DEL JUEGO");

                    Console.WriteLine("__________________\n");

                    int nivel = 0;

                    nivel = int.Parse(nivelJuego);

                    int iteracion = 0;
                    int aux = 0;
                    int aux2 = 0;
                    int auxFinal = 0;
                    int i = 1;

                    for (iteracion = 0; iteracion < nivel; iteracion += auxFinal)
                    {

                        Console.WriteLine("El jugador 1 esta en la posicion: " + iteracion);
                        Console.WriteLine("El jugador 2 esta en la posicion: " + iteracion);
                        Console.WriteLine("El jugador 3 esta en la posicion: " + iteracion);
                        Console.WriteLine("El jugador 4 esta en la posicion: " + iteracion);

                        Console.WriteLine("__________________\n");

                        Console.WriteLine("Lanzamiento numero: " + i);

                        String enter = Console.ReadLine();

                        Random rdm = new Random();

                        aux = rdm.Next(1, 6);
                        aux2 = rdm.Next(1, 6);
                        auxFinal = aux + aux2;

                        Console.WriteLine("Los dados dan: " + auxFinal + "\n");

                        i++;
                    }

                } else
                {
                    Console.WriteLine("No existe este nivel de juego");
                }
            }
        }
    }
}
