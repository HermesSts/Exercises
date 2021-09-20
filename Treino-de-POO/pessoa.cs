using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

	static class Program
	{
		static void Main()
		{
			Pessoa x = new Pessoa();
			x.msgn("Luciana", 21);
			
			Pessoa y = new Pessoa();
			y.msgn("Hermes");
			
			Pessoa z = new Pessoa();
			z.msgn();
		}
	}
}

class Pessoa
{

	public void msgn(string nome, int idade)
	{
		int ano = 2021-idade;
		Console.WriteLine(nome + ", você nasceu em "+ano);
	}

	public void msgn()
	{
		Console.WriteLine("Nenhuma entrada!");
	}

	public void msgn(string nome)
	{
		Console.WriteLine("Olá, " + nome);
	}

}