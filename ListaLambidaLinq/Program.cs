using System;
using System.Collections.Generic;
using System.Linq;
using NumerosPrimos.Extensoes;

namespace NumerosPrimos
{
    class Program
    {
        static void Main(string[] args)
        {  
            // Testando Extesão de List <int>
            List<int> idades= new List<int>();
            idades.AdicionarVarios(89,98,625);
          
            // Testando Extensão de List <string>  e metodo Sort para ordenação
            List <string> nomes = new List<string>();
            nomes.AdicionarVarios("Carlos","Jorge","Araqueto","BlazeBale");
            nomes.Sort();

            foreach (var nome  in nomes)
            {
               Console.WriteLine(nome);    
            }


            // teste lista

            List<int> numeros = new List<int>();
            List<int> numeros2 = new List<int>();

            numeros.Add(89);
            numeros.Add(78);

            numeros2.AddRange(numeros);
            
            foreach(int c in numeros2)
            {
                Console.WriteLine($"Numeros2:{c}");
            }

            int[] array = new int[]{8,9,5};

            numeros.AddRange(array);

            numeros.Remove(78);
            numeros.RemoveAt(2);

            int valorProcurado = 8;
            bool numeroProcurado;

            numeroProcurado = numeros.Contains(valorProcurado);

            if (numeroProcurado)
            {
                Console.WriteLine("existe");
            }
            else
            {
                Console.WriteLine("Não existe");
            }
            
            foreach(int item in numeros)
            {
                Console.WriteLine(item.ToString());
            }

            
            var testando = new newclass(9,"Ivolanda");
            var testanado01 = new newclass(3,"Joaquim");
            var testanado02 = new newclass(5,"José");
            var testanado03 = new newclass(7,"Augusto");
            var testanado04 = new newclass(5,"Camila");

            testando.Numero = 12;

            // teste indexadores
            Console.WriteLine(testando[3]);
            
            newclass[] teste1 = new newclass[]{testando,testanado01,testanado02,testanado03,testanado04};

            // testando metodo params          
            Console.WriteLine("******************Teste Params ****************** ");

            // chamando metodo params
            testanado01.SomaValores(9,9);

            
            // Teste contrato de interface IComparable
            var ListaClasses = new List<newclass>()
            {
                new newclass(5,"Deuscleide"),
                new newclass(3,"Arnaldo"),
                new newclass(42,"Jonispelson"),
                new newclass(31,"Julhoscreuvis"),
                new newclass(10,"Adamantino"),
                null,
                null,
                null
                   
            };

               //ListaClasses.Sort(); 
               
               /// <summary>
               /// Criado Classe com interface Icompararer para ordenar os nomes;
               /// </summary>
               /// <param name="Comparador.ComparadorNewClassPorNome()"></param>
               /// Implementação do Icomparer com a classe ComparadorNewClassPorNome para teste, logo abaixo se utiliza ByOrder que tambem faz a ordenação porem com menos codigo
               
               
               //ListaClasses.Sort(new Comparador.ComparadorNewClassPorNome());


               //Testando Expressões lambidas / metodos Linq com IEnumerable e IOrderedEnumerable
               // IEnumerable utilizando Where para selecionar apenas NewClass diferentes != de nulo / where tem que retornar um bool 
               // IorderedEnumerable utilizando OrderBy para ordenar os nomes da lista de classes : NewClass

               //IEnumerable<newclass> ListaSemNulos = ListaClasses.Where(ListaClasses => ListaClasses != null);
 

               //IOrderedEnumerable<newclass> ListaOrdenadas = ListaSemNulos.OrderBy(ListaClasses => ListaClasses.Nome );

               //Esta implementação substitui as 2 de cima simplificando e deixando menos verbosa
               var ListaOrdenadas = ListaClasses
               .Where(ListaClasses => ListaClasses != null)
               .OrderBy(ListaClasses => ListaClasses.Nome);

              foreach(var ListaClass in ListaOrdenadas)
              {
                //Console.WriteLine(ListaClass.Numero);
                Console.WriteLine(ListaClass.Nome);
              }  

        }
    }
}


