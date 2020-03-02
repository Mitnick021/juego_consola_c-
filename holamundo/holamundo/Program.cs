using System;

namespace holamundo
{
    class Program
    {
        static void Main(string[] args)
        {
            string nj = "";
            string nt = "";
            //int cj = 0;

            //Numero de jugadores
            Console.WriteLine("Escribe el numero de jugadores: ");
            nj = Console.ReadLine();
            int num_ju = int.Parse(nj);

            //Validacion numero de jugadores
            if (num_ju<2 || num_ju > 4)
            {
                Console.WriteLine("Solo pueden jugar de 2 a 4 jugadores");
            }
            else
            {

                if (num_ju == 2)
                {

                    //Seleccion del tablero
                    Console.WriteLine("Seleccione el nivel del tablero: ");
                    Console.WriteLine(" 1. NIVEL BASICO (20 pocisiones) ");
                    Console.WriteLine(" 2. NIVEL INTERMEDIO (30 pocisiones) ");
                    Console.WriteLine(" 3. NIVEL AVANZADO (50 pocisiones) ");
                    nt = Console.ReadLine();
                    int niv_tab = int.Parse(nt);

                    if (niv_tab == 1)
                    {
                        int iteracion = 0;
                        int auxfinal = 0;
                        int i = 0;
                       
                        for (iteracion=0; iteracion>=20; iteracion+=auxfinal)
                        {

                            Console.WriteLine("El jugador 1 esta en la pocision: " + iteracion);

                            Console.WriteLine("Lanzamiento numero: " + i);

                            String enter = Console.ReadLine();

                            Random d1 = new Random();
                            Random d2 = new Random();

                            int d11 = d1.Next(1, 6);
                            Console.WriteLine("El dado numero 1 dio: " + d11);

                            int d22 = d2.Next(1, 6);
                            Console.WriteLine("El dado numero 2 dio: " + d22);

                            auxfinal = d11 + d22;

                            Console.WriteLine("El jugador 1 corre: " + auxfinal + " casillas");

                            i++;
                        }

                    }

                    else if (niv_tab == 2)
                    {



                    }

                    else if(niv_tab == 3){

                    }
                    else
                    {

                        Console.WriteLine("Esta opcion no existe");
                    }



                }
                
 
            }

        }
    }
}
