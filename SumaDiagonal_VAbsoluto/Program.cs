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
using static System.Console;

class Result
{	
	static void Main(String[] args)
	{
		var sumPrimaryDiagonal = 0;
		var sumSecondaryDiagonal = 0;
		var n = int.Parse(ReadLine());
		for (int i = 0, j = n - 1; i < n; i++, j--)
		{
			var a_temp = ReadLine().Split(' ');
			var newRow = Array.ConvertAll(a_temp, int.Parse);
			sumPrimaryDiagonal += newRow[i];
			sumSecondaryDiagonal += newRow[j];
		}
		WriteLine(Math.Abs(sumPrimaryDiagonal - sumSecondaryDiagonal));
		Console.ReadKey();
	}
}