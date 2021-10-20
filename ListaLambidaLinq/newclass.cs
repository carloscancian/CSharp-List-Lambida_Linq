using System;

namespace NumerosPrimos
{
    public class newclass : IComparable
    {
       int[] teste = new int[5]{87,58,96,87,58};
        
        /// <summary>
        /// Objeto Numero
        /// </summary>
        /// <value></value>
        public int Numero {get; set;}
        public string Nome {get; set;}

        public newclass(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
        }


        /// <summary>
        /// Metodo Params 
        /// </summary>
        /// <param name="n"></param>
        public void SomaValores(params int[] n)
        {
            int rest = 0;

            if(n.Length < 1  )
            {
                Console.WriteLine("Não possui valores para soma");
            }
            else if(n.Length < 2)
            {
                Console.WriteLine($"Apresentar {n[0]}");
            }
            else
            {
               for(int i = 0; i<n.Length; i++)
               {
                   rest+= n[i];
               }
               Console.WriteLine($"A soma dos valores é: {rest}");
            }
        }

        //Contrato de interface Icomparable (Server para comparar o objeto numero e e funcionar o Sort(Ordenação)
        public int CompareTo(object obj)
        {
            var classe = obj as newclass;

           return Numero.CompareTo(classe.Numero);
        }

            // if(classe == null)
        //     {
        //         return -1;
        //     }

        //     if(Numero < classe.Numero)
        //     {
        //         return -1;
        //     } 

        //     if(Numero == classe.Numero)
        //     {
        //         return 0;
        //     }

        //     return 1;
        // }


        // teste indexadores


        public int this[int i]
        {
            get
            {
                return teste[i];
            }
            set
            {
                if(value < 0)
                {
                    return;
                }
            }
        }
    }
}