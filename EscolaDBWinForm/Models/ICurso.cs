using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDBWinForm.Models
{
    internal interface ICurso
    {
        //Layer de acesso a dados CRUD
        void Add(Curso curso);
        void Edit(Curso curso);
        void Delete(int id);
        IEnumerable<Curso> GetAll();
        IEnumerable<Curso> GetByValue(string value); //Search por valor


    }
}
