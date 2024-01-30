using System;

namespace AppIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = (int)SolicitaInformacao("Digite a tabuada desejada de 0 a 10000: ", "int");

            if (opcao < 0 || opcao > 10000)
            {
                Console.WriteLine("Opção inválida. Por favor, digite um número de 0 a 10000.");
                return;
            }

            int num = 10;
            for (int coluna = 0; coluna < num; coluna++)
            {
                int resultado = opcao * coluna;
                Console.WriteLine($"{opcao} x {coluna} = {resultado}");
            }
            Console.ReadLine();
        }

        static object SolicitaInformacao(string mensagem, string tipo)
        {
            int valor_inteiro;
            decimal valor_decimal;

            if (mensagem.Length > 0)
                Console.WriteLine(mensagem);

            if (tipo == "int")
            {
                int.TryParse(Console.ReadLine(), out valor_inteiro);
                return valor_inteiro;
            }

            if(tipo == "descimal")
            {
                decimal.TryParse(Console.ReadLine(), out valor_decimal);
                return valor_decimal;
            }
            return 0;
        }
    }
}
