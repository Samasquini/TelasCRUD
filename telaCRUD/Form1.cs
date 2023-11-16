using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telaCRUD
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = Nome.Text;
            string funcao = Funcao.Text;
            string endereco = Endereco.Text;
            string estado_civil = EstadoCivil.Text;
            string telefone = Telefone.Text;
            bool teste_cpf = ValidarCPF.ValidaCpf(CPF.Text);
            string cpf = "";
            if (teste_cpf )
            {
                cpf = CPF.Text;
            }
            else
            {
                MessageBox.Show("Cpf invalido.");
            }
            string rg = RG.Text;
            string email = (Email.Text + "@gmail.com");
            double teste = Convert.ToDouble(Salario.Text);
            double salario = 0;
            if (teste>0)
            {
                salario = teste;
            }
            else
            {
                MessageBox.Show("Salario invalido.");
            }
            DateTime data_nascimento = Convert.ToDateTime(DataNascimento.Text);
            Funcionario fun = new Funcionario(nome,funcao,endereco, estado_civil, telefone, cpf,rg,email,salario,data_nascimento);
            Nome.Text = "";
            Telefone.Text = "";
            Funcao.Text = "";
            Endereco.Text = "";
            CPF.Text = "";
            Email.Text = "";
            RG.Text = "";
            EstadoCivil.Text = "";
            DataNascimento.Text = "";
            Salario.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
