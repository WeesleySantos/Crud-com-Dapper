using Dapper;
using LojaDeRoupas.Factorie;
using LojaDeRoupas.Interface;
using LojaDeRoupas.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace LojaDeRoupas.MSSQL
{
    public class MSSQLCadastro : ICadastroDb
    {
        private readonly string _conexao;

        public MSSQLCadastro(ConfiguracaoCadastro configuracao)
        {
            _conexao = configuracao.ConexaoComBanco;
        }

        public List<Cadastro> Cadastros()
        {
            using (var conexao = new SqlConnection(_conexao))
            {
                var query = @"SELECT Id
                                    ,Nome
                                    ,SobreNome
                                    ,Email
                                    ,Endereco
                                FROM Cadastro";
                return conexao.Query<Cadastro>(query).ToList();
            }
        }

        public bool Excluir(int id)
        {
            using (var conexao = new SqlConnection(_conexao))
            {
                var query = @"DELETE FROM Cadastro WHERE Id = @Id";

                conexao.Execute(query, new { id });
                return true;
            }
        }

        public bool Insert(Cadastro cadastro)
        {
            using (var conexao = new SqlConnection(_conexao))
            {
                var sql = @"INSERT INTO Cadastro
                             (Nome
                             ,SobreNome
                             ,Email
                             ,Endereco)
                      VALUES
                             (@Nome
                             ,@SobreNome
                             ,@Email
                             ,@Endereco)";

                conexao.Execute(sql, new
                {
                    Nome = cadastro.Nome,
                    SobreNome = cadastro.SobreNome,
                    Email = cadastro.Email,
                    Endereco = cadastro.Endereco
                });
                return true;
            }
        }

        public bool Update(Cadastro cadastro)
        {
            using (var conexao = new SqlConnection(_conexao))
            {
                var sql = @"UPDATE Cadastro
                            SET Nome = @Nome, SobreNome = @SobreNome, Email = @Email, Endereco = @Endereco
                                   WHERE Id = @Id ";

                conexao.Execute(sql, new
                {
                    Nome = cadastro.Nome,
                    SobreNome = cadastro.SobreNome,
                    Email = cadastro.Email,
                    Endereco = cadastro.Endereco,
                    Id = cadastro.Id
                });
                return true;
            }
        }
    }
}
