using System;
using System.Collections.Generic;
using System.Text;

namespace Tcc.DayHappy.DAL.Dominio
{
    public class Produto
        {   
            public int Cod_Prod { get; private set; }
            public string Tipo_Prod { get; private set; }
            public string Tamanho_Prod { get; private set; }
            public string Faixa_Etaria_Prod { get; private set; }
            public decimal Valor_Locacao_Prod { get; private set; }
            public decimal Valor_Custo_Prod { get; private set; }
            public string Descricao_Prod { get; private set; }
            public int Quantidade_Prod { get; private set; }

        public Produto()
        {

        }



        public Produto(int cod_Prod, string tipo_Prod, string tamanho_Prod, string faixa_Etaria_Prod, 
            decimal valor_Locacao_Prod, decimal valor_Custo_Prod, string descricao_Pro, int quantidae_Prod)
        {

            ValidacaoValoresSetPropriedades(cod_Prod, tipo_Prod,  tamanho_Prod, faixa_Etaria_Prod,
            valor_Locacao_Prod,  valor_Custo_Prod,  descricao_Pro, quantidae_Prod);
        }
    


        //Lembrar de rever todos os tratamentos--> data compra
        //(ATENÇÃO) com check list de pecas é obrigatorio ???
        private void ValidacaoValoresSetPropriedades(int cod_Prod, string tipo_Prod, string tamanho_Prod, string faixa_Etaria_Prod,
            decimal valor_Locacao_Prod, decimal valor_Custo_Prod, string descricao_Pro, int quantidae_Prod)
        {
            /*
            DomainException.Quando(string.IsNullOrEmpty(), "Nome do Produto é obrigatorio");
           DomainException.Quando(nomeProduto.Length < 1, "Nome do produto Invalido");
            DomainException.Quando(string.IsNullOrEmpty(faixaEtaria), "Faixa Etaria é obrigatoria");
            DomainException.Quando(faixaEtaria.Length < 1, "Faixa Etaria Invalida");
            DomainException.Quando(valorLocacao < 0, "Valor Locação Invalido");
            DomainException.Quando(valorCusto < 0, "Valor Locação Invalido");
            DomainException.Quando(checkListPecas.Length < 0, "Check List das Peças Invalido");
             DomainException.Quando(string.IsNullOrEmpty(checkListPecas),"Check List das Pecas é Obrigatorio")
            */

            Cod_Prod = cod_Prod;
            Tipo_Prod = tipo_Prod;
            Tamanho_Prod = tamanho_Prod;
            Faixa_Etaria_Prod = faixa_Etaria_Prod;
            Valor_Locacao_Prod = valor_Locacao_Prod;
            Valor_Custo_Prod = valor_Custo_Prod;
            Descricao_Prod = descricao_Pro;
            Quantidade_Prod = quantidae_Prod;

        }

        public void Update(int cod_Prod, string tipo_Prod, string tamanho_Prod, string faixa_Etaria_Prod, 
            decimal valor_Locacao_Prod, decimal valor_Custo_Prod, string descricao_Pro, int quantidae_Prod)
        {
            ValidacaoValoresSetPropriedades(cod_Prod, tipo_Prod, tamanho_Prod, faixa_Etaria_Prod,
            valor_Locacao_Prod, valor_Custo_Prod, descricao_Pro, quantidae_Prod);
        }
    }



}
