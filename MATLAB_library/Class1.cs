using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATLAB_Library
{
    public class F_Arrays
    {

        /// <summary>
        /// Retorna la suma de los valores de un arreglo
        /// </summary>
        /// <param name = "x"> Arreglo de entrada </param>
        /// <returns></returns>
        public double SumList(double[] x)
        {
            double output = 0;
            for (int i = 0; i < x.Count(); i++)
            {
                output = output + x[i];
            }
            return output;
        }

        /// <summary>
        /// Regresa la suma de dos arreglos elemento por elemento en un nuevo arreglo, todos de la misma dimension
        /// </summary>
        /// <param name="ar1"> Arreglo sumando </param>
        /// <param name="ar2"> Arreglo sumando </param>
        /// <returns></returns>
        public double[] SumArray(double[] ar1, double[] ar2)
        {
            double[] output = new double[ar1.Length];
            for (int i = 0; i < ar1.Length; i++)
            {
                output[i] = ar1[i] + ar2[i];
            }
            return output;
        }

        /// <summary>
        /// Regresa la resta de dos arreglos elemento por elemento en un nuevo arreglo, todos de la misma dimension
        /// </summary>
        /// <param name="ar1"> Arreglo restando </param>
        /// <param name="ar2"> Arreglo restando </param>
        /// <returns></returns>
        public double[] DiffArray(double[] ar1, double[] ar2)
        {
            double[] output = new double[ar1.Length];
            for (int i = 0; i < ar1.Length; i++)
            {
                output[i] = ar1[i] - ar2[i];
            }
            return output;
        }

        /// <summary>
        /// Regresa la multiplicacion de dos arreglos elemento por elemento en un nuevo arreglo, todos de la misma dimension
        /// Regresa la multiplicacion de un arreglo por un escalar en un nuevo arreglo de la misma dimension
        /// </summary>
        /// <param name="ar1"> Arreglo multiplicado </param>
        /// <param name="ar2"> Arreglo multiplicado </param>
        /// <param name="esc"> escalar multiplicado </param>
        /// <returns></returns>
        public double[] MultArray(double[] ar1, double[] ar2)
        {
            double[] output = new double[ar1.Length];
            for (int i = 0; i < ar1.Length; i++)
            {
                output[i] = ar1[i] * ar2[i];
            }
            return output;
        }

        public double[] MultArray(double esc, double[] ar1)
        {
            double[] output = new double[ar1.Length];
            for (int i = 0; i < ar1.Length; i++)
            {
                output[i] = esc * ar1[i];
            }
            return output;
        }

        /// <summary>
        /// Devuelve un arreglo con el error cuadrático de cada elemento
        /// </summary>
        /// <param name="ar1"> Arreglo de datos 1 </param>
        /// <param name="valor"> Valor deseado para el calculo de los errores </param>
        /// <returns></returns>
        public double[] EC(double[] ar1, double valor)
        {
            int l = ar1.Length;
            double[] output = new double[l];

            for (int i = 0; i < ar1.Length; i++)
            {
                output[i] = Math.Pow((ar1[i] - valor), 2);
            }
            return output;
        }

        /// <summary>
        /// Imprime Un arreglo en cosola con formato
        /// </summary>
        /// <param name="v"> Arreglo de entrada </param>
        public static void PrintArray(double[] v)
        {
            int len = v.Length;
            Console.Write("[{0}", v[0].ToString("0.000"));
            for (int i = 1; i < len; i++)
            {
                Console.Write(" ,");
                Console.Write(v[i].ToString("0.000"));
            }
            Console.WriteLine("]");
            Console.Write("\n");

        }

        /// <summary>
        /// Imprime un arreglo en consola con formato exponencial
        /// </summary>
        /// <param name="v"> Arreglo de entrada </param>
        public static void PrintArrayE(double[] v)
        {
            int len = v.Length;
            Console.Write("[{0}", v[0].ToString("E"));
            for (int i = 1; i < len; i++)
            {
                Console.Write(" ,");
                Console.Write(v[i].ToString("E"));
            }
            Console.WriteLine("]");
            Console.Write("\n");

        }
    }

    public class MATLAB 
    {
        /// <summary>
        /// Devuleve un arreglo de las sumas de sus elementos de manera consecutiva en un nuevo arreglo
        /// </summary>
        /// <param name = "x"> Arreglo de entrada </param>
        /// <returns></returns>

        public static double[] Sum(double[] ar1, double[] ar2)
        {
            double[] output = new double[ar1.Length];
            for (int i = 0; i < ar1.Length; i++)
            {
                output[i] = ar1[i] + ar2[i];
            }
            return output;
        }

        /// <summary>
        /// Devuleve un arreglo de las diferencias de sus elementos de manera consecutiva en un nuevo arreglo
        /// </summary>
        /// <param name = "x"> Arreglo de entrada </param>
        /// <returns></returns>

        public static double[] Diff(double[] ar1, double[] ar2)
        {
            double[] output = new double[ar1.Length];
            for (int i = 0; i < ar1.Length; i++)
            {
                output[i] = ar1[i] - ar2[i];
            }
            return output;
        }

        /// <summary>
        /// Devuelve un arreglo desde x1 a x2 con diferencia de n entre valores
        /// </summary>
        /// <param name = "x1"> Valor inicial del arreglo </param>
        /// <param name = "x2"> Valor final del arreglo </param>
        /// <param name = "n"> espaciado de los datos </param>
        /// <returns></returns>
        public static double[] Linspace(double x1, double x2, double n)
        {
            double paso = n;
            int l = Convert.ToInt32(((Math.Abs(x2 - x1)) / paso) + 1);
            double[] output = new double[l];

            if (x1 > x2) //Si el valor inicial es mayor que el final, se crea el arreglo de manera decreciente
            {
                for (int i = 0; i < l; i++)
                {
                    output[i] = Math.Truncate((x1 - (paso * i)) * 10000) / 10000;
                }
            }

            else //Se crea el arreglo de manera creciente
            {
                for (int i = 0; i < l; i++)
                {
                    output[i] = Math.Truncate((x1 + (paso * i)) * 10000) / 10000;
                }
            }
            return output;
        }

    }
}
