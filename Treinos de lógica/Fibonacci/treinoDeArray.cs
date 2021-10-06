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
           string[] nomes = new string[]{"Luciana", "Hermes", "Ezra","Mickael"};
           for(int i = 0; i<4; i++){
           		Console.Write(nomes[i]+", ");
           }
        }
    }
}