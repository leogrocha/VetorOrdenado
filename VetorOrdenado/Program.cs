using System;


namespace VetorOrdenado
{
    class Program
    {
        const int tamanho = 5;
        static void Main(string[] args)
        {
            int[] vetor = new int[tamanho];

            criaVetor(vetor);
            ordenaVetor(vetor);

            Console.WriteLine();
            Console.WriteLine("Vetor ordenado: ");
            Console.WriteLine();
            vetorOrdenado(vetor);


        }

        static void criaVetor (int[] vetor)
        {
            for (int i=0; i < tamanho; i++)
            {
                Console.Write("Vetor[" + i + "]: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
        }

        static void ordenaVetor (int[] vetor)
        {
            int aux = 0;
            for (int i = 0; i < tamanho; i++)
            {
                for (int j = 0; j < tamanho; j++)
                {
                   if (vetor[i] < vetor[j])
                    {
                        aux = vetor[i];
                        vetor[i] = vetor[j];
                        vetor[j] = aux;
                    }
                }
            }
        }

        static void vetorOrdenado (int[] vetor)
        {
            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine("Vetor[" + i + "]: " + vetor[i]);
            }
        }

       
    }
}
