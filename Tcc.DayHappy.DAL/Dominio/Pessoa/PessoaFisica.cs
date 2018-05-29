using System;
using System.Collections.Generic;
using System.Text;

namespace Tcc.DayHappy.DAL.Dominio
{
    class PessoaFisica
    {
        public string Nome_PF { get; private set; }
        public DateTime Data_Nasc_PF { get; private set; }
        public string Sexo_PF { get; private set; }
        public string CPF_PF { get; private set; }
        public string RG_PF { get; private set; }
        public string Senha_PF { get; private set; }
        public Endereco Endereco { get; private set; }



    }
}
