using System;
using MATLAB_Library;

namespace AplicacionDeConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] x = MATLAB.Linspace(0.1, 1.1, 0.1);
            double m1 = 1;
            double b1 = 0;
            double m2 = 0.2;
            double b2 = 0;

            double[] y1 = Arrays.MultEsc(m1, x);
            y1 = Arrays.SumArraysEsc(b1, y1);

            double[] y2 = Arrays.MultEsc(m2, x);
            y2 = Arrays.SumArraysEsc(b2, y2);

            double[] error = Arrays.DiffArrays(y1, y2);
            error = Arrays.AbsArrayElement(error);
            error = Arrays.DivArrays(error, y1);
            error = Arrays.MultEsc(100, error);
            Arrays.PrintArray(error);

            double sumerr = MATLAB.Sum(error);

            double[] M = MATLAB.Linspace(0.1, 2, 0.1);
            double[] vec_error = new double[M.Length];

            //prueba
            for (int i = 0; i < vec_error.Length; i++)
            {
                y2 = Arrays.MultEsc(M[i], x);
                y2 = Arrays.SumArraysEsc(b2, y2);

                error = Arrays.DiffArrays(y1, y2);
                error = Arrays.AbsArrayElement(error);
                error = Arrays.DivArrays(error, y1);
                error = Arrays.MultEsc(100, error);
                vec_error[i] = MATLAB.Sum(error);
            }

            
            Console.ReadLine();


        }
    }

}
