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
    public partial class Form1 : Form
    {
        Cadastrar cad;
        Consultar con;
        Atualizar atu;
        Excluir exc;
        DAO consul;

       // DAO conectar; nao precisa masi dele

        public Form1()
        {
            InitializeComponent();
            cad = new Cadastrar();
            con = new Consultar();
            atu = new Atualizar();
            exc = new Excluir();
            consul = new DAO();           
            //conectar = new DAO();//Ligando o conector do Banco  (nao precisa mais dele)
        }//Fim do Construtor
 

        private void button1_Click(object sender, EventArgs e)
        {
            cad.ShowDialog(); //Abre Tela
        }//Fim do Cadastrar

        private void button2_Click(object sender, EventArgs e)
        {
            con.ShowDialog(); //Abre Tela
        }//Fim do Consultar

        private void button3_Click(object sender, EventArgs e)
        {
            atu.ShowDialog(); //Abre Tela
        }//Fim do Atualizar

        private void button4_Click(object sender, EventArgs e)
        {
            exc.ShowDialog(); //Abre Tela
        }//Fim do Excluir

    }
}
