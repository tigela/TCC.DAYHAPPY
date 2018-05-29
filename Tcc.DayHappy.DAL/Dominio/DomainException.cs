using System;
using System.Collections.Generic;
using System.Text;

namespace Tcc.DayHappy.DAL.Dominio
{
    public class DomainException : Exception
    {
        public DomainException(string erro) : base(erro)
        {

        }

        public static void Quando(bool temErro, string erro)
        {
            if (temErro)
                throw new DomainException(erro);
        }
    }
}
