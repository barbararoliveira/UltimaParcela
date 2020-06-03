using System;

namespace UltimaParcela
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Olá usuário, vou ajudá-lo a calcular a data e o valor da sua última parcela.");
            Console.WriteLine(" Pressione enter para continuar:");
            Console.ReadKey();

            Console.WriteLine("Insira o valor do financiamento (R$): ");
            decimal valor = decimal.Parse (Console.ReadLine());

            Console.WriteLine("Insira a quantidade de parcelas mensais (sem juros): ");
            decimal parcela = decimal.Parse (Console.ReadLine());

            decimal up = valor / parcela ; //up= última parcela.
            int parcela1 = decimal.ToInt32(parcela); 

            DateTime hoje = DateTime.Now; 
            DateTime parceladois = hoje.AddMonths(parcela1);
            string pem = Convert.ToString (parceladois); //pem= parcela em meses.
            string parcela3 = parceladois.ToShortDateString();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"Sua última parcela será em {parcela3}, no valor de R${up}.");

        }
    }
}
