using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            string optionMenu = ReturnMenu();

            Turma turma = new Turma();

            while (optionMenu.ToUpper() != "X")
            {
                Console.Clear();
                switch (optionMenu)
                {
                    case "1":
                        Console.WriteLine("Voce selecionou a opção 1");
                        Console.WriteLine("\nDigite o nome do Aluno\n");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();
                        Console.WriteLine("\nDigite a nota do Aluno\n");
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            if(nota <= 10 && nota >= 0)
                            {
                                aluno.Nota = nota;
                            }
                            else
                            {
                                throw new ArgumentException("Digite um numero de 0 a 10");
                            }   
                        }
                        else
                        {
                            throw new ArgumentException("Digite um numero decimal");
                        }
                        turma.AddAluno(aluno);
                        Console.Clear();

                        break;
                    case "2":
                        Console.WriteLine("Voce selecionou a opção 2\n");
                        Console.WriteLine("Lista de Alunos na Turma");

                        foreach (var a in turma.lista)
                        {
                            Console.WriteLine($"\n - Nome: {a.Nome} Nota: {a.Nota}");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Voce selecionou a opção 3");
                        decimal media = turma.ReturnMedia();
                        Console.WriteLine($"\nA nota media da turma é: {media}");
                        break;
                    default:
                        Console.WriteLine("Opção Selecionada Não Existe");
                        break;
                }
                optionMenu = ReturnMenu();
            }
        }

        private static string ReturnMenu()
        {
            Console.WriteLine("\nEscolha a opcao do Menu:\n");
            Console.WriteLine("1 - Inserir novo Aluno");
            Console.WriteLine("2 - Listar Alunos");
            Console.WriteLine("3 - Media Geral de Alunos");
            Console.WriteLine("X - Para Sair");
            Console.WriteLine();

            string optionMenu = Console.ReadLine();
            return optionMenu;
        }
    }
}
