using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Model
{
    public class PessoaEntity
    {
        public int Id { get; private set; }
        public string NomeEmpresa { get; private set; }
        public string CPF { get; private set; }
        public string CNPJ { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public string ConfSenha { get; private set; }

        public PessoaEntity()
        {
        }

        public PessoaEntity(int id, string nomeEmpresa, string cpf, string cnpj, string email, string senha, string confSenha)
        {
            Id = id;
            NomeEmpresa = nomeEmpresa;
            CPF = cpf;
            CNPJ = cnpj;
            Email = email;
            Senha = senha;
            ConfSenha = confSenha;
        }
    }
}
