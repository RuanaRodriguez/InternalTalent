using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalTalent
{
    public class Menu
    {
        public static void MenuPrincipal()
        {
            int opcao = 0;

            while (opcao != 5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Sejam Bem-Vindos(a) ao Internal Talent\n");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("1 - Adicionar Talentos");
                Console.WriteLine("2 - Listar Talentos");
                Console.WriteLine("3 - Atualizar Talentos");
                Console.WriteLine("4 - Remover Talentos");
                Console.WriteLine("5 - Sair\n");
                Console.ResetColor();
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Talentos.Adicionar();
                        break;
                    case 2:
                        Talentos.Listar();
                        break;
                    case 3:
                        Talentos.Atualizar();
                        break;
                    case 4:
                        Talentos.Remover();
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nO programa está sendo encerrado, até logo...");
                        Console.ResetColor();
                        Thread.Sleep(1000);
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opção inválida\n");
                        Console.ResetColor();
                        CallbackMenu();
                        break;
                }
            }
        }

        public static void CallbackMenu()
        {
            Console.WriteLine("\nPressione ENTER, para voltar ao Menu Principal...");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
