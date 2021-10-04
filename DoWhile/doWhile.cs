using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

	public static class Program
	{
		public static void Main()
		{
			while (true)
			{
				Console.Write("N: ");
				int n = int.Parse(Console.ReadLine());

				int cont = 1;

				do
				{
					cont *= n;
					n--;
				} while (n > 0);
				Console.WriteLine(cont);
			}


		}
	}
}