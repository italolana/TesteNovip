using System;
using System.Buffers.Text;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace TesteNovip
{
    internal class Program
    {
        static void Main(string[] args)
        {

           

            string[] vet = new string[10];
            string chave = "ABAABBABAB";


            imprimePossibilidades(vet, chave);


        }



      static void imprimePossibilidades (string[]vet, string chave){



            for (int i = 0; i < 1024; i++)//numero de possibilidades
            {
                for (int j = 0; j < 10; j++)
                {
                    if ((i & (1 << j)) != 0)//incremento B
                    {
                        vet[j] = "B";
                    }
                    else
                    {
                        vet[j] = "A";
                    }
                }

                Console.WriteLine(string.Join("", vet));




                string seq = string.Join("", vet);

                if (seq.Contains(chave))
                {
                    Console.WriteLine("Cadeado quebrado aperte Enter para prosseguir ");
                    Console.ReadLine();
                }
            }
        }
     }
    }

