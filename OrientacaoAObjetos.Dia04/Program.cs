using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos.Dia04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Alo Mundo");
            //int[] notas = new int[10];
            //int soma=0;
            //for (int i = 0; i <notas.Length; i++)
            //{
            //    Console.WriteLine($"{i}-Digite a nota:");
            //    notas[i] = int.Parse(Console.ReadLine());
            //    soma = soma + notas[i];

            //}
            //Console.WriteLine($"Total das Notas: {soma}");

            //Matrizes
            /*
             * Vetor: Matriz Unidimensional
             * Matriz : É uma tabela bidimensional
             * 3D : Matriz tridimensional -linha coluna folha
             */
            int[,] matrizQuadrada = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"{i}-{j} Digite um número:");
                    matrizQuadrada[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine($"Diagonal principal:{matrizQuadrada[i, j]}");
                    }
                }
            }
            Console.ReadKey();
            //Console.WriteLine("*******Mostrando os dados:******");
            //foreach (var item in matrizQuadrada)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            //Console.ReadKey();
        }
    }
}
