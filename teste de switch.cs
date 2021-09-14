using System;

namespace CSharp_Shell
{

	public class Teste_de_switch
	{
		static void Main()
		{
			int cachorro = 7;
			switch (cachorro)
			{
				case 1:
					Console.WriteLine("bulldog");
					break;
				case 2:
					Console.WriteLine("viralata");
					break;
				default:
					Console.WriteLine("nenhum");
					break;
			}

		}
	}
}
