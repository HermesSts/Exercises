using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace primo
{

	public static class Program
	{
		public static void Main()
		{
			bool loop = true;
			Console.WriteLine("Programa Número Primo");

			while (loop == true)
			{
				Console.Write("Digite um número: ");
				int cont = 0;
				int entrada = Convert.ToInt32(Console.ReadLine());

				for (int i = entrada; i > 0; i--)
				{
					if (entrada % i == 0)
					{
						cont++;
					}

				}
				if (cont > 2)
				{
					Console.WriteLine("Não é primo.");
				}
				else
				{
					Console.WriteLine("É primo.");
				}


			}
		}
	}
}

