using System;
using System.Collections.Generic;
using System.Text;

namespace Tcc.DayHappy.DAL.Dominio.Funcionarios
{
    class Funcionario
    {
        public int Cod_Func { get; private set; }
        public string Nome_Func { get; private set; }
        public DateTime DataNasc_Func { get; private set; }
        public string Sexo_Func { get; private set; }
        public string Cpf_Func { get; private set; }
        public int Tel1_Func { get; private set; }
        public int Tel2_Func { get; private set; }
        public string Email_Func { get; private set; }
        public string Senha_Func { get; private set; }
        public string NomeCargo_Func { get; private set; }
        public decimal Salario_Func { get; private set; }
        public DateTime DataAdm_Func { get; private set; }
        public Endereco Endereco { get; private set; }



    }
}
