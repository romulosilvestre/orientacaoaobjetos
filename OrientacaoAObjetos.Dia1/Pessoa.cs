using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos.Dia1
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Interesse { get; set; }
        public bool Socio { get; set; }
        public decimal Mensalidade { get; set; }

        public bool VerificarSociedade()
        {
            if(Socio)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
