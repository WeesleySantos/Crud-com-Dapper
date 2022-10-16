
using LojaDeRoupas.Model;
using System.Collections.Generic;

namespace LojaDeRoupas.Interface
{
    public interface ICadastroDb
    {
        bool Insert(Cadastro cadastro);
        bool Update(Cadastro cadastro);
        bool Excluir(int id);
        List<Cadastro> Cadastros();
    }
}
