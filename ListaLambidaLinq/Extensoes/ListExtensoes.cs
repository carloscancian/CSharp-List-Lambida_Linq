using System.Collections.Generic;

namespace NumerosPrimos.Extensoes
{
    public static class ListExtensoes
    {
        /// <summary>
        /// Metodo estatico para adicionar varios itens na list
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="itens"></param>
        /// <typeparam name="T"></typeparam>
        public static void AdicionarVarios<T>(this List<T> lista, params T[] itens )
        {
           foreach(T item in itens)
           {
               lista.Add(item);
           }
        }
    }
}