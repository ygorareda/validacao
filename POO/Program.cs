using System;
using System.Linq;
using static System.Console;
namespace POO
{

    class Program
    {

        static void Main(string[] args)
        {

            string palavra = ReadLine();

            string palavraInvertida = new string(palavra.Reverse().ToArray());

            if (palavra.ToLower() == palavraInvertida.ToLower())
            {
                WriteLine(palavra);
                WriteLine(palavraInvertida);
                WriteLine("É um palindromo");
            }
            else
            {
                WriteLine(palavra);
                WriteLine(palavraInvertida);
                WriteLine("Não é um palindromo");
            }

        }
    }
}







