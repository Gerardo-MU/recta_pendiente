using System;
using System.Linq;


namespace MATLAB_Library
{
    public class Arrays
    {
        /// <summary>
        /// Regresa la suma de dos arreglos elemento por elemento en un nuevo arreglo, todos de la misma dimension
        /// </summary>
        /// <param name="ar1"> Arreglo sumando </param>
        /// <param name="ar2"> Arreglo sumando </param>
        /// <returns></returns>
        public static double[] SumArray(double[] ar1, double[] ar2)
        {
            double[] output = new double[ar1.Length];
            for (int i = 0; i < ar1.Length; i++)
            {
                output[i] = ar1[i] + ar2[i];
            }
            return output;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="b"></param>
        /// <param name="vector"></param>
        /// <returns></returns>
        public static double[] SumArraysEsc(double b, double[] vector)
        {
            double[] output = new double[vector.Length];

            for (int i = 0; i < output.Length; i++)
            {
                output[i] = vector[i] + b;
            }
            return output;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input1"></param>
        /// <param name="input2"></param>
        /// <returns></returns>
        public static double[] DiffArrays(double[] input1, double[] input2)
        {
            if (input1.Length != input2.Length)
            {
                Console.WriteLine("No son del mismo tamaño");
                return null;
            }
            else
            {
                double[] output = new double[input1.Length];
                for (int i = 0; i < output.Length; i++)
                {
                    output[i] = input1[i] - input2[i];
                }
                return output;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="esc"></param>
        /// <param name="vector"></param>
        /// <returns></returns>
        public static double[] MultEsc(double esc, double[] vector)
        {
            double[] output = new double[vector.Length];

            for (int i = 0; i < output.Length; i++)
            {
                output[i] = vector[i] * esc;
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
        public static double[] MultArray(double[] ar1, double[] ar2)
        {
            double[] output = new double[ar1.Length];
            for (int i = 0; i < ar1.Length; i++)
            {
                output[i] = ar1[i] * ar2[i];
            }
            return output;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static double[] AbsArrayElement(double[] input)
        {
            double[] output = new double[input.Length];

            for (int i = 0; i < output.Length; i++)
            {
                output[i] = Math.Abs(input[i]);
            }
            return output;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vector"></param>
        /// <param name="esc"></param>
        /// <returns></returns>
        public static double[] DivEsc(double[] vector, double esc)
        {
            double[] output = new double[vector.Length];

            for (int i = 0; i < output.Length; i++)
            {
                output[i] = vector[i] / esc;
            }
            return output;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vector"></param>
        /// <param name="vector2"></param>
        /// <returns></returns>
        public static double[] DivArrays(double[] vector, double[] vector2)
        {
            double[] output = new double[vector.Length];

            for (int i = 0; i < output.Length; i++)
            {
                output[i] = vector[i] / vector2[i];
            }
            return output;
        }

        /// <summary>
        /// Devuelve un arreglo con el error cuadrático de cada elemento
        /// </summary>
        /// <param name="ar1"> Arreglo de datos 1 </param>
        /// <param name="valor"> Valor deseado para el calculo de los errores </param>
        /// <returns></returns>
        public static double[] SquareError(double[] ar1, double valor)
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
        /// Retorna la suma de los valores de un arreglo
        /// </summary>
        /// <param name = "x"> Arreglo de entrada </param>
        /// <returns></returns>
        public static double Sum(double[] vector)
        {
            double output = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                output = output + vector[i];
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
