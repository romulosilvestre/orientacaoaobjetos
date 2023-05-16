using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos.Dia2
{
    public class Segurado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        //Construtor Default (padrão)
        //O construtor tem o mesmo da classe
        public Segurado()
        {

        }
        //Construtor com parâmetro
        //Pesquiser por ID
        public Segurado(int id)
        {
            Id = id;
           
        }
        //Construtor com Sobrecarga (Override)
        //Cadastrar - Insert no banco
        public Segurado(string nome)
        {
            Nome = nome;
        }
        public Segurado(string nome,string cpf)
        {
            Nome= nome;
            CPF = cpf;
        }

        public string Teste()
        {
            return "Chegou Aqui!E não é Brazlândia!";
        }
    }
}
