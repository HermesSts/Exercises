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
			Passaro pombo = new Passaro();
			pombo.cor = "preto";
			pombo.tamanho = 25;
			pombo.voar();

			Passaro rola = new Passaro();
			rola.cor = "azul";
			rola.tamanho = 14;
			rola.voar();
		}

	}
	public class Passaro
	{
		public string cor;
		public int tamanho;

		public void voar()
		{
			Console.WriteLine("um passaro de cor " + cor + " e tamanho " + tamanho + "cm esta voando agora!", cor, tamanho);
		}

	}
}