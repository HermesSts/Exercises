//Treino de POO sobre construtores e forma diferente
//instaciar objetos.
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

	public static class Program
	{
		public static void Main(String[] args)
		{
		Homem homem1 = new Homem(165, "Marcos", 25);
		Console.WriteLine($"{homem1.Nome} tem {homem1.Idade} anos e mede {homem1.Altura}cm.");
		Homem homem2 = new Homem(170, "Marta", 39);
		Console.WriteLine($"{homem2.Nome} tem {homem2.Idade} anos e mede {homem2.Altura}cm.");

		}

		public class Homem
		{
			public int Altura;
			public string Nome;
			public int Idade;


			public Homem(int altura, string nome, int idade)
			{
				Altura = altura;
				Nome = nome;
				Idade = idade;
				
			}
		}
	}
}


