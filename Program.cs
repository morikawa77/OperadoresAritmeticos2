using System;

namespace OperadoresAritmeticos2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			int numero;
			int resto;
			Console.WriteLine("Digite um número");
			numero = Convert.ToInt32(Console.ReadLine());
			resto = numero % 2;
			Console.WriteLine("O resto da divisão de {0} por 2 é {1}.", numero, resto);
			Console.ReadLine();
        }
    }
}
