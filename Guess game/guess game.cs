using System;

namespace CSharp_Shell
{

	public class Guess_game
	{
		static void Main(string[] args)
		{
			string secretWord = "macaco";
			int chances = 4;
			int contaChance = 0;
			int countTip = 0;
			string[] tips = { "animal", "engracado", "símeo" };
			while (chances <= 4)
			{
				Console.Write("Digite a palavra ou digite 'dica': \n");
				string word = Console.ReadLine();

				if (word == secretWord)
				{
					Console.Write("Voce acertou!");
					break;

				}
				else if (word == "dica" && countTip <= 2)
				{
					Console.WriteLine(tips[countTip]);
					countTip++;


				}
				else if (word != "dica" || word != secretWord)
				{
					if (contaChance < 4)
					{
						Console.WriteLine("Digite outra palavra!:\n ");
						contaChance++;
					}
					else if (contaChance == chances)
					{
						Console.Write("Fim das chances!");
						break;
					}
				}
				if (word == "dica" && countTip == 3)
				{
					Console.Write("Acabou as dicas!\n");
				}



			}
		}
	}
}
