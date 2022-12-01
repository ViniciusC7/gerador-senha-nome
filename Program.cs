using System;

namespace prog
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano, idade;
            string nome;
            DateTime hoje = DateTime.Today;
            

            Console.WriteLine("Seja bem-vindo, hoje é dia: " + hoje.Day + "/" + hoje.Month  + "/" + hoje.Year +" (" + hoje.DayOfWeek  + ")" );
            Console.WriteLine("Qual é o seu nome? ");
            nome = Console.ReadLine();
            Console.WriteLine("Bem-vindo, " + nome);
            Console.WriteLine("Informe o que ano em que você nasceu ");
            ano = int.Parse(Console.ReadLine());

            idade = hoje.Year - ano;

            if (idade >= 18)
            {
                Console.WriteLine(nome + ", sua senha será: " + "@"+idade + nome );
            }
            else
            {
                Console.WriteLine(nome + ", sua senha será: " + "@"+nome + idade+"$" );
            }

        }
    }
}
