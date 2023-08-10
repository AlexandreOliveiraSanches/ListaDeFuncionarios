using System;
using System.Globalization;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace TesteListAddExcluir
{
    class Program
    {
        static void Main(string[] args) {

            List<Funcionario> list = new List<Funcionario>();
            Console.Write("Deseja adicionar funcionarios à lista(Y/N)? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 'y' || resp == 'Y') {
                Console.WriteLine();
                Console.Write("Quantos funcionarios serão adicionados? ");
                int n = int.Parse(Console.ReadLine());

                for(int i = 1; i <= n; i++) {
                    Console.WriteLine();
                    Console.WriteLine("Dados do funcionario #" + i + ":");
                    Console.Write("ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Salario: ");
                    double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Funcionario(id, nome, salario));
                }
            }
            else if (resp == 'n' || resp == 'N') {
                Console.WriteLine("Nenhum funcionario será adicionado.");
            }
            else {
                Console.WriteLine("Resposta inválida!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista de funcionarios: ");
            foreach (Funcionario funcionario in list) {
                Console.WriteLine(funcionario);
            }


            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------");


            Console.WriteLine();
            Console.Write("Deseja adicionar um percentual de aumento de salario para algum funcionario(Y/N)? ");
            resp = char.Parse(Console.ReadLine());
            if (resp == 'y' || resp == 'Y') {
                Console.WriteLine();
                Console.Write("Informe o ID do funcionario desejado: ");
                int procurarId = int.Parse(Console.ReadLine());

                Funcionario emp = list.Find(x => x.Id == procurarId);
                if(emp != null) {
                    Console.Write("Porcentagem de aumento: ");
                    double porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    emp.Aumento(porc);

                    Console.WriteLine();
                    Console.WriteLine("Lista atualizada: ");
                    foreach (Funcionario funcionario in list) {
                        Console.WriteLine(funcionario);
                    }
                }
                else {
                    Console.WriteLine("ID inválido!");
                }

            }

            else if ( resp == 'n' || resp == 'N') {
                Console.WriteLine("Nenhum aumento de salario.");
            }

            else {
                Console.WriteLine("Resposta inválida!");
            }


            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------");


            Console.WriteLine();
            Console.Write("Deseja excluir algum funcionario da lista(Y/N)? ");
            resp = char.Parse(Console.ReadLine());
            if (resp == 'y' || resp == 'Y') {
                Console.WriteLine();
                Console.Write("Informe o ID do funcionario: ");
                int excluirId = int.Parse(Console.ReadLine());
                
                Funcionario funcionario = list.Find(x => x.Id == excluirId);
                if(funcionario != null) {
                    list.Remove(funcionario);
                    Console.WriteLine("Funcionario removido com sucesso!");
                    Console.WriteLine();
                    Console.WriteLine("Lista atualizada: ");
                    foreach(Funcionario func in list) {
                        Console.WriteLine(func);
                    }
                }
                else {
                    Console.WriteLine("Funcionario não encontrado!");
                }
            }

            else if (resp == 'n' || resp == 'N') {
                Console.WriteLine("Nenhum funcionario será excluido.");
            }

            else {
                Console.WriteLine("Resposta inválida!");
            }


        }

    }
}