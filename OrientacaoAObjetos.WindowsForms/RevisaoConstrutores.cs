using OrientacaoAObjetos.Dia3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrientacaoAObjetos.Dia3.DAL;


namespace OrientacaoAObjetos.WindowsForms
{
    public partial class RevisaoConstrutores : Form
    {
        public RevisaoConstrutores()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();//vazio
            cliente.Nome = txtNome.Text;//set
            cliente.CPF = txtCpf.Text;//set
            //get
            MessageBox.Show(cliente.Nome);
            MessageBox.Show(cliente.CPF);
           // ClienteDAL cli = new ClienteDAL(); ;
            //cli.Inserir(cliente);

            using (var context = new ServicosEntities())
            {
                Segurado novoSegurado = new Segurado
                {
                    Nome = "João"
                    // Atribua valores para outras propriedades, se necessário
                };

                context.Seguradoes.Add(novoSegurado);
               
                context.SaveChanges();
            }



        }
    }
}
