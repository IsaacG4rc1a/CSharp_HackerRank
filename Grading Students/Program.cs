using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grading_Students
{
	class Program
	{
		static int[] solve(int[] grades)
		{
			for (int i = 0; i < grades.Length; i++)
			{
				var item = grades[i];
				if (item >= 38)
				{
					var diff = 5 - (item % 5);
					if (diff < 3)
						grades[i] = item + diff;
				}
			}

			return grades;
		}

		static void Main(String[] args)
		{
			int n = Convert.ToInt32(Console.ReadLine());
			int[] grades = new int[n];
			for (int grades_i = 0; grades_i < n; grades_i++)
				grades[grades_i] = Convert.ToInt32(Console.ReadLine());

			int[] result = solve(grades);
			Console.WriteLine(String.Join("\n", result));

			Console.ReadKey();
		}
	}
}
