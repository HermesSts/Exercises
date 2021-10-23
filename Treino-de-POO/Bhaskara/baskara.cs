using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

	public static class Baskara
	{
		public static void Main()
		{
			Bhaskara raiz1 = new Bhaskara();
			raiz1.msg(1, 2, -24);
		}
	}
	public class Bhaskara
	{
		public void msg(int a, int b, int c)
		{
			double delta = (b * b - 4 * a * c);

			if (delta < 0)
			{
				Console.WriteLine("Raiz inexistente!");
			}
			else
			{
				double x1 = (-b + Math.Sqrt(delta)) / 2 * a;
				double x2 = (-b - Math.Sqrt(delta)) / 2 * a;
				
				if (x1 == x2)
				{
					Console.WriteLine("Há apenas uma raiz: " + x2);
				}
				else
				{
					Console.WriteLine("Raiz 1 é: " + x1);
					Console.WriteLine("Raiz 2 é: " + x2);
				}
			}
		}
	}
}

