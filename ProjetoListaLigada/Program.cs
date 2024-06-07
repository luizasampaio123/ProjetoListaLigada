using System.Diagnostics;
using static ProjetoListaLigada.Nodo;

namespace ProjetoListaLigada
{
    internal class Program
    {
        public class TestarListaLigadaNaoOrdenada
        {
            public static void Main(String[] args)
            {
                ListaLigadaNaoOrdenada lista = new ListaLigadaNaoOrdenada();
                lista.imprimirLista();
                lista.acrescentarNoFinal(new Nodo(5));
                lista.imprimirLista();
                lista.acrescentarNoFinal(new Nodo(10));
                lista.imprimirLista();
                lista.acrescentarNoFinal(new Nodo(30));
                lista.imprimirLista();


                string op1;
                int op2, n;
                Console.WriteLine("Deseja continuar?");
                op1 = Console.ReadLine();
                do
                    {
                    if (op1 == "sim")
                    {
                        Console.WriteLine("Selecione a opção desejada: \n (1)-Imprimir lista \n (2)-Acrecentar no final \n (3) - Acrecentar no inicio \n (4) - Excluir elemento ");
                        op2=int.Parse(Console.ReadLine());
                        if (op2 == 2 || op2 == 3 || op2 == 4)
                        {
                            Console.WriteLine("Digite o elemento desejado");
                            n = int.Parse(Console.ReadLine());
                            switch (op2)
                            {
                                case 2:
                                    lista.acrescentarNoFinal(new Nodo(n));
                                    Console.WriteLine("Elemento adicionado!");
                                    break;

                                case 3:
                                    lista.acrescentarNoInicio(new Nodo(n));
                                    Console.WriteLine("Elemento adicionado!");
                                    break;

                                case 4:
                                    lista.ExcluirElemento(n);
                                    Console.WriteLine("Elemento removido!");
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            lista.imprimirLista();
                        }
                        Console.WriteLine("Deseja continuar?");
                        op1=Console.ReadLine();
                    }
                    } while (op1 == "sim") ;
            }
        }
    }
}
