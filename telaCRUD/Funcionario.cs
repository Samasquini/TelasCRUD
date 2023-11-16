using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System;

public class Funcionario
{
    string nome;
    string funcao;
    string endereco;
    string estado_civil;
    string telefone;
    string cpf;
    string rg;
    string email;
    double salario;
    DateTime data_nascimento;

    public Funcionario(string nome, string funcao, string endereco, string estado_civil, string telefone, string cpf, string rg, string email, double salario, DateTime data_nascimento)
    {
        this.nome = nome;
        this.funcao = funcao;
        this.endereco = endereco;
        this.estado_civil = estado_civil;
        this.telefone = telefone;
        this.cpf = cpf;
        this.rg = rg;
        this.email = email;
        this.salario = salario;
        this.data_nascimento = data_nascimento;
    }
    public Funcionario() { }
}