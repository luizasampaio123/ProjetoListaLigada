using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoListaLigada
{
    internal class ListaLigadaNaoOrdenada
    {
        private Nodo primeiro;
        private Nodo ultimo;
        public ListaLigadaNaoOrdenada()
        {
            primeiro = null;
            ultimo = null;
        }
        public Nodo getNodo()
        {
            return new Nodo();
        }
        public void imprimirLista()
        {
            Nodo aux = primeiro;
            while (aux != null)
            {
                Console.WriteLine(aux.getChave());
                aux = aux.getNext();
            }
        }
        public void acrescentarNoFinal(Nodo item)
        {
            Nodo aux;
            if (ultimo == null)
            {
                aux = this.getNodo();
                primeiro = aux;
                ultimo = aux;
                aux.setChave(item.getChave());
            }
            else
            {
                aux = this.getNodo();
                ultimo.setNext(aux);
                ultimo = aux;
                aux.setChave(item.getChave());
            }
        }
        public void acrescentarNoInicio(Nodo item)
        {
            item.setNext(primeiro);
            primeiro = item;
        }

        public void ExcluirElemento(int chave)
        {
            if (primeiro == null) return;

            if (primeiro.getChave() == chave)
            {
                primeiro = primeiro.getNext();
                if (primeiro == null)
                {
                    ultimo = null;
                }
                return;
            }
        }
    }
}
