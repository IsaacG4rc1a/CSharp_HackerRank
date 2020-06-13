using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasMenos
{
	class Solution
	{

		static void Main(string[] args)
		{
			int n = Convert.ToInt32(Console.ReadLine());

			int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
			

			//string Retorno = plusMinus(arr);
			decimal positivos = 0, negativos = 0, ceros = 0;

			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] > 0)
				{
					positivos += 1;
				}
				else if (arr[i] < 0)
				{
					negativos += 1;
				}
				else
				{
					ceros += 1;
				}
			}
			positivos = positivos / arr.Length;
			negativos = negativos / arr.Length;
			ceros = ceros / arr.Length;
			Console.WriteLine(string.Format("{0:0.000000}", positivos));
			Console.WriteLine(string.Format("{0:0.000000}", negativos));
			Console.WriteLine(string.Format("{0:0.000000}", ceros));
			Console.ReadKey();
		}
	}
}
