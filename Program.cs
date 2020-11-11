using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int dia;
            int mes;
            int ano;
            int escolha;

            Console.WriteLine("Sistema de cadastro para auto escolas");
            Console.WriteLine("----------------------------");
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Sejá bem vindo(a) "+nome);
            Console.Write("Para começar seu cadastro, digite o dia de seu nascimento: ");
            dia = int.Parse(Console.ReadLine());
            Console.Write("Digite o mês do seu nascimento: ");
            mes = int.Parse(Console.ReadLine());
            Console.Write("Digite o ano do seu nascimento: ");
            ano = int.Parse(Console.ReadLine());
            if (ano > 1998)
            {
                Console.WriteLine("Você ainda não é maior de idade!");
                Console.Write("Caso tenha inserido o ano errado, digite [1] para corrigir e [2] para finalizar: ");
                escolha = int.Parse(Console.ReadLine());
                while (escolha != 1 && escolha != 2)
                {
                    Console.Write("Opção invalida, apenas [1] ou [2]: ");
                    escolha = int.Parse(Console.ReadLine());
                }
                if (escolha == 1)
                {
                    Console.Write("Digite o ano novamente: ");
                    ano = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Agradecemos o seu acesso!");
                }
            }
        }
    }
}
