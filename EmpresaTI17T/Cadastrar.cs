using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;  //nao pode esquecer de colocar

namespace EmpresaTI17T
{
    public partial class Cadastrar : Form
    {
        DAO conectar;
        public Cadastrar()
        {
            InitializeComponent();
            conectar = new DAO(); //ligando o Formulario ao conector do banco de dados
        }//Fim do construtor

        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //quando ele presionar o botao um vai selecionar tudo que esta aqui
        {
            try
            { 
                string result = conectar.Inserir(Convert.ToInt64(CPF.Text), nome.Text, 
                    telefone.Text, cidade.Text, UF.Text, "pessoa"); //Convert.ToInt64 unico que convert (long)
            MessageBox.Show(result);
            }catch(Exception erro) 
            { 
                MessageBox.Show("Algo deu errado!\n\n" + erro.Message);
            }//fim do try catch
        }//Fim do Botao INSERIR

        private void CPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do CPF

        private void nome_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do Nome

        private void telefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do telefone

        private void cidade_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do CIDADE

        private void UF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do UF
    }
}
