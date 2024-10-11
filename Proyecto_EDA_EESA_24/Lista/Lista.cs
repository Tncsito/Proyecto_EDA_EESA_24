using Proyecto_EDA_EESA_24.Nodo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto_EDA_EESA_24.Lista
{
    public class Lista
    {
        NODO inicio;
        public Lista()
        {
            inicio = null;
        }
        public void Add(int num)
        {
            NODO nuevo = new NODO(num);
            if (inicio == null)
            {
                inicio = nuevo;
            }
            else
            {
                NODO act = inicio;
                while (act.Sig != null)
                {
                    act = act.Sig;
                }
                act.Sig = nuevo;
            }
        } //TERMINADO
        public int Count()
        {
            int s = 0;
            if (inicio == null)
            {
                Console.WriteLine("La lista está vacía");
            }
            else
            {
                NODO act;
                act = inicio;
                while (act != null)
                {
                    if (act.Sig != null)
                    {
                        act = act.Sig; s++;
                    }
                    else
                    {
                        act = act.Sig;s++;
                    }
                }
                Console.WriteLine(s);
            }
            return s;
        } //TERMINADO

        public int Find(int pos)
        {
            int s = 0;
            if (inicio == null)
            {
                Console.WriteLine("La lista está vacía");
            }
            else
            {
                NODO act;
                act = inicio;
                while (act != null)
                {
                    if (act.Sig != null)
                    {
                        act = act.Sig; s++;
                        if (s == pos)
                        {
                            return act.Valor;
                        }
                    }
                    else
                    {
                        act = act.Sig; s++;
                        if (s == pos)
                        {
                            return act.Valor;
                        }
                    }
                }
            }
            return -1;
        }
        public bool Delete(int pos)
        {
            int s = 0;
            NODO act;
            NODO ant;
            act = inicio;
            ant = inicio;
            while (act != null)
            {
                if (act != inicio) //va a entrar hasta que dé un paso act y esté atrás ant
                {
                    ant = ant.Sig; //aquí ant va primero y luego act
                    if (act.Sig != null)
                    {
                        act = act.Sig; s++;
                        if (s == pos)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        act = act.Sig; s++;
                        if (s == pos)
                        {
                            return true;
                        }
                    }
                }
                else
                {
                    act = act.Sig;
                }
            }
            return true;
        }
        //public bool Change(int pos, int num)
        //{

        //}
        //public int FindValue()
        //{

        //}
        public void Print()
        {
            if (inicio == null)
            {
                Console.WriteLine("La lista está vacía");
            }
            else
            {
                NODO act;
                act = inicio;
                while (act != null)
                {
                    Console.Write($"{act.Valor} => ");
                    if (act.Sig != null)
                    {
                        act = act.Sig;
                    }
                    else
                    {
                        act = act.Sig;
                        Console.Write("NULL");
                    }
                }
            }
        } //TERMINADO
    }
}
