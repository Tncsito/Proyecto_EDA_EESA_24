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
        //public int Count()
        //{

        //}
        //public int Find(int pos)
        //{

        //}
        //public bool Delete(int pos)
        //{

        //}
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
                    Console.WriteLine($"{act.Valor}");
                    act = act.Sig;
                }
            }
        }



    }
}
