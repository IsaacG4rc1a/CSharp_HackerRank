using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

	// Complete the compareTriplets function below.
	static List<int> compareTriplets(List<int> a, List<int> b)
	{
		int Ar_a = 0, Ar_b = 0, alice = 0, bob = 0;
		List<int> Result = new List<int>();

			for (int j = 0; j < 3; j++)
			{
				Ar_a = a[j];
				Ar_b = b[j];
				if (Ar_a < Ar_b)
				{
					bob += 1;
				}
				if(Ar_a > Ar_b)
				{
					alice += 1;
				}
			}

		Result.Insert(0, alice);
		Result.Insert(1, bob);

		return Result;

	}

	static void Main(string[] args)
	{

		List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

		List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

		List<int> result = compareTriplets(a, b);

		Console.WriteLine(String.Join(" ", result));

		Console.ReadKey();
	}
}
