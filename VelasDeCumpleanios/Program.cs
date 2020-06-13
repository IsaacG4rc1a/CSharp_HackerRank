using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VelasDeCumpleanios
{
	class Program
	{
		// Complete the birthdayCakeCandles function below.
		static int birthdayCakeCandles(int[] ar)
		{
			int conteo = 0;
			int max = ar.Max();

			for (int i = 0; i < ar.Length; i++)
			{
				if (max == ar[i])
				{
					conteo++;
				}
			}

			return conteo;

		}

		static void Main(string[] args)
		{

			int arCount = Convert.ToInt32(Console.ReadLine());

			int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
			;
			int result = birthdayCakeCandles(ar);

			Console.WriteLine(result);

			Console.ReadKey();
		}
	}
}
