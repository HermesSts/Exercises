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
				int cont = 1;
				int soma = 1;
				Console.WriteLine("Numero: ");
				int entrada = Convert.ToInt32(Console.ReadLine());
				
				if (entrada >= 350)
				{
					while (cont < entrada)
					{
						soma += cont;
						cont++;
					}
					Console.WriteLine("A soma é: " + soma);
				}
				else
				{
					Console.Write("A soma de 1");
					while (cont < entrada)
					{
						cont++;
						Console.Write("+" + cont);
						soma += cont;
					}
					Console.WriteLine(" é = " + soma);
				}
			}
		}
	}
}