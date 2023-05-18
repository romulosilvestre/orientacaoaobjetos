using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos.Dia4Laboratorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] meuVetor = new int[5];
            for(int i = 0; i < meuVetor.Length; i++)
            {
                Console.WriteLine("Digite um número");
                int valor = int.Parse(Console.ReadLine());
                meuVetor[i] = valor;
            }
            Console.WriteLine("Mostrando Valores");
            foreach(int item in meuVetor)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
}
