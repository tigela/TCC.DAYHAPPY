using System;
using System.Collections.Generic;
using System.Text;

namespace Tcc.DayHappy.DAL.Data_base
{
    public class Conexao
    {
        public string GetConexao()
        {
            return "Server=(local);Database=DAYHAPPY;Integrated Security=SSPI";
            // return "Data Source=LAB3-PC16;Database=DB_DAYHAPPY;User ID=sa;Password=1234567;";

        }


    }
}
