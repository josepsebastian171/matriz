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
        if (matriz != null)
        {
            for (int fil = 0; fil <= fila - 1; fil++)
            {
                for (int col = 0; col <= columna - 1; col++)
                {

                }
            }
        }
        else
        {
            Console.WriteLine("No se pudo crear la matriz");
        }
    }
}
