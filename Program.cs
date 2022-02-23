using System;

namespace AgendaFuncao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contato[] agenda = new Contato[5];
            int opcao = 0, indice = 0;
            
            do
            {
                opcao = Menu();

                switch (opcao)
                {
                    case 1:
                        Inserir(agenda, indice);
                        indice++;
                        break;
                    case 2:
                        Imprimir(agenda, indice);
                        break;
                    case 3:
                        Buscar(agenda, indice);
                        break;
                    case 4:
                        Remover(agenda, indice);
                        indice--;
                        break;                        
                    case 5:
                        Console.Clear();
                        Console.WriteLine("=====SAINDO...=====");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("=====OPÇÃO INVALIDA=====");
                        Console.ReadKey();
                        break;

                }

            } while (opcao != 5);
        }

        static int Menu()
        {
            Console.Clear();
            int opcaoMenu = 0;
            Console.WriteLine("===== Menu =====");
            Console.WriteLine("\n1 - Inserir Contato \n2 - Imprimir Contatos \n3 - Buscar Contato\n4 - Remover Contato\n5 - Sair ");
            opcaoMenu = int.Parse(Console.ReadLine());

            return opcaoMenu;
        }

        public static void Inserir(Contato [] agenda, int indice)
        {
            Console.Clear();
            string nome;
            int telefone, idade;
            char sexo;           


            if (indice < agenda.Length)
            {
                Console.WriteLine("======INSIRA UM CONTATO======\n");
                Console.WriteLine("Digite o nome: ");
                nome = Console.ReadLine();
                Console.WriteLine("Telefone: ");
                telefone = int.Parse(Console.ReadLine());
                Console.WriteLine("Idade: ");
                idade = int.Parse(Console.ReadLine());
                do
                {
                    Console.WriteLine("Sexo: ");
                    sexo = char.Parse(Console.ReadLine());
                } while (sexo != 'M' & sexo != 'm' & sexo != 'F' & sexo != 'f');


                agenda[indice] = new Contato(nome, telefone, idade, sexo);


                for (int i = 0; i < indice; i++)
                {
                    for (int j = i + 1; j < indice; j++)
                    {
                        if (String.Compare(agenda[i].Nome,agenda[j].Nome) > 0)
                        {
                            Contato aux = agenda[i];
                            agenda[i] = agenda[j];
                            agenda[j] = aux;
                        }
                    }
                }

            }
            else
            {
                Console.WriteLine("\n=====AGENDA CHEIA=====\n");
            }
            Console.ReadKey();

        }

        public static void Imprimir(Contato[] agenda, int indice)
        {
            Console.Clear();
            if (indice == 0)
            {
                Console.WriteLine("\n=====NÃO HÁ CONTATOS CADASTRADOS=====\n");
            }
            else
            {
                Console.WriteLine("=====IMPRIMIR RESULTADOS=====\n");
                for (int i = 0; i < indice; i++)
                {
                    Console.WriteLine(agenda[i].ToString());
                    Console.WriteLine(indice);
                }
            }
            Console.ReadKey();
            
        }

        public static void Buscar(Contato[] agenda, int indice)
        {
            Console.Clear();
            if (indice == 0)
            {
                Console.WriteLine("\n=====NÃO HÁ CONTATOS CADASTRADOS=====\n");
            }
            else
            {
                string nomeBusca;
                int achou = 0;

                Console.WriteLine("Digite um nome a ser buscado: ");
                nomeBusca = Console.ReadLine();

                for (int i = 0; i < indice; i++)
                {
                    if (agenda[i].Nome.Equals(nomeBusca))
                    {
                        Console.WriteLine("\nDados do Contato Buscado:\n");
                        Console.WriteLine(agenda[i].ToString());
                        achou++;
                    }
                }

                if (achou == 0)
                {
                    Console.WriteLine("\n=====ESSE CONTATO NÃO ESTÁ CADASTRADO=====\n");
                }
            }
            Console.ReadKey();

        }

        public static void Remover (Contato[] agenda, int indice)
        {
            Console.Clear();
            if (indice == 0)
            {
                Console.WriteLine("\n=====NÃO HÁ CONTATOS CADASTRADOS=====\n");
            }
            else
            {
                string nomeRemove;
                int achou = 0, i;

                Console.WriteLine("Digite um nome a ser Removido: ");
                nomeRemove = Console.ReadLine();

                for (i = 0; i < indice; i++)
                {
                    if (agenda[i].Nome.Equals(nomeRemove))
                    {
                        achou++;
                        break;
                    }
                }

                if (achou == 0)
                {
                    Console.WriteLine("\n=====ESSE CONTATO NÃO ESTÁ CADASTRADO=====\n");
                }
                else
                {
                    if(indice == 1)
                    {
                        indice--;
                    }
                    else
                    {
                        for(; i < indice; i++)
                        {
                            Contato aux = agenda[i];
                            agenda[i] = agenda[i + 1];
                        }
                        indice--;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
