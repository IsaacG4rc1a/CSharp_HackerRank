using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumerosAleatorios
{
    public class Aleatorio
	{
		static void Main(string[] args)
		{
			// Crear objeto. Utiliza el reloj del sistema para crear una semilla.
			Random rnd = new Random();

			int Cantidad = 1;
			string res = " ";
			Cantidad = int.Parse(Console.ReadLine());

			for (int i = 0; i < Cantidad; i++)
			{
				res += rnd.Next(1, 1000);
			}
			Console.Write(res);

			Console.ReadKey();
		}
	}
}
