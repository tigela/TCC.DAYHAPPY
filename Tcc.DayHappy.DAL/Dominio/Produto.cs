using System;
using System.Collections.Generic;
using System.Text;

namespace Tcc.DayHappy.DAL.Dominio
{
    class Produto
        {   
            public int Cod_Prod { get; private set; }
            public string Tipo_Prod { get; private set; }
            public string Tamanho_Prod { get; private set; }
            public string Faixa_Etaria_Prod { get; private set; }
            public decimal Valor_Locacao_Prod { get; private set; }
            public decimal Valor_Custo_Prod { get; private set; }
            public string Descricao_Pro { get; private set; }
            public int Quantidae_Prod { get; private set; }

    

        public Produto(string nomeProduto, string faixaEtaria, string descricao, DateTime dataCompra,
               decimal valorLocacao, decimal valorCusto, string checkListPecas)
        {
            ValidacaoValoresSetPropriedades(nomeProduto, faixaEtaria, descricao, dataCompra, valorLocacao, valorCusto, checkListPecas);
        }

        //Lembrar de rever todos os tratamentos--> data compra
        //(ATENÇÃO) com check list de pecas é obrigatorio ???
        private void ValidacaoValoresSetPropriedades(string nomeProduto, string faixaEtaria, string descricao, DateTime dataCompra,
            decimal valorLocacao, decimal valorCusto, string checkListPecas)
        {
            DomainException.Quando(string.IsNullOrEmpty(nomeProduto), "Nome do Produto é obrigatorio");
            DomainException.Quando(nomeProduto.Length < 1, "Nome do produto Invalido");
            DomainException.Quando(string.IsNullOrEmpty(faixaEtaria), "Faixa Etaria é obrigatoria");
            DomainException.Quando(faixaEtaria.Length < 1, "Faixa Etaria Invalida");
            DomainException.Quando(valorLocacao < 0, "Valor Locação Invalido");
            DomainException.Quando(valorCusto < 0, "Valor Locação Invalido");
            DomainException.Quando(checkListPecas.Length < 0, "Check List das Peças Invalido");
            // DomainException.Quando(string.IsNullOrEmpty(checkListPecas),"Check List das Pecas é Obrigatorio")
            NomeProduto = nomeProduto;
            FaixaEtaria = faixaEtaria;
            Descricao = descricao;
            DataCompra = dataCompra;
            ValorLocacao = valorLocacao;
            ValorCusto = valorCusto;
            CheckListPecas = checkListPecas;

        }

        public void Update(string nomeProduto, string faixaEtaria, string descricao, DateTime dataCompra,
            decimal valorLocacao, decimal valorCusto, string checkListPecas)
        {
            ValidacaoValoresSetPropriedades(nomeProduto, faixaEtaria, descricao, dataCompra, valorLocacao, valorCusto, checkListPecas);
        }
    }



}
