using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aleatorios
{
	class Program
	{
		static void Main(string[] args)
		{
			// Crear objeto. Utiliza el reloj del sistema para crear una semilla.
			List<int> list = new List<int>();
			int n = 10;
			Random rnd = new Random();

			for (int j = 0; j < n; j++)
			{
				int valor = rnd.Next(1, 10);

				if (!list.Contains(valor))
				{
					list.Add(valor);
				}
			}
			int i = list.Count;
			foreach (var item in list)
			{
				if (i < 10)
				{
					int valor = rnd.Next(1, 10);
					if (!list.Contains(valor))
					{
						list.Add(valor);
						i++;
					}
				}
				if (i == 10)
				{
					break;
				}
				Console.Write(item + " ");
			}

			Console.ReadKey();
		}
	}
}
