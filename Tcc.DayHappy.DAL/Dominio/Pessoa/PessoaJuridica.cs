using System;
using System.Collections.Generic;
using System.Text;

namespace Tcc.DayHappy.DAL.Dominio
{
    class PessoaJuridica
    {
        public int Cod_PJ { get; private set; }
        public string Razao_Social_PJ { get; private set; }
        public string Nome_Repres_PJ { get; private set; }
        public string Nome_Fantas_PJ { get; private set; }
        public string CNPJ_PJ { get; private set; }
        public string Insc_Estadual_PJ { get; private set; }
        public string Senha_PJ { get; private set; }
        public string Email_PJ { get; private set; }
        public string SENHA_PES_JUR { get; private set; }
        public string Tel1_PJ { get; private set; }
        public string Tel2_PJ { get; private set; }
        public Endereco Endereco { get; private set; }



    }
}
