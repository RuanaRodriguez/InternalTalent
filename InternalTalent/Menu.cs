﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalTalent
{
    internal class Menu
    {
        public static void MenuPrincipal()
        {
            int opcao = 0;

            while (opcao != 5)
            {
                Console.WriteLine("Sejam bem-vindos ao Internal Talent\n");
                Console.WriteLine("1 - Adicionar Talento");
                Console.WriteLine("2 - Listar Talentos");
                Console.WriteLine("3 - Atualizar Talentos");
                Console.WriteLine("4 - Remover Talentos");
                Console.WriteLine("5 - Sair\n");

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
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opção inválida\n");
                        Console.ResetColor();
                        break;

                }
            }
        }

    }
}
