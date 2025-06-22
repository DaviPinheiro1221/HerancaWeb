using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColaboradorAPI.Models
{
    public class Menu
    {
        protected int? AdicionarColaborador;
        protected string? AdicionarNome;
        protected int AdicionarIdade;
        protected string? AdicionarCargo;
        protected double AdicionarSalario;
        protected int OpcaoEscolhida;

        enum MenuOrdem { AddName = 1, AddId, AddC, AddS, Sair }

        public void MenuPrincipal()
        {

            Console.WriteLine("1 - Adicionar Colaborador\n2 - Sair\n");
            AdicionarColaborador = Int32.Parse(Console.ReadLine());
            Console.Clear();

            while (AdicionarColaborador != 2)
            {

                bool continuar = true;

                if (AdicionarColaborador != 1)
                {
                    continuar = false;
                }

                while (continuar == true)
                {

                    Console.WriteLine("Menu Principal");
                    Console.WriteLine("\n1 - Adicionar Nome\n2 - Adicionar Idade\n3 - Adicionar Cargo\n4 - Salário\n5 - Sair\n");
                    OpcaoEscolhida = Int32.Parse(Console.ReadLine());
                    MenuOrdem Indexo = (MenuOrdem)OpcaoEscolhida;
                    Console.Clear();

                    switch (Indexo)
                    {
                        case MenuOrdem.AddName:
                            Console.WriteLine("Nome do Colaborador: ");
                            AdicionarNome = Console.ReadLine();
                            Console.Clear();
                            break;

                        case MenuOrdem.AddId:
                            Console.WriteLine("Idade do Colaborador: ");
                            AdicionarIdade = Int32.Parse(Console.ReadLine());
                            Console.Clear();
                            break;

                        case MenuOrdem.AddC:
                            Console.WriteLine("Cargo do Colaborador: ");
                            AdicionarCargo = Console.ReadLine();
                            Console.Clear();
                            break;

                        case MenuOrdem.AddS:
                            Console.WriteLine("Salario do Colaborador: ");
                            AdicionarSalario = Double.Parse(Console.ReadLine());
                            Console.Clear();
                            break;

                        case MenuOrdem.Sair:
                            Console.WriteLine("Saindo do Menu...");
                            continuar = false;

                            break;
                    }
                }
                Console.WriteLine("1 - Adicionar Colaborador\n2 - Sair");
                AdicionarColaborador = Int32.Parse(Console.ReadLine());
                Console.Clear();
            }
            if (!string.IsNullOrWhiteSpace(AdicionarNome) && AdicionarIdade != 0 && !string.IsNullOrWhiteSpace(AdicionarCargo) && AdicionarSalario != 0)
            {
                Console.WriteLine("Colaborador Adicionado com Sucesso!...\n");
                Console.WriteLine($"Colaborador {AdicionarNome}");
                Colaborador colaborador = new(AdicionarNome, AdicionarIdade, AdicionarCargo, AdicionarSalario);
            }
            else if (AdicionarColaborador == 2)
            {
                Console.WriteLine("Operação Encerrada...");
            }
            else
            {
                Console.WriteLine("Dados incompletos. Por favor, preencha todos os campos.");
            }
        }
    }
}
