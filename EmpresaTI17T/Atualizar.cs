using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaTI17T
{
    public partial class Atualizar : Form
    {
        DAO atu;
        public Atualizar()
        {
            InitializeComponent();
            atu = new DAO();
        }//fim do construtor

        private void Atualizar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            atu.Atualizar(Convert.ToInt64(cpf.Text), "pessoa", "nome", nome.Text);//Atualizo o nome
            atu.Atualizar(Convert.ToInt64(cpf.Text), "pessoa", "telefone", telefone.Text);//Atualizo o telefone
            atu.Atualizar(Convert.ToInt64(cpf.Text), "pessoa", "cidade", cidade.Text);//Atualizo a cidade
            atu.Atualizar(Convert.ToInt64(cpf.Text), "pessoa", "UF", uf.Text);//Atualizo a uf
            MessageBox.Show("Dados Atualizados com Sucesso!");
        }//fim do método atualizar 

        private void cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim do cpf

        private void nome_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim do nome

        private void telefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim do telefone

        private void cidade_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim da cidade

        private void uf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim do uf
    }//fim da classe
}//fim do projeto
