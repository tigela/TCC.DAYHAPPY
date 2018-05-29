using System;
using System.Collections.Generic;
using System.Text;

namespace Tcc.DayHappy.DAL.Dominio
{
    class Endereco
    {
        public int Cod_End { get;private set; }
        public string Cep { get; private set; }
        public string Logradouro { get; private set; }
        public string Numero_Logradouro { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Ponto_Referencia { get; private set; }
    }
}

