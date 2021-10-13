using System;
using MATLAB_Library;

namespace AplicacionDeConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] x = MATLAB.Linspace(0.1, 1, 0.1);
            double[] mov = MATLAB.Linspace(0.1, 2.1, 0.1);
            double m1 = 1;
            double b1 = 0;
            double m2 = 0.1;
            double b2 = 0;

            double[] error;
            double[] sumerr;
            double[] y2;

            //Recta 1
            double[] y1 = Arrays.SumArraysEsc(b1, Arrays.MultEsc(m1, x)); 
            
            //========================Desenso Sencillo=====================

            //Paso 1: Valor Aleatorio
            double punto = 0.5;
            y2 = Recta(punto, b2, x);
            double errorAcum = MATLAB.Sum(PorcentajeError(y1, y2));

            //Paso 2:
            //----Punto superior
            double puntoSup = 0.6;
            y2 = Recta(puntoSup, b2, x);
            double errorAcumSup = MATLAB.Sum(PorcentajeError(y1, y2));

            //---Punto inferior
            double puntoInf = 0.4;
            y2 = Recta(puntoInf, b2, x);
            double errorAcumInf = MATLAB.Sum(PorcentajeError(y1, y2));

            //Paso 3: Comparar los puntos y definir direccion.

            if (errorAcumInf < errorAcum)
            {
                punto = puntoSup;
            }
            else
            {
                punto = puntoInf; 
            }

            Console.WriteLine(punto);

            //Prueba de concepto

            y2 = Arrays.MultEsc(mov[1], x);
            y2 = Arrays.SumArraysEsc(b2, y2);

            error = PorcentajeError(y1, y2);
            double SumError = MATLAB.Sum(error);


            Arrays.PrintArray(error);
            Console.ReadLine();


        }

        private static double[] Recta(double punto, double b2, double[] x)
        {
            double[] output = new double[x.Length];
            output = Arrays.MultEsc(punto, x);
            output = Arrays.SumArraysEsc(b2, output);
            return output;
        }
        private static double[] PorcentajeError(double[] err1, double[] err2)
        {
            double[] output = Arrays.DiffArrays(err1,err2);
            output = Arrays.MultEsc(100,Arrays.AbsArrayElement(Arrays.DivArrays(output, err1)));
            
            return output;
        }

    }

}
