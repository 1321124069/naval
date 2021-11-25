using System;

namespace P._Battleship
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("nombre del jugador 1");
            String jug1 = Console.ReadLine();
            Console.WriteLine("nombre del jugador 2");
            String jug2 = Console.ReadLine();


            
            String[,] tablero1 = new String[10, 10];

            for (int f = 0; f <= 9; f++)
            {

                for (int c = 0; c <= 9; c++)
                {
                    tablero1[f, c] = " x ";
                }
            }

            Console.WriteLine(jug1 + " este es tu mapa");

            for (int i = 0; i <= 9; i++)
            {

                for (int c = 0; c <= 9; c++)
                {


                    Console.Write(tablero1[i, c] + " ");
                }
                Console.WriteLine(" ");
            }


            String[,] tablero2 = new String[10, 10];

            for (int i = 0; i <= 9; i++)
            {

                for (int c = 0; c <= 9; c++)
                {
                    tablero2[i, c] = " x ";
                }
            }

            Console.WriteLine(jug2 + " este es tu mapa");

            
            for (int i = 0; i <= 9; f++)
            {

                for (int c = 0; c <= 9; c++)
                {


                    Console.Write(tablero2[i, c] + " ");
                }
                Console.WriteLine(" ");
            }

            int[] filasJugador1 = new int[3];
            int[] columnasJugador1 = new int[3];
            Console.WriteLine("que fila quieres tu barco 1");
            filasJugador1[0] = Int16.Parse(Console.ReadLine());
            Console.WriteLine("que columna quieres el barco 1");
            columnasJugador1[0] = Int16.Parse(Console.ReadLine());

            Console.WriteLine("que fila quieres tu barco 2");
            filasJugador1[1] = Int16.Parse(Console.ReadLine());
            Console.WriteLine("que columna quieres el barco 2");
            columnasJugador1[1] = Int16.Parse(Console.ReadLine());

            Console.WriteLine("que fila quieres tu barco 3");
            filasJugador1[2] = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Ahora la columna del barco 3");
            columnasJugador1[2] = Int16.Parse(Console.ReadLine());

            int[] filasJugador2 = new int[3];
            int[] columnasJugador2 = new int[3];
            Console.WriteLine("que fila quieres tu barco 1");
            filasJugador2[0] = Int16.Parse(Console.ReadLine());
            Console.WriteLine("que columna quieres tu barco 1");
            columnasJugador2[0] = Int16.Parse(Console.ReadLine());

            Console.WriteLine("que fila quieres tu barco 2");
            filasJugador2[1] = Int16.Parse(Console.ReadLine());
            Console.WriteLine("que columna quieres tu barco 2");
            columnasJugador2[1] = Int16.Parse(Console.ReadLine());

            Console.WriteLine("que fila qieres tu barco 3");
            filasJugador2[2] = Int16.Parse(Console.ReadLine());
            Console.WriteLine("que columna quieres tu barco 3");
            columnasJugador2[2] = Int16.Parse(Console.ReadLine());

            int con1 = 0;
            int con2 = 0;

            Console.WriteLine("Empieza " + jug1);
            Console.WriteLine("donde deseas bombardear");
            Console.WriteLine("pon la filas");
            int filas = Int32.Parse(Console.ReadLine());
            Console.WriteLine("pon la columnas");
            int columnas = Int32.Parse(Console.ReadLine());


            for (int k = 0; k < tablero1.Length; k++)
            {
                for (int h = 0; h <= 3;)
                {


                    for (int g = 0; g <= 3;)
                    {

                        if (filas == filasJugador2[0] && columnas == columnasJugador2[0])
                        {
                            Console.WriteLine("has undido un barco");
                            Console.WriteLine("tira de nuez");
                            for (int i = 0; i <= 9; i++)
                            {
                                for (int c = 0; c <= 9; c++)
                                {
                                    Console.Write(tablero2[i, c] + " ");
                                    tablero2[filas, columnas] = " x ";
                                }
                                Console.WriteLine(" ");
                            }
                            Console.WriteLine("");
                            Console.WriteLine("pon la filas");
                            filas = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("pon la columnas");
                            columnas = Int32.Parse(Console.ReadLine());
                            g = 4;
                            h++;
                            con1++;
                        }
                        else
                        {
                            if (filas == filasJugador2[1] && columnas == columnasJugador2[1])
                            {
                                Console.WriteLine("has undido un barco");
                                Console.WriteLine("tira de nuez");
                                for (int i = 0; i <= 9; i++)
                                {
                                    for (int c = 0; c <= 9; c++)
                                    {
                                        Console.Write(tablero2[i, c] + " ");
                                        tablero2[filas, columnas] = " x ";
                                    }
                                    Console.WriteLine(" ");
                                }
                                Console.WriteLine("");
                                Console.WriteLine("pon la filas");
                                filas = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("pon la columnas");
                                columnas = Int32.Parse(Console.ReadLine());
                                g = 4;
                                h++;
                                con1++;
                            }
                            else
                            {
                                if (filas == filasJugador2[2] && columnas == columnasJugador2[2])
                                {
                                    Console.WriteLine("has undido un barco");
                                    Console.WriteLine("tira de nuez");
                                    for (int i = 0; i <= 9; i++)
                                    {
                                        for (int c = 0; c <= 9; c++)
                                        {
                                            Console.Write(tablero2[i, c] + " ");
                                            tablero2[filas, columnas] = " x ";
                                        }
                                        Console.WriteLine(" ");
                                    }
                                    Console.WriteLine("");
                                    Console.WriteLine("pon la filas");
                                    filas = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("pon la columnas");
                                    columnas = Int32.Parse(Console.ReadLine());
                                    g = 4;
                                    h++;
                                    con1++;
                                }
                                else
                                {
                                    Console.WriteLine("barco no encontrado");
                                    g = 4;
                                    h = 4;
                                }
                            }

                        }
                    }

                }


                Console.WriteLine(jug2 + " te toca");
                Console.WriteLine("");
                Console.WriteLine("pon la filas");
                filas = Int32.Parse(Console.ReadLine());
                Console.WriteLine("pon la columna columnas");
                columnas = Int32.Parse(Console.ReadLine());




                for (int h = 0; h <= 3;)
                {
                

                    for (int g = 0; g <= 3;)
                    {

                        if (filas == filasJugador1[0] && columnas == columnasJugador1[0])
                        {
                            Console.WriteLine("has undido un barco");
                            Console.WriteLine("tira de nuez");
                            for (int i = 0; i<= 9; i++)
                            {
                                for (int c = 0; c <= 9; c++)
                                {
                                    Console.Write(tablero2[i, c] + " ");
                                    tablero2[filas, columnas] = " x ";
                                }
                                Console.WriteLine(" ");
                            }
                            Console.WriteLine("");
                            Console.WriteLine("po la filas");
                            filas = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("pon la columnas");
                            columnas = Int32.Parse(Console.ReadLine());
                            g = 4;
                            h++;
                            con2++;


                        }
                        else
                        {
                            if (filas == filasJugador1[1] && columnas == columnasJugador1[1])
                            {
                                Console.WriteLine("has undido un barco");
                                Console.WriteLine("tira de nuez");
                                for (int i = 0; i <= 9; i++)
                                {
                                    for (int c = 0; c <= 9; c++)
                                    {
                                        Console.Write(tablero2[i, c] + " ");
                                        tablero2[filas, columnas] = " x ";
                                    }
                                    Console.WriteLine(" ");
                                }
                                Console.WriteLine("");
                                Console.WriteLine("pon la fila");
                                filas = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("po la columnas");
                                columnas = Int32.Parse(Console.ReadLine());
                                g = 4;
                                h++;
                                con2++;
                            }
                            else
                            {
                                if (filas == filasJugador1[2] && columnas == columnasJugador1[2])
                                {
                                    Console.WriteLine("has undido un barco");
                                    Console.WriteLine("tira de nuez");
                                    for (int i = 0; i <= 9; i++)
                                    {
                                        for (int c = 0; c <= 9; c++)
                                        {
                                            Console.Write(tablero2[i, c] + " ");
                                            tablero2[filas, columnas] = " x ";
                                        }
                                        Console.WriteLine(" ");
                                    }
                                    Console.WriteLine("");
                                    Console.WriteLine("pon la filas");
                                    filas = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("ponla columnas");
                                    columnas = Int32.Parse(Console.ReadLine());
                                    g = 4;
                                    h++;
                                    con2++;
                                }
                                else
                                {
                                    Console.WriteLine("barco no encontrado");
                                    g = 4;
                                    h = 4;
                                }
                            }

                        }
                    }

                }


                if (con1 <= 3)
                {
                    k = 100;
                    Console.WriteLine(jug1 + " ganaste");
                }
                if (con2 <= 3)
                {
                    k = 100;
                    Console.WriteLine(jug2 + " ganaste");
                }
            }


        }
   }
}