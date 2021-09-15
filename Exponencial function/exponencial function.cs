using System;

namespace CSharp_Shell
{

	public static class Program
	{
		public static void Main()
		{
			Console.Write("Numero ");
			string entrada1 = Console.ReadLine();
			Convert.ToInt32(entrada1);

			Console.Write("Elevado a ");
			string entrada2 = Console.ReadLine();
			Convert.ToInt32(entrada2);

			Console.Write(elevado(Convert.ToInt32(entrada1), Convert.ToInt32(entrada2)));
			Console.ReadLine();

		}

		static int elevado(int num1, int num2)
		{
			int result = 1;
			for (int i = 0; i < num2; i++)
			{
				result = result * num1;
			}
			return result;
		}
	}
}