//Programa que recebe um valor maximo, soma os
//multiplos de 3 e 5 e mostra na tela.
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

	static class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Digite numero: ");
			string tamanho = Console.ReadLine();
			int maximo = Convert.ToInt32(tamanho);


			int contador = 0;

			for (int i = 0; i <= maximo; i++)
			{
				if ((i % 3) == 0)
				{
					contador += i;

				}
				if ((i % 5) == 0)
				{

					contador += i;
				}

			}
			Console.WriteLine(contador);

		}
	}
}