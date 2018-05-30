using System;
using System.Collections.Generic;
using System.Text;
using Tcc.DayHappy.DAL.Data_base.Repositorio;
using Tcc.DayHappy.DAL.Dominio;

namespace Tcc.DayHappy.DAL.Repositorio.Armazenar
{
    public class ProdutoArmazenar
    {
        private readonly ProdutoRepositorio _produtoRepository;

        public ProdutoArmazenar(ProdutoRepositorio produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public void Armazenar(int cod_Prod, string tipo_Prod, string tamanho_Prod, string faixa_Etaria_Prod,
            decimal valor_Locacao_Prod, decimal valor_Custo_Prod, string descricao_Pro, int quantidae_Prod)
        {
             var produto = _produtoRepository.GetById(cod_Prod);

            if (produto == null)
            {
                produto = new Produto(cod_Prod, tipo_Prod, tamanho_Prod, faixa_Etaria_Prod,
            valor_Locacao_Prod, valor_Custo_Prod, descricao_Pro, quantidae_Prod);
               _produtoRepository.Create(produto);
            }
            else
            {
                produto.Update(cod_Prod, tipo_Prod, tamanho_Prod, faixa_Etaria_Prod,
            valor_Locacao_Prod, valor_Custo_Prod, descricao_Pro, quantidae_Prod);
            }
        }




    }
}
