using System.Collections;
using System.Collections.Generic;

namespace NumerosPrimos.Comparador
{
     public class ComparadorNewClassPorNome : IComparer<newclass>
     {
        public int Compare(newclass x, newclass y)
           {
             return x.Nome.CompareTo(y.Nome);
           }
      }
}