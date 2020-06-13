using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

	/*
     * Retorna la suma de una matríz.
     */
	public static int SumaArreglo(int[] arreglo)
	{
		int Suma = 0;
		for (int i = 0; i < arreglo.Length; i++)
		{
			Suma += arreglo[i];
		}
		return Suma;
	}
	//Metodo pr
	static void Main(string[] args)
	{

		int arCount = Convert.ToInt32(Console.ReadLine());

		int[] arreglo = new int[arCount];
		arreglo = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

		int result = SumaArreglo(arreglo);

		Console.WriteLine(result);

		Console.ReadKey();
	}
}
