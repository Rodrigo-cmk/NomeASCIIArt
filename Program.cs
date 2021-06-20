using System;
using Figgle;

namespace NomeASCIIArt
{
    class Program
    {
        static void Main(string[] args)
        {

            BoasVindas();

            Principal();

        }

        static void BoasVindas()
        {
            Console.Clear();
            DateTime agora = DateTime.Now;

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($" -- Exercício NomeASCIIArt -- ");
            Console.WriteLine($"                       {agora}");
            Console.ResetColor();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("-");
            Console.ResetColor();
            Console.Write(" Solicitação do nome do usuário.");
            Console.WriteLine(" Exibição em ASCII Art, usando o Figgle. ");
            Console.WriteLine();
        }

        static void Principal()
        {
            string resposta;

            do
            {
                string solicitacao;
                string fonte;

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("=> ");
                Console.ResetColor();
                Console.Write("Digite seu nome: ");
                solicitacao = Console.ReadLine();
                Console.WriteLine();

                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("=> ");
                Console.ResetColor();
                Console.WriteLine("Fontes disponíveis: ");
                Console.WriteLine("|");

                Console.WriteLine("|1 --> Alpha (Não recomendado para nomes grandes). ");
                Console.WriteLine("|2 --> Épico. ");
                Console.WriteLine("|3 --> Arredondado. ");
                Console.WriteLine("|");

                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("=> ");
                Console.ResetColor();
                Console.Write("Escolha a fonte (Por Número): ");
                fonte = Console.ReadLine();

                Console.Clear();
                switch (fonte)
                {
                    case "1":
                        Console.WriteLine("------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine($"--> Exibição de {solicitacao} com a fonte número {fonte}.");
                        Console.ResetColor();
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine(FiggleFonts.Alpha.Render($"{solicitacao}"));
                        break;

                    case "2":
                        Console.WriteLine("------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine($"--> Exibição de {solicitacao} com a fonte número {fonte}.");
                        Console.ResetColor();
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine(FiggleFonts.Epic.Render($"{solicitacao}"));
                        break;

                    case "3":
                        Console.WriteLine("------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine($"--> Exibição de {solicitacao} com a fonte número {fonte}.");
                        Console.ResetColor();
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine(FiggleFonts.Rounded.Render($"{solicitacao}"));
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Atenção!! Digite um valor válido.");
                        Console.ResetColor();
                        break;
                }
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Deseja continuar?");
                Console.ResetColor();
                Console.Write(" ('Sim' para prosseguir / 'Qualquer tecla para sair'): ");
                resposta = Console.ReadLine().ToUpper();

                Console.WriteLine();

            } while (resposta == "SIM");
        }
    }
}
