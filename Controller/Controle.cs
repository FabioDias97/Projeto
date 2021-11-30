using Projeto.DAO;
using Projeto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Controller
{
    public class Controle
    {
        public bool Cadastrar(PessoaEntity CadastroAnunciante) 
        { 
            BancoInstance banco;
            bool resultado = false;

            using (banco = new BancoInstance()) 
            {
                resultado = banco.Banco.ExecuteNonQuery(@"INSERT INTO CadastroAnunciante(NomeEmpresa, CPF, CNPJ, Email, Senha, ConfSenha)
                    VALUES(@nomeanunciante, @cpf, @cnpj, @email, @senha, @confSenha)", "@nome", CadastroAnunciante.NomeEmpresa, 
                    "@cpf", CadastroAnunciante.CPF,"@cnpj", CadastroAnunciante.CNPJ, "@email", CadastroAnunciante.Email, 
                    "@senha", CadastroAnunciante.Senha, "@confSenha", CadastroAnunciante.ConfSenha);
            }
            return resultado;
        }
    }
}
