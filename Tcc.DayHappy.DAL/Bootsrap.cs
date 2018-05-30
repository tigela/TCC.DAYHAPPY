using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Tcc.DayHappy.DAL.Data_base.Repositorio;
using Tcc.DayHappy.DAL.Dominio;
using Tcc.DayHappy.DAL.Repositorio.Armazenar;

namespace Tcc.DayHappy.DAL
{
    public class Bootsrap
    {


        public static void Configure(IServiceCollection services, string conection)
        {
            services.AddScoped(typeof(ProdutoArmazenar));
            services.AddScoped(typeof(IRepositorio<Produto,Produto>), typeof(ProdutoRepositorio));
            services.AddScoped(typeof(Produto));
            services.AddScoped(typeof(ProdutoRepositorio));
        }

     }
}
