using Proyecto_EDA_EESA_24.Nodo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
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
        }

        //public int Find(int pos)
        //{

        //}
        public bool Delete(int pos)
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
                        if(s == pos)
                        {

                        }
                    }
                    else
                    {
                        act = act.Sig; s++;
                        if (s == pos)
                        {

                        }
                    }
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
        }



    }
}
