using System;

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
            Console.WriteLine(" (1) -> Abrir arquivo \n (2) -> Criar arquivo  \n (0) -> Sair");

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Open();
                    break;
                case 2:
                    ToEdit();
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

        }

        static void ToEdit()
        {

        }
    }
}
