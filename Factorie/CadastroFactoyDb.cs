﻿using LojaDeRoupas.Interface;
using LojaDeRoupas.MSSQL;
using System;

namespace LojaDeRoupas.Factorie
{
    public static class CadastroFactoyDb
    {
        public static ICadastroDb GetCadastroDb(ConfiguracaoCadastro configuracao)
        {
            switch (configuracao.TipoBanco)
            {
                case Enums.TipoBanco.MSSQL:
                    return new MSSQLCadastro(configuracao);
                case Enums.TipoBanco.ORACLE:
                default:
                    throw new ArgumentException($"Não existe configuracao para esse tipo de banco {configuracao.TipoBanco}");
            }
        }
    }
}
