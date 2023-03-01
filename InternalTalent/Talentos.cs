using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalTalent
{
    internal class Talentos
    {
        static List<Talentos> talento = new List<Talentos>();
        public Talentos() { }
        public Talentos(int id, string nome, string cargo, int idade, string ca)
        {
            this.Id = id;
            this.Nome = nome;
            this.Cargo = cargo;
            this.Idade = idade;
            this.CA = ca;
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public int Idade { get; set; }
        public string CA { get; set; }


        public static void Adicionar()
        {
            Talentos talentos = new Talentos();

            Console.Clear();
            Console.WriteLine("Registre um Id para esse usuário:");
            talentos.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Cadastre seu nome:");
            talentos.Nome = Console.ReadLine();
            Console.WriteLine("Informe seu cargo");
            talentos.Cargo = Console.ReadLine();
            Console.WriteLine("Informe sua idade:");
            talentos.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o nome do(a) seu CA:");
            talentos.CA = Console.ReadLine();


            talento.Add(talentos);
            Console.Clear();
            Menu.MenuPrincipal();
        }

        public static void Listar()
        {
            Console.Clear();
            Console.WriteLine("Lista de talentos:\n");

            if (talento.Count == null || !talento.Any())
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Não existe nenhum talento dentro da lista.\n");
                Console.ResetColor();
                Console.WriteLine("\nPressione ENTER, para voltar ao Menu principal...");
                Console.ReadKey();
                Console.Clear();

            }


            foreach (Talentos talentos in talento)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"ID: {talentos.Id} | " +
                                 $"O nome é: {talentos.Nome} | " +
                                 $"O cargo é: {talentos.Cargo} | " +
                                 $"A idade é: {talentos.Idade} | " +
                                 $"O nome do CA é: {talentos.CA} ");
                Console.ResetColor();
            }
            Console.WriteLine("\nPressione ENTER, para voltar ao Menu principal...");
            Console.ReadKey();
            Console.Clear();

        }

        public static void Atualizar()
        {
            Console.Clear();
            Console.WriteLine("Digite o ID da pessoa que deseja atualizar:");
            int id = int.Parse(Console.ReadLine());

            Talentos talentos = talento.Find(t => t.Id == id);

            if (talentos == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Não existe nenhum usuário com este ID");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine($"Pessoa encontrada com N° de ID: {talentos.Id}, e nome: {talentos.Nome}\n");

                Console.WriteLine("Informe o nome correto:");
                string novoNomeTalento = Console.ReadLine();
                talentos.Nome = novoNomeTalento;

                Console.WriteLine("Informe o cargo correto:");
                string novoCargo = Console.ReadLine();
                talentos.Cargo = novoCargo;

                Console.WriteLine("Informe a idade correta:");
                int novaIdade = int.Parse(Console.ReadLine());
                talentos.Idade = novaIdade;

                Console.WriteLine("Informe o nome correto do seu CA:");
                string novoCA = Console.ReadLine();
                talentos.CA = novoCA;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nTalento atualizado com sucesso!");
                Console.ResetColor();

                Console.WriteLine("Pressione ENTER, para voltar ao Menu principal...");
                Console.ReadKey();
                Console.Clear();
            }

        }

        public static void Remover()
        {
            Console.Clear();
            Console.Write("Digite o ID da pessoa que deseja remover:");
            int id = int.Parse(Console.ReadLine());

            Talentos talentos = talento.Find(t => t.Id == id);

            if (talentos == null || !talento.Any())
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ID não encontrado!");
                Console.ResetColor();
            }

            else
            {
                Console.WriteLine($"ID: {talentos.Id}\n" +
                                 $"O nome é: {talentos.Nome}\n" +
                                 $"O cargo é: {talentos.Cargo}\n" +
                                 $"A idade é: {talentos.Idade}\n" +
                                 $"O nome do CA é: {talentos.CA}\n");


                Console.WriteLine("Tem certeza que deseja remover?\n 1 - Sim | 2 - Não ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        talento.Remove(talentos);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("ID removido com sucesso!");
                        Console.ResetColor();
                        break;
                    case 2:
                        Console.WriteLine("Redirecionando para o Menu...");
                        Thread.Sleep(1000);
                        Console.Clear();
                        Menu.MenuPrincipal();
                        break;
                }

            }
            Console.WriteLine("\nPressione ENTER, para voltar ao Menu principal...");
            Console.ReadKey();
            Console.Clear();

        }

    }
}
