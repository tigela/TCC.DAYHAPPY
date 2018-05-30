using System;
using System.Collections.Generic;
using System.Text;

namespace Tcc.DayHappy.DAL.Data_base.Repositorio
{
    public interface IRepositorio<T,A>
    {

        IEnumerable<T> GetAll();
        T GetById(int id);
        void Create(T t);
        void Update(T t);
        void Delete(T t);



    }
}
