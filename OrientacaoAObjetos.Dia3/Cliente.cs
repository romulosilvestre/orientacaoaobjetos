using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos.Dia3
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        //Exercício
        //Crie construtores 
        //Sobrecarregue
        
        //Default
        public Cliente()
        { }

        public Cliente(int id, string nome, string cPF)
        {
            Id = id;
            Nome = nome;
            CPF = cPF;
        }

        public Cliente(string nome, string cPF)
        {
            Nome = nome;
            CPF = cPF;
        }

        public Cliente(int id)
        {
            Id = id;
        }

        public void InserirNoBanco()
        {
            //Passo 1 - Crie uma Connection String
            string connectionString = "Data Source=LAB-F08-28;Initial Catalog=Servicos;User ID=sa;Password=senai@123";

        }

        public bool ValidarCPF(string cpf)
        {
            int[] multiplicadores1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicadores2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            cpf = cpf.Trim().Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
                return false;

            for (int i = 0; i < 10; i++)
            {
                if (cpf.Substring(0, 10) == new string(char.Parse(i.ToString()), 11))
                    return false;
            }

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(tempCpf[i].ToString()) * multiplicadores1[i];
            }

            int resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCpf += digito;
            soma = 0;

            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(tempCpf[i].ToString()) * multiplicadores2[i];
            }

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito += resto.ToString();

            return cpf.EndsWith(digito);
        }

    }
}
