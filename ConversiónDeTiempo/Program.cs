using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversiónDeTiempo
{
	class Program
	{

		static void Main(String[] args)
		{
			var hora = Console.ReadLine();
			var amOPm = hora.Substring(8);
			var ComponenteHora = hora.Substring(0, 2);
			var MinSeg = hora.Substring(2, 6);
			if (amOPm.ToUpper() == "AM" && ComponenteHora == "12")
			{
				ComponenteHora = "00";
			}
			else if (amOPm.ToUpper() == "PM")
			{
				var numericHourComponent = int.Parse(ComponenteHora);
				if (numericHourComponent != 12)
				{
					ComponenteHora = Convert.ToString(12 + numericHourComponent);
				}
			}
			Console.WriteLine(ComponenteHora + MinSeg);

			Console.Read();
		}
	}
}
