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
			double[] x = { 0, .1, .2, .3, .4, .5, .6, .7, .8, .9, 1 };
			double m1 = 1;
			double b1 = 0;
			double m2 = 1;
			double b2 = 0;

			double[] y1 = SumArrayEsc(MultEs(x,1),b1);
			double[] y2 = SumArrayEsc(MultEs(x, 1),b2);

			double[] error;
			double[] SumError;

			

			Console.Read();

		}
		static public double[] MultEs(double[] a, double e)
		{
			double[] output = new double[a.Length];
			for (int i = 0; i < a.Length; i++)
			{
				output[i] = e * a[i];
			}
			return output;
		}
		static double[] SumArrayEsc(double[] ar1, double esc)
		{
			double[] output = new double[ar1.Length];
			for (int i = 0; i < ar1.Length; i++)
			{
				output[i] = ar1[i] + esc;
			}
			return output;
		}
	}

}
