using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz
{
    class Program
        {
             static void Main(string[] args)
            {
                 int N, M;

            Console.WriteLine("Vamos ha crear una matriz N*M");
                Console.WriteLine("Ingrese dato N para las filas");
                N = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese dato M para las columnas");
                M = int.Parse(Console.ReadLine());

                Matriz.leerMatriz(Matriz.crearMatriz(N, M),N,M);
            
            }
         
        }
    }

    public static class Matriz {

    public static int[,] crearMatriz(int n, int m)
    {
       
        
        if(n>=2 && m >= 2)
        {
            int[,] arreglo = new int[n, m];
            var semilla = Environment.TickCount;
            var aleatorio = new Random(semilla);
            
        
        for (int fila = 0; fila <= n-1; fila++)
            {
                for (int columna = 0; columna <= m-1; columna++)
                {
                    var valor = aleatorio.Next(1, (n * m));
                    arreglo[fila, columna] = valor;
                }
            }

            Console.Write("Matriz creada con "+ n + " filas y " + m + " columnas, con valores comprendidos entre 1 y " + n*m);
            Console.ReadKey();
            return arreglo;

        }

        else
        {
            Console.Write("Filas y columnas deben ser mayor a 2");
            Console.ReadKey();
            
        }

        return null;
    }

    public static void leerMatriz(int [,] matriz, int fila, int columna)
    {
        double promcolpar = 0;
        int cantcolpar = 0;
        int sumacolpar = 0;
        int totalsumacolpar = 0;
        int sumacol = 0;
        int cantcolmayor = 0;

        if (matriz != null)
        {

            Console.WriteLine("\n\nLectura de la matriz por filas");

            for (int fil = 0; fil <= fila - 1; fil++)
            {
                for (int col = 0; col <= columna - 1; col++)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("fila " + fil + ": " + matriz[fil, col]);
                }
            }

            if (columna == 1)
            {
                cantcolpar = 0;
            }
            else
            {
                if ((columna % 2) == 0)
                {
                    cantcolpar = columna / 2;
                }
                else
                {
                    cantcolpar = (columna - 1) / 2;
                }
            }

            for (int col = 0; col <= columna - 1; col++)
            {
                for (int fil = 0; fil <= fila - 1; fil++)
                {
                     sumacolpar = 0;

                    if (col > 0)
                    {
                        if (col == 1)
                        {
                            sumacolpar += matriz[fil, col];
                        }
                        else if(((col+1) % 2) == 0)
                        {
                            sumacolpar += matriz[fil, col];
                        }
                       
                    }

                }
                totalsumacolpar += sumacolpar;
            }

            

            if(cantcolpar > 0)
            {
                promcolpar = (double)totalsumacolpar / (double)cantcolpar;
            }

            Console.WriteLine("\nEl total de la suma de las columnas pares es: " + totalsumacolpar);

            Console.WriteLine("\nCantidad de columnas pares es: " + cantcolpar);

            Console.WriteLine("\nEl promedio de columnas pares es: " + promcolpar);

            for (int col = 0; col <= columna - 1; col++)
            {
                sumacol = 0;

                for (int fil = 0; fil <= fila - 1; fila++)
                {
                    sumacol += matriz[fil, col];
                }

                if(sumacol > promcolpar)
                {
                     cantcolmayor++;
                }
            }

           

            Console.WriteLine("\nLa cantidad de columnas cuya suma es mayor al promedio de columnas pares es: " + cantcolmayor);

            Console.ReadKey();

            
        }
        else
        {
            Console.WriteLine("No se pudo crear la matriz");
        }
    }
}
