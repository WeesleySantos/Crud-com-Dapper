using LojaDeRoupas.Factorie;
using LojaDeRoupas.Interface;
using LojaDeRoupas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaDeRoupas.Models
{
    public class CadastroViewModels
    {
        public CadastroViewModels()
        {

        }

        private readonly ICadastroDb _cadastroDb;

        public CadastroViewModels(ConfiguracaoCadastro configuracao)
        {
            _cadastroDb = CadastroFactoyDb.GetCadastroDb(configuracao);
        }

        public Cadastro Cadastro { get; set; }

        public List<Cadastro> Cadastros { get; set; }

        public bool InserirCadastro(Cadastro cadastro)
        {
            return _cadastroDb.Insert(cadastro);
        }

        public bool AtualizarCadastro(Cadastro cadastro)
        {
            return _cadastroDb.Update(cadastro);
        }
        public bool EcluirCadastro(int id)
        {
            return _cadastroDb.Excluir(id);
        }
        public List<Cadastro> ListaDeCadastro()
        {
            return _cadastroDb.Cadastros();
        }
    }
}
