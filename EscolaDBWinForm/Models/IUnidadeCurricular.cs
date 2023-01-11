using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDBWinForm.Models
{
    internal interface IUnidadeCurricular
    {
        //Layer de acesso a dados CRUD
        void Add(UnidadeCurricular uc);
        void Edit(UnidadeCurricular uc);
        void Delete(int id);
        IEnumerable<UnidadeCurricular> GetAll();
        IEnumerable<UnidadeCurricular> GetByValue(string value); //Search por valor


    }
}
