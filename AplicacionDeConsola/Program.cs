using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MATLAB_Library;

namespace AplicacionDeConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] x = MATLAB.Linspace(0, 1, 0.1);
            double m1 = 1;
            double b1 = 0;
            double m2 = 0.1;
            double b2 = 0;

            double[] y1 = MultEsc(m1, x);
            y1 = SumArrays(b1, y1);

            double[] y2 = MultEsc(m2, x);
            y2 = SumArrays(b2, y2);

            double[] error = DiffArrays(y1, y2);
            error = AbsArrayElement(error);
            error = DivArrays(error, y1);
            error = MultEsc(100, error);

            double sumerr = Sum(error);



            double[] mov = MATLAB.Linspace(0.1, 2, 0.1);
            double[] verr = new double[mov.Length];

            //prueba
            for (int i = 0; i < verr.Length; i++)
            {
                y2 = MultEsc(mov[i], x);
                y2 = SumArrays(b2, y2);

                error = DiffArrays(y1, y2);
                error = AbsArrayElement(error);
                error = DivArrays(error, y1);
                error = MultEsc(100, error);
                verr[i] = Sum(error);
            }

            F_Arrays.PrintArray(verr);
            Console.ReadLine();


        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="b"></param>
        /// <param name="vector"></param>
        /// <returns></returns>
        private static double[] SumArrays(double b, double[] vector)
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
        private static double[] MultEsc(double esc, double[] vector)
        {
            double[] output = new double[vector.Length];

            for (int i = 0; i < output.Length; i++)
            {
                output[i] = vector[i] * esc;
            }
            return output;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        private static double Sum(double[] vector)
        {
            double output = 0;

            for (int i = 1; i < vector.Length; i++)
            {
                output = output + vector[i];
            }
            return output;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static double[] AbsArrayElement(double[] input)
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
        private static double[] div(double[] vector, double esc)
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
        private static double[] DivArrays(double[] vector, double[] vector2)
        {
            double[] output = new double[vector.Length];

            for (int i = 0; i < output.Length; i++)
            {
                output[i] = vector[i] / vector2[i];
            }
            return output;
        }
    }

}
