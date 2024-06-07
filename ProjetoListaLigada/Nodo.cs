using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoListaLigada
{
    internal class Nodo
    {
        private int chave;
        private Nodo next;
        public Nodo(int chave)
        {
            this.chave = chave;
            next = null;
        }
        public Nodo()
        {
            this.chave = 0;
            next = null;
        }
        public String toString()
        {
            return "Nodo{" + "chave=" + chave + ", next=" + next + '}';
        }
        public int getChave()
        {
            return chave;
        }
        public void setChave(int chave)
        {
            this.chave = chave;
        }
        public Nodo getNext()
        {
            return next;
        }
        public void setNext(Nodo next)
        {
            this.next = next;
        }
    }
        }

            

            
        
