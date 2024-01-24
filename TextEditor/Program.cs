using System;
using System.IO;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que você deseja fazer? ");
            Console.WriteLine(" (1) -> Abrir arquivo \n (2) -> Criar arquivo  \n (3) -> Deletar arquivo \n (0) -> Sair");

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Open();
                    break;
                case 2:
                    ToEdit();
                    break;
                case 3:
                    DeleteFile();
                    break;
                case 0:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Valor inválido.");
                    break;
            }
        }

        static void Open()
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo?");
            string path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine(" ");
            Console.ReadLine();
            Menu();
        }

        static void ToEdit()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
            Console.WriteLine("-----------------------");
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Save(text);

        }

        static void Save(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho para salvar o arquivo?");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo {path} salvo com sucesso!");
            Console.ReadLine();
            Menu();
        }

        static void DeleteFile()
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo que deseja excluir?");

            string path = Console.ReadLine();

            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine($"Arquivo {path} deletado com sucesso!");
            }
            else
            {
                Console.WriteLine($"Arquivo {path} não encontrado!");
            }

            Console.ReadLine();
            Menu();
        }
    }
}
