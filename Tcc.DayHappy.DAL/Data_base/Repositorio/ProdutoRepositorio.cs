using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Tcc.DayHappy.DAL.Dominio;
using Dapper;
using System.Data.SqlClient;
using Tcc.DayHappy.DAL.Data_base.Util;

namespace Tcc.DayHappy.DAL.Data_base.Repositorio
{
    public class ProdutoRepositorio : IRepositorio<Produto,Produto_DB>
    {
        private const string TableName = "TB_PRODUTO";
        protected readonly string ConnectionString;

        public ProdutoRepositorio()
        {
            Conexao conexao = new Conexao();
            ConnectionString = conexao.GetConexao();
        }

        protected virtual IDbConnection Connection => new SqlConnection(ConnectionString);

        public void Create(Produto produto)
        {
            using (var connection = Connection)
            {
                connection.Execute(
                    $"INSERT INTO {TableName} VALUES(@Tipo_Prod,@Tamanho_Prod, @Faixa_Etaria_Prod," +
                    $"@Valor_Locacao_Prod,@Valor_Custo_Prod,@Descricao_Prod,@Quantidade_Prod)",
                    produto);
            }
        }

        public void Delete(Produto produto)
        {
            using (var connection = Connection)
            {
                connection.Execute($"DELETE FROM {TableName} WHERE Id=@Id", new { id = 1 });
            }
        }

        public IEnumerable<Produto> GetAll()
        {


            using (var connection = Connection)
            {
                var r = connection.Query<Produto>($" select ID_PROD as [Cod_Prod] FROM {TableName}");
                connection.Close();
                return r;

            }
        }

        public Produto GetById(int id)
        {
            using (var connection = Connection)
            {
                return connection.QueryFirstOrDefault<Produto>($"SELECT * FROM {TableName} WHERE Id_Prod=@Id",
                    new { Id = id });
            }
        }

        public void Update(Produto produto)
        {
            using (var connection = Connection)
            {
                connection.Execute(
                    $"UPDATE {TableName} SET Name=@Name, Address=@Address, Phone=@Phone, Birthday=@Birthday, Admission=@Admission, Rg=@Rg, Cpf=@Cpf, RegistrationNumber=@RegistrationNumber, Education=@Education WHERE Id=@Id",
                    produto);
            }
        }
    }
}
