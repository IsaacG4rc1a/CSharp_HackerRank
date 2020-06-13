using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escalera
{
	class Program
	{

		static void Main(string[] args)
		{
			int T = Convert.ToInt16(Console.ReadLine());

			// loop over number of rows
			for (short i = 1; i <= T; ++i)
			{
				for (int j = 1; j <= T; ++j)
				{
					if (j <= T - i)
					{
						Console.Write(" ");
					}
					else
					{
						Console.Write("#");
					}
				}
				Console.WriteLine();
			}
			Console.Read();
		}
	}
}
