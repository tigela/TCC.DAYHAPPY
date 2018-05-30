using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DayHappy.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Tcc.DayHappy.DAL.Data_base.Repositorio;
using Tcc.DayHappy.DAL.Dominio;
using Tcc.DayHappy.DAL.Repositorio.Armazenar;

namespace DayHappy.Web.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly ProdutoRepositorio _produtoRepository;
        private readonly ProdutoArmazenar _produtoArmazenar;

        public ProdutosController(ProdutoArmazenar produtoArmazenar, ProdutoRepositorio produtoRepository)
        {
            _produtoRepository = produtoRepository;
            _produtoArmazenar = produtoArmazenar;

        }
        public IActionResult SelecionarProduto()

        {
            var produto = _produtoRepository.GetAll();
            if (produto.Any())
            {
                ViewBag.nome = produto.Select(p => p.Tipo_Prod);

                var viewmodel = produto.Select(p => new ProdutoViewModel
                {
                    Cod_Prod = p.Cod_Prod,
                    Tipo_Prod = p.Tipo_Prod,
                    Tamanho_Prod = p.Tamanho_Prod,
                    Faixa_Etaria_Prod = p.Faixa_Etaria_Prod,
                    Valor_Locacao_Prod = p.Valor_Locacao_Prod,
                    Valor_Custo_Prod = p.Valor_Custo_Prod,
                    Descricao_Pro = p.Descricao_Prod,
                    Quantidae_Prod = p.Quantidade_Prod
                });
                return View(viewmodel);
            }
            return View();
        }
          [HttpGet]
        public IActionResult CadastrarProduto(int  id )
        {
            var viewModel = new ProdutoViewModel();


            if (id > 0)
            {
                var p = _produtoRepository.GetById(id);
                viewModel.Cod_Prod = p.Cod_Prod;
                viewModel.Tipo_Prod = p.Tipo_Prod;
                viewModel.Tamanho_Prod = p.Tamanho_Prod;
                viewModel.Faixa_Etaria_Prod = p.Faixa_Etaria_Prod;
                viewModel.Valor_Locacao_Prod = p.Valor_Locacao_Prod;
                viewModel.Valor_Custo_Prod = p.Valor_Custo_Prod;
                viewModel.Descricao_Pro = p.Descricao_Prod;
                viewModel.Quantidae_Prod = p.Quantidade_Prod;
                return View(viewModel);
            }
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult CadastrarProduto(ProdutoViewModel model)
        {
            _produtoArmazenar.Armazenar(model.Cod_Prod, model.Tipo_Prod, model.Tamanho_Prod, model.Faixa_Etaria_Prod,
            model.Valor_Locacao_Prod, model.Valor_Custo_Prod, model.Descricao_Pro, model.Quantidae_Prod);
            return RedirectToAction("SelecionarProduto");
        }

        /*
        public IActionResult DeletarProdutos(int id)
        {
            var viewModel = new ProdutoViewModel();
            {
                if (id > 0)
                {
                    var produto = _produtoRepository.GetById(id);
                    viewModel.Id = produto.Id;
                    viewModel.NomeProduto = produto.NomeProduto;
                    viewModel.FaixaEtaria = produto.FaixaEtaria;
                    viewModel.Descricao = produto.Descricao;
                    viewModel.DataCompra = produto.DataCompra;
                    viewModel.ValorLocacao = produto.ValorLocacao;
                    viewModel.ValorCusto = produto.ValorCusto;
                    viewModel.CheckListPecas = produto.CheckListPecas;
                    return View(viewModel);
                }
                return View(viewModel);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletarProdutos(ProdutoViewModel viewModel)
        {

            _produtoArmazenar.Deletar(viewModel.Id, viewModel.NomeProduto, viewModel.FaixaEtaria, viewModel.Descricao,
                            viewModel.DataCompra, viewModel.ValorLocacao, viewModel.ValorCusto, viewModel.CheckListPecas);
            return RedirectToAction("ListadeProdutos");

        }*/
    }
}